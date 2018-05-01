<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_3342DevStepFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%-- Styling Stuff --%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">
    <%-- /Styling Stuff --%>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.10/css/all.css" integrity="sha384-+d0P83n9kaQMCwj8F4RJB66tzIwOKmrdb46+porD/OvrJ+37WqIM7UoBtwHO6Nlg" crossorigin="anonymous">

    <title></title>
    <link href="css/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Login</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label ID="lblEmail" ForeColor="Black" Font-Bold="true" Text="Email" runat="server"></asp:Label>
                        <asp:TextBox ID="txtEmail" ForeColor="Black" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPassword" ForeColor="Black" Font-Bold="true" Text="Password" runat="server"></asp:Label>
                        <asp:TextBox ID="txtPassword" ForeColor="Black" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div style="text-align:center">
                        <div class="checkbox">
                            <asp:CheckBox ID="chkRemember" Checked="true" ForeColor="Black" Text="Remember Me" runat="server"/>
                        </div>
                    </div>
                    <div style="float:left">
                        <asp:Button ID="btnRegister" Text="Register" CssClass="btn btn-primary" runat="server" OnClick="btnRegister_Click" />
                    </div>
                    <div style="float:right">
                        <asp:Button ID="btnLogin" Text="Login" CssClass="btn btn-primary" runat="server" OnClick="btnLogin_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4"></div>
    
    </div>
        <!-- JQuery Code -->
    <script
        src="https://code.jquery.com/jquery-3.3.1.js"
        integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="
        crossorigin="anonymous">
    </script>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>


            <script src="color.js"></script>
    </form>
</body>
</html>
