<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarViewAllWebForm.aspx.cs" Inherits="CarRentalWebClient.CarViewAllWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater id="rptCars" runat="server">
            <HeaderTemplate>
                <table border="1">
                <tr>
                   <td>Car ID</td>
                   <td>Register Number</td>
                   <td>Brand</td>
                   <td>Model</td>
                   <td>Day Rent</td>
                   <td>Year</td>
                   <td>Status</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%></td>
                    <td><%#Eval("RegisterNumber")%></td>
                    <td><%#Eval("Brand")%></td>
                    <td><%#Eval("Model")%></td>
                    <td><%#Eval("DayRent")%></td>
                    <td><%#Eval("Year")%></td>
                    <td><%#Eval("Status")%></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:Button ID="backToMainButton" runat="server" Text="Back" OnClick="back_Click" />
    </form>
</body>
</html>
