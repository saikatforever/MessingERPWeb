using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using DAL;
namespace BLL
{
    public class UsersBLL: IUsersBLL
    {
        IUsersDAL objUserDAL=new UsersDAL();
        public usersBO GetUser(String ConStr, usersBO objUser)
        {
            try
            {
                objUser = objUserDAL.GetUser(ConStr,objUser);
            }
            catch
            {

            }
            return objUser;
        }
    }
}
