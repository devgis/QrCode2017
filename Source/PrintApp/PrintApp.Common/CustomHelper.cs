using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PrintApp.Common
{
    public class CustomHelper
    {
        /// <summary>
        /// 查询客户记录行
        /// </summary>
        /// <param name="MobileOrNO"></param>
        /// <returns></returns>
        public static DataRow GetCustomRow(string MobileOrNO)
        {
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}' or MOBILE='{0}'", MobileOrNO);
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
            string sql = "select * from t_custominfo";
            return SQLServerHelper.GetDataTable(sql);
            
        }

        /// <summary>
        /// 获取所有分会场未签到的客户
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllNotSign()
        {
            string sql = "select * from T_CUSTOMINFO where CUSTNO not in (select CUSTNO from t_FHCSIGN)";
            return SQLServerHelper.GetDataTable(sql);

        }

        /// <summary>
        /// 获取各分会场签到的客户
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllFHCSign()
        {
            string sql = "select t.fhc,c.* from t_FHCSIGN t left join T_CUSTOMINFO c on t.custno=c.CUSTNO order by fhc";
            return SQLServerHelper.GetDataTable(sql);

        }

        /// <summary>
        /// 根据手机查询客户编码
        /// </summary>
        /// <param name="MobileOrNO"></param>
        /// <returns></returns>
        public static string GetCustomNo(string MobileOrNO)
        {
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}' or MOBILE='{0}'", MobileOrNO);
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
        /// 客户号签到
        /// </summary>
        /// <param name="CustNO"></param>
        /// <returns></returns>
        public static bool CustomSign(string CustNO)
        {
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}'", CustNO);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dtTemp.Rows[0]["SIGNTIME"].ToString()))
                {
                    sql = string.Format("update t_custominfo set SIGNTIME=getdate(),PRINTCOUNT=1 where CUSTNO='{0}'", CustNO);
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
        /// 领取纪念品
        /// </summary>
        /// <param name="CustNO"></param>
        /// <returns></returns>
        public static bool GetSouvenirs(string CustNO,out string CustName)
        {
            CustName = string.Empty;
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}'", CustNO);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dtTemp.Rows[0]["GETSOUVENIRSTIME"].ToString()))
                {
                    CustName = dtTemp.Rows[0]["CUSTNAME"].ToString();
                    sql = string.Format("update t_custominfo set GETSOUVENIRSTIME=getdate(),PRINTCOUNT=1 where CUSTNO='{0}'", CustNO);
                    return SQLServerHelper.ExecSql(sql, null);
                }
                else
                {
                    throw new Exception("已领取");
                }
            }
            else
            {
                return false;
 
            }
            
        }

        /// <summary>
        /// 就餐验证
        /// </summary>
        /// <param name="CustNO"></param>
        /// <returns></returns>
        public static bool DineCheck(string CustNO,out string CustNAME)
        {
            CustNAME = string.Empty;
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}'", CustNO);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                int CustNo = Convert.ToInt32(CustNO);
                if (CustNo > 0 && CustNo <= 700)
                {
                    if (string.IsNullOrEmpty(dtTemp.Rows[0]["DINETIME"].ToString()))
                    {
                        CustNAME = dtTemp.Rows[0]["CUSTNAME"].ToString();
                        sql = string.Format("update t_custominfo set DINETIME=getdate(),PRINTCOUNT=1 where CUSTNO='{0}'", CustNO);
                        return SQLServerHelper.ExecSql(sql, null);
                    }
                    else
                    {
                        throw new Exception("已就餐");
                    }
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;

            }

        }

        /// <summary>
        /// 获取编号
        /// </summary>
        /// <returns></returns>
        public static int GetMaxNO()
        {
            try
            {
                string sql = "SELECT MAX(CUSTNO) from T_CUSTOMINFO";
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
                else if (dt == null)
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
        /// <param name="CustType"></param>
        /// <param name="CustName"></param>
        /// <param name="Position"></param>
        /// <param name="Company"></param>
        /// <param name="Mobile"></param>
        /// <returns>成功返回编号 否则返回空</returns>
        public static string CustomTempSign(string CustType,string CustName, string Position, string Company, string Mobile)
        {
            if (string.IsNullOrEmpty(CustName) || string.IsNullOrEmpty(Mobile))
                return string.Empty;
            else
            {
                int currentNO=GetMaxNO();
                if (currentNO < 0)
                {
                    return string.Empty;
                }
                else
                {
                    string NewCustNO = (currentNO + 1).ToString().PadLeft(5, '0');
                    string sql = "insert into t_custominfo (CUSTTYPE,CUSTNO,CUSTNAME,POSITION,COMPANY,MOBILE,SIGNTIME,PRINTCOUNT)values(@CUSTTYPE,@CUSTNO,@CUSTNAME,@POSITION,@COMPANY,@MOBILE,getdate(),1)";
                    SqlParameter[] par = new SqlParameter[]
                    {
                        new SqlParameter("CUSTTYPE",SqlDbType.VarChar),
                        new SqlParameter("CUSTNO",SqlDbType.VarChar),
                        new SqlParameter("CUSTNAME",SqlDbType.VarChar),
                        new SqlParameter("POSITION",SqlDbType.VarChar),
                        new SqlParameter("COMPANY",SqlDbType.VarChar),
                        new SqlParameter("MOBILE",SqlDbType.VarChar)
                    };
                    par[0].Value = CustType;
                    par[1].Value = NewCustNO;
                    par[2].Value = CustName;
                    par[3].Value = Position;
                    par[4].Value = Company;
                    par[5].Value = Mobile;

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
        /// 分会场客户号签到
        /// </summary>
        /// <param name="CustNO"></param>
        /// <param name="partNO">分会场</param>
        /// <returns></returns>
        public static bool CustomSign(string CustNO,int partNO)
        {
            string sql = string.Format("select * from T_FHCSIGN where CUSTNO='{0}' and FHC={1}", CustNO,partNO);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                throw new Exception("已签到");
                
            }
            else
            {
                sql = string.Format(" INSERT INTO T_FHCSIGN (FHC,CUSTNO,SIGNTIME) VALUES({0},'{1}',getdate())", partNO, CustNO);
                return SQLServerHelper.ExecSql(sql, null);
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


        /// <summary>
        /// 客户签到
        /// </summary>
        /// <param name="CustNOorMobile">手机或者客户号</param>
        /// <param name="CustNO">客户号</param>
        /// <returns></returns>
        public static bool CanPrint(string CustNOorMobile,out string CustNO)
        {
            CustNO = string.Empty;
            string sql = string.Format("select * from t_custominfo where CUSTNO='{0}'", CustNOorMobile);
            DataTable dtTemp = SQLServerHelper.GetDataTable(sql);
            if (dtTemp.Rows.Count > 0)
            {
                CustNO = dtTemp.Rows[0]["CUSTNO"].ToString();
                int count = Convert.ToInt32(dtTemp.Rows[0]["printcount"]);
                if (count >= 3)
                {
                    throw new Exception("打印超过3次");
                }
                else
                {
                    sql = string.Format("update t_custominfo set PRINTCOUNT=PRINTCOUNT+1 where CUSTNO='{0}'", CustNO);
                    return SQLServerHelper.ExecSql(sql, null);
                }

            }
            else
            {
                return false;
            }

        }

    }
}
