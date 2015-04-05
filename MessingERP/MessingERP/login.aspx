<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Messing ERP | Log in</title>
    <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no'
        name='viewport'>
    <!-- Bootstrap 3.3.2 -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Font Awesome Icons -->
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"
        rel="stylesheet" type="text/css" />
    <!-- Theme style -->
    <link href="dist/css/AdminLTE.min.css" rel="stylesheet" type="text/css" />
    <!-- iCheck -->
    <link href="plugins/iCheck/square/blue.css" rel="stylesheet" type="text/css" />
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->
    <style>
        .ErrorControl
        {
            border: solid 1px Red !important;
        }

    </style>
</head>
<body class="login-page">
    <form id="Form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress2" runat="server" DisplayAfter="0">
        <ProgressTemplate>
            <div style="top: 0px; height: 100%; background-color: White; opacity: 0.80; filter: alpha(opacity=80);
                vertical-align: middle; left: 0px; z-index: 999999; width: 100%; position: fixed;
                text-align: center; vertical-align: middle">
                <table width="100%" height="100%">
                    <tr>
                        <td align="center" valign="middle">
                            <img id="Img1" src="images/loader.gif" alt="" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="login-box">
                <div class="login-logo">
                    <a href="login.aspx"><b>Messing</b>ERP</a>
                </div>
                <!-- /.login-logo -->
                <div id="dvMessage" runat="server">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">
                        ×</button>
                    <h4>
                        <i class="icon fa fa-ban"></i>Alert!</h4>
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </div>
                <div class="login-box-body">
                    <p class="login-box-msg">
                        Sign in to start your session</p>
                    <div class="form-group has-feedback">
                        <asp:TextBox runat="server" ID="txtUserName" class="form-control" placeholder="Username"></asp:TextBox>
                        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtUserName"
    runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox runat="server" ID="txtPassword" class="form-control" placeholder="Password"
                            TextMode="Password"></asp:TextBox>
                        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                    </div>
                    <div class="row">
                        <div class="col-xs-8">
                            <div class="checkbox icheck">
                                <label>
                                    <input type="checkbox">
                                    Remember Me
                                </label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                        </div>
                        <!-- /.col -->
                        <div class="col-xs-4">
                            <asp:Button ID="btnLogin" runat="server" Text="Sign In" class="btn btn-primary btn-block btn-flat"
                                OnClick="btnLogin_Click" />
                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- /.social-auth-links -->
                    <a href="#">I forgot my password</a><br>
                </div>
                <!-- /.login-box-body -->
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <!-- /.login-box -->
    </form>
    <!-- jQuery 2.1.3 -->
    <script src="plugins/jQuery/jQuery-2.1.3.min.js"></script>
    <!-- Bootstrap 3.3.2 JS -->
    <script src="bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <!-- iCheck -->
    <script src="plugins/iCheck/icheck.min.js" type="text/javascript"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
        function changeCheckRadio() {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        }
        function closeAlert() {
            $('#<%= dvMessage.ClientID %>').delay(10000).hide(4000);
        }
        function WebForm_OnSubmit() {
            if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) {
                for (var i in Page_Validators) {
                    try {
                        var control = document.getElementById(Page_Validators[i].controltovalidate);
                        if (!Page_Validators[i].isvalid) {
                            control.className = "ErrorControl form-control";
                        } else {
                            control.className = "form-control";
                        }
                    } catch (e) { }
                }
                return false;
            }
            return true;
        }

    </script>
</body>
</html>
