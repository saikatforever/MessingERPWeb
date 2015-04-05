using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
/// <summary>
/// Summary description for commonConfig
/// </summary>
public static class commonConfig
{
    public static String ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ToString();
    public static String cssDivErrorClass = "alert alert-danger alert-dismissable";
}