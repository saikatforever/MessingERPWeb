using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BO;
namespace DAL
{
    public interface IUsersDAL
    {
        usersBO GetUser(String ConStr,usersBO objUser);
    }
}
