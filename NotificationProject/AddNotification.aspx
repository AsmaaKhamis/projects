<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNotification.aspx.cs" Inherits="AddNotification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 56%;
            height: 156px;
        }
        .auto-style2 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#006666" Text="Notification Website"></asp:Label>
        <br />
        <br />
        Send Notification Update Website<br />
        <br />
        <br />
        <table class="auto-style1" style="background-color: #009999">
            <tr>
                <td class="auto-style2" style="font-size: medium">Type Text:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="71px" TextMode="MultiLine" Width="241px"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#996633" Height="33px" OnClick="Button1_Click" Text="Send" />
                    <br />
                    <asp:Label ID="Label2" runat="server" ForeColor="#996633"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </form>
</body>
</html>
