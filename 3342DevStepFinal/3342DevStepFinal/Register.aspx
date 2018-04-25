<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_3342DevStepFinal.Register" %>

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
        <div class="col-md-2">
        </div>
        <div class="col-md-8">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Register</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label ID="lblName" Text="Full Name:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtName" ForeColor="Black" runat="server" Width="244px"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblAddress" Text="Address:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtAddress" ForeColor="Black" runat="server" Width="444px"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCCNum" Text="Credit Card Number:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtCCNum" ForeColor="Black" runat="server" Width="221px"></asp:TextBox>
                        <asp:Label ID="lblExpire" Text="Expiration Date:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtExpire" ForeColor="Black" runat="server"></asp:TextBox>
                        <asp:Label ID="lblSecure" Text="Security Code:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtSecure" ForeColor="Black" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblEmail" Text="Email:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtEmail" ForeColor="Black" runat="server"></asp:TextBox>
                        <asp:Label ID="lblPassword" Text="Password:" ForeColor="Black" runat="server"></asp:Label>
                        <asp:TextBox ID="txtPassword" ForeColor="Black" runat="server"></asp:TextBox>
                    </div>
                    <div style="float:right">
                        <asp:Button ID="btnRegister" Text="Register" CssClass="btn btn-primary" runat="server" OnClick="btnRegister_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
    </form>
    <!-- JQuery Code -->
    <script
        src="https://code.jquery.com/jquery-3.3.1.js"
        integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="
        crossorigin="anonymous">
    </script>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</body>
</html>
