<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 68px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#006666" Text="NotificationWebsite"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" Text="RealTime Nptification"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
        <asp:Panel ID="Panel1" runat="server" BorderColor="#006666" BorderStyle="Solid" Height="187px" style="background-color: #009999" Width="207px">
            <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AllNotifications.aspx">View All Notifications</asp:HyperLink>
        </asp:Panel>
        <p>
        </p>
        <asp:Timer ID="Timer1" runat="server" Interval="6000" OnTick="Timer1_Tick"></asp:Timer>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
