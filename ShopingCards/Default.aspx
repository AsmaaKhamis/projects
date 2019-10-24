<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 257px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #009999;
        }
    </style>
</head>
<body style="height: 329px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#006666" Text="E-Commerce"></asp:Label>
        <br />
        <br />
        <span class="auto-style2"><strong>welcom in My wepsite&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No.Of Products in your card:&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddToCart.aspx">Show Cards</asp:HyperLink>
        <br />
        <br />
        <br />
        </strong></span>
        <asp:DataList ID="DataList1" runat="server" BackColor="#0099FF" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" GridLines="Both" Height="532px" RepeatColumns="3" RepeatDirection="Horizontal" Width="194px" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <ItemTemplate>
                <table border="1" class="auto-style1" style="background-color: #33CCFF">
                    <tr>
                        <td style="text-align: center">Product ID:<asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" style="text-align: center" Text='<%# Eval("ProductName") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("productimge") %>' Width="200px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">Rs<asp:Label ID="Label5" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="addtocard" Height="51px" ImageUrl="~/images/7.jpg" Width="135px" CommandArgument='<%# Eval("ProductID") %>' />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingCardConnectionString2 %>" SelectCommand="SELECT * FROM [ProductDetails]"></asp:SqlDataSource>
    </form>
</body>
</html>
