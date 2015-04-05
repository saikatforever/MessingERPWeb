using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BO;
namespace BLL
{
    public interface IUsersBLL
    {
        usersBO GetUser(String ConStr, usersBO objUser);
    }
}
