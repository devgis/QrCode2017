using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SignWeb.Common.Entities;
using System.IO;
using System.Drawing;
using System.Web;

namespace SignWeb.Common
{
    public class CustomHelper
    {
        private static Bitmap logobmp=null;
        public static Bitmap getLogoImage()
        {
            if (logobmp == null)
            {
                string logofile = "img/qrlogo.png";
                if (!File.Exists(HttpContext.Current.Server.MapPath(logofile)))
                {
                    return null;
                }
                else
                {
                    Bitmap Bmp = new Bitmap(HttpContext.Current.Server.MapPath(logofile));
                    logobmp = new Bitmap(Bmp, 100, 100);
                }
            }
            return logobmp;
        }


        /// <summary>
        /// 查询客户记录行
        /// </summary>
        /// <param name="MobileOrNO"></param>
        /// <returns></returns>
        public static DataRow GetCustomRow(string MobileOrNO)
        {
            string sql = string.Format("select * from t_custominfo2 where CUSTNO='{0}' or MOBILE='{0}'", MobileOrNO);
            DataTable dt = SQLServerHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取所有客户信息用于导出
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllCustom()
        {
            string sql = "select * from t_custominfo2 order by CUSTNO";
            return SQLServerHelper.GetDataTable(sql);
            
        }

        /// <summary>
        /// 获取编号
        /// </summary>
        /// <returns></returns>
        public static int GetMaxNO()
        {
            try
            {
                string sql = "SELECT MAX(CUSTNO) from T_CUSTOMINFO2";
                DataTable dt = SQLServerHelper.GetDataTable(sql, null);
                if (dt != null && dt.Rows.Count > 0)
                {
                    try
                    {
                        return Convert.ToInt32(dt.Rows[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                }
                else if(dt==null)
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
            return -1;
        }
        
        /// <summary>
        /// 临时签到
        /// </summary>
        /// <param name="custom">客户信息</param>
        /// <returns>成功返回编号失败返回空</returns>
        public static string AddCustom2(CustomInfo custom)
        {
            if (string.IsNullOrEmpty(custom.Name) || string.IsNullOrEmpty(custom.Mobile))
            {
                return string.Empty;
            }
            else
            {
                int currentNO=GetMaxNO();
                if(currentNO<0)
                {
                    return string.Empty;
                }
                else
                {
                    string NewCustNO=(currentNO+1).ToString().PadLeft(4,'0');
                    string sql = "insert into t_custominfo2 (CUSTNO,CUSTNAME,POSITION,COMPANY,COMPANYADD,INVITER,MOBILE,EMAIL,PRINTCOUNT)values(@CUSTNO,@CUSTNAME,@POSITION,@COMPANY,@COMPANYADD,@INVITER,@MOBILE,@EMAIL,1)";
                    SqlParameter[] par = new SqlParameter[]
                    {
                        new SqlParameter("CUSTNO",SqlDbType.VarChar),
                        new SqlParameter("CUSTNAME",SqlDbType.VarChar),
                        new SqlParameter("POSITION",SqlDbType.VarChar),
                        new SqlParameter("COMPANY",SqlDbType.VarChar),
                        new SqlParameter("COMPANYADD",SqlDbType.VarChar),
                        new SqlParameter("INVITER",SqlDbType.VarChar),
                        new SqlParameter("MOBILE",SqlDbType.VarChar),
                        new SqlParameter("EMAIL",SqlDbType.VarChar)
                    };
                    par[0].Value = NewCustNO;
                    par[1].Value = custom.Name;
                    par[2].Value = custom.Position;
                    par[3].Value = custom.Company;
                    par[4].Value = custom.CompanyAddress;
                    par[5].Value = custom.Inviter;
                    par[6].Value = custom.Mobile;
                    par[7].Value = custom.Email;
                    if (SQLServerHelper.ExecSql(sql, par))
                    {
                        return NewCustNO;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
  
                
            }
            ////string sql = string.Format("select * from t_custominfo where CUSTNO='{0}'", CustNO);
            ////DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            ////if (dtTemp.Rows.Count > 0)
            ////{
            ////    if (string.IsNullOrEmpty(dtTemp.Rows[0]["SIGNTIME"].ToString()))
            ////    {
            ////        sql = string.Format("update t_custominfo set SIGNTIME=getdate(),PRINTCOUNT=1 where CUSTNO='{0}'", CustNO);
            ////        return SQLServerHelper.ExecSql(sql, null);
            ////    }
            ////    else
            ////    {
            ////        return false;
            ////    }
            ////}
            ////else
            ////{
            ////    throw new Exception("客户信息不存在");

            ////}

        }

        /// <summary>
        /// 根据手机查询客户编码
        /// </summary>
        /// <param name="MobileOrNO"></param>
        /// <returns></returns>
        public static string GetCustomNo(string MobileOrNO)
        {
            string sql = string.Format("select * from t_custominfo2 where CUSTNO='{0}' or MOBILE='{0}'", MobileOrNO);
            DataTable dt = SQLServerHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CUSTNO"].ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 判断用户手机已存在
        /// </summary>
        /// <param name="MobileOrNO"></param>
        /// <returns></returns>
        public static bool ExistMobile(string Mobile,out string CustNO)
        {
            CustNO = string.Empty;
            string sql = string.Format("select * from t_custominfo2 where MOBILE='{0}'", Mobile);
            DataTable dt = SQLServerHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                CustNO = dt.Rows[0]["MOBILE"].ToString();
                return true; //已存在
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 客户号签到
        /// </summary>
        /// <param name="CustNO"></param>
        /// <returns></returns>
        public static bool CustomSign(string CustNO)
        {
            string sql = string.Format("select * from t_custominfo2 where CUSTNO='{0}'", CustNO);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dtTemp.Rows[0]["SIGNTIME"].ToString()))
                {
                    sql = string.Format("update t_custominfo2 set SIGNTIME=getdate() where CUSTNO='{0}'", CustNO);
                    return SQLServerHelper.ExecSql(sql, null);
                }
                else
                {
                    throw new Exception("已签到");
                }
            }
            else
            {
                return false;

            }

        }

        /// <summary>
        /// 客户签到
        /// </summary>
        /// <param name="Mobile">手机</param>
        /// <param name="CustNO">客户号</param>
        /// <returns></returns>
        public static bool CustomSignByMobile(string Mobile,out string CustNO)
        {
            CustNO = string.Empty;
            string sql = string.Format("select * from t_custominfo where MOBILE='{0}'", Mobile);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dtTemp.Rows[0]["SIGNTIME"].ToString()))
                {
                    sql = string.Format("update t_custominfo set SIGNTIME=getdate(),PRINTCOUNT=1 where MOBILE='{0}'", Mobile);
                    CustNO = dtTemp.Rows[0]["CUSTNO"].ToString();
                    return SQLServerHelper.ExecSql(sql, null);
                }
                else
                {
                    throw new Exception("已签到");
                }
            }
            else
            {
                throw new Exception("客户信息不存在");

            }

        }
    }
}
