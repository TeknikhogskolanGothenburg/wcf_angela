<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerViewAllWebForm.aspx.cs" Inherits="CarRentalWebClient.CustomerViewAllWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater id="rptCustomers" runat="server">
            <HeaderTemplate>
                <table border="1">
                <tr>
                   <td>Customer ID</td>
                   <td>First Name</td>
                   <td>Last Name</td>
                   <td>Mobile</td>
                   <td>Email</td>
                   <td>Customer Type</td>
                    <td>Discount</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%></td>
                    <td><%#Eval("FirstName")%></td>
                    <td><%#Eval("LastName")%></td>
                    <td><%#Eval("Mobile")%></td>
                    <td><%#Eval("Email")%></td>
                    <td><%#Eval("CustomerType")%></td>
                    <td><%#Eval("Discount")%></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater> 
    </form>
</body>
</html>
