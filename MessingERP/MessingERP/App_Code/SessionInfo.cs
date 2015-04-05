using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SessionInfo
/// </summary>
public static class SessionInfo
{
    public static Boolean isLoggedIn { get; set; } 
    public static Int16 ID { get; set; }
    public static string UserName { get; set; }
    public static string FName { get; set; }
    public static string MName { get; set; }
    public static string LName { get; set; }
    public static string ImgExt { get; set; }
    public static string Email { get; set; }
}