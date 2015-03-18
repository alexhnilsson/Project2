<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projekt_2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/Login_Register_syle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            color: #FFF;
        }
        .auto-style2 {
            font-family: Tahoma;
            width: 100%
        }
        .auto-style3 {
            font-family: Tahoma;
            color: #000000;
            padding-left: auto;
            padding-right: auto;
            margin-left: auto;
            margin-right: auto;
            width: 580px;
            
        }

        .auto-style4 {
            width: 580px;
        }
        .auto-style5 {
            width: 529px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" style="font-size: xx-large; text-align: center">
    
        <br />
        <br />
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxUserName" runat="server" Width="180px" style="margin-left: 0px" Font-Size="15pt" Height="25px" BackColor="#CCFFFF" BorderStyle="Ridge">Username</asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="Please enter Username" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="180px" Font-Size="15pt" Height="25px" BackColor="#CCFFFF" BorderStyle="Ridge">Password</asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Please enter Password" ForeColor="#CC0000">Password</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button_Login" runat="server" OnClick="Button_Login_Click" Text="Login" Width="90px" />
                    <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" Text="Register" Width="90px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NET_Projekt_2_ADO_ASP_ShopConnectionString %>" SelectCommand="SELECT [UserID], [Email], [Username] FROM [User]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
