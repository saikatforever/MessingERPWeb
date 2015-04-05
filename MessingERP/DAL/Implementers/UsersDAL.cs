using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BO;
namespace DAL
{
    public class UsersDAL : IUsersDAL
    {
        SQLDataHelper objSqlHelper = new SQLDataHelper();
        public usersBO GetUser(String ConStr,usersBO objUser)
        {
            DataSet ds = new DataSet();
            try
            {
                var param = new SqlParameter[18];
                param[0] = new SqlParameter("@Action", objUser.Action);
                param[1] = new SqlParameter("@ID", objUser.ID);
                param[2] = new SqlParameter("@Username", objUser.Username);
                param[3] = new SqlParameter("@Password", objUser.Password);
                param[4] = new SqlParameter("@UserType", objUser.UserType);
                param[5] = new SqlParameter("@FName", objUser.FName);
                param[6] = new SqlParameter("@MName", objUser.MName);
                param[7] = new SqlParameter("@LName", objUser.LName);
                param[8] = new SqlParameter("@Addr", objUser.Addr);
                param[9] = new SqlParameter("@MobileNo", objUser.MobileNo);
                param[10] = new SqlParameter("@Email", objUser.Email);
                param[11] = new SqlParameter("@ImgExt", objUser.ImgExt);
                param[12] = new SqlParameter("@IsActive", objUser.IsActive);
                param[13] = new SqlParameter("@InsertedOn", objUser.InsertedOn);
                param[14] = new SqlParameter("@InsertedBy", objUser.InsertedBy);
                param[15] = new SqlParameter("@LastUpdatedOn", objUser.LastUpdatedOn);
                param[16] = new SqlParameter("@LastUpdatedBy", objUser.LastUpdatedBy);
                param[17] = new SqlParameter("@QueryStatus", 0);
                param[17].Direction = ParameterDirection.Output;
                objUser = new usersBO();
                ds = objSqlHelper.ExecuteSelect(ConStr, "spUsers", CommandType.StoredProcedure, param);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    if (row["ID"] != DBNull.Value) { objUser.ID = Convert.ToInt16(row["ID"]); }
                    if (row["Username"] != DBNull.Value) { objUser.Username = row["Username"].ToString(); }
                    if (row["Password"] != DBNull.Value) { objUser.Password = row["Password"].ToString(); }
                    if (row["UserType"] != DBNull.Value) { objUser.UserType = row["UserType"].ToString(); }
                    if (row["FName"] != DBNull.Value) { objUser.FName = row["FName"].ToString(); }
                    if (row["MName"] != DBNull.Value) { objUser.MName = row["MName"].ToString(); }
                    if (row["LName"] != DBNull.Value) { objUser.LName = row["LName"].ToString(); }
                    if (row["Addr"] != DBNull.Value) { objUser.Addr = row["Addr"].ToString(); }
                    if (row["MobileNo"] != DBNull.Value) { objUser.MobileNo = row["MobileNo"].ToString(); }
                    if (row["Email"] != DBNull.Value) { objUser.Email = row["Email"].ToString(); }
                    if (row["ImgExt"] != DBNull.Value) { objUser.ImgExt = row["ImgExt"].ToString(); }
                    if (row["IsActive"] != DBNull.Value) { objUser.IsActive = Convert.ToBoolean(row["IsActive"].ToString()); }
                    if (row["InsertedOn"] != DBNull.Value) { objUser.InsertedOn = Convert.ToDateTime(row["InsertedOn"].ToString()); }
                    if (row["InsertedBy"] != DBNull.Value) { objUser.InsertedBy = Convert.ToInt16(row["InsertedBy"].ToString()); }
                    if (row["LastUpdatedOn"] != DBNull.Value) { objUser.LastUpdatedOn = Convert.ToDateTime(row["LastUpdatedOn"].ToString()); }
                    if (row["LastUpdatedBy"] != DBNull.Value) { objUser.LastUpdatedBy = Convert.ToInt16(row["LastUpdatedBy"].ToString()); }
                }
            }
            catch
            {

            }
            return objUser;
        }
    }
}
