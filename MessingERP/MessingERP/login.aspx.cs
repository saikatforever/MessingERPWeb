using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BLL;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dvMessage.Visible = false;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        IUsersBLL objUserBLL=new UsersBLL();
        usersBO objUser = new usersBO();
        objUser.Action = "login";
        objUser.Username = txtUserName.Text;
        objUser.Password = txtPassword.Text;
        dvMessage.Visible = false;
        try
        {
            objUser = objUserBLL.GetUser(commonConfig.ConnectionString, objUser);
            if (objUser!= null && objUser.ID != null && objUser.ID > 0)
            {
                SessionInfo.isLoggedIn = true;
                SessionInfo.ID = objUser.ID;
                SessionInfo.UserName = objUser.Username;
                SessionInfo.FName = objUser.FName;
                SessionInfo.MName = objUser.MName;
                SessionInfo.LName = objUser.LName;
                SessionInfo.ImgExt = objUser.ImgExt;
                SessionInfo.Email = objUser.Email;
            }
            else
            {
                dvMessage.Visible = true;
                dvMessage.Attributes.Add("class", commonConfig.cssDivErrorClass);
                ltrMessage.Text = "Login failed!!! Invalid Username or password!!! Please try again.";
                UpdatePanel1.Update();
            }
        }
        catch
        {

        }
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "login", "<script>changeCheckRadio()</script>", false);
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "closeAlert", "<script>closeAlert()</script>", false);
    }
}