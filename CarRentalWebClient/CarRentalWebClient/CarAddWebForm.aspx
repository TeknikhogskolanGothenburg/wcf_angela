<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarAddWebForm.aspx.cs" Inherits="CarRentalWebClient.CarAddWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <h2>Add Car Information</h2>
        </div>
        <table style="font-family: Arial; border: 1px solid black;">
            <tr>
                <td>
                    <b>ID</b>
                </td>
                <td>
                    <asp:TextBox ID="txtCarId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Register Number</b>
                </td>
                <td>
                    <asp:TextBox ID="txtRegisterNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Brand</b>
                </td>
                <td>
                    <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Model</b>
                </td>
                <td>
                    <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <b>Day Rent</b>
                </td>
                <td>
                    <asp:TextBox ID="txtDayRent" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <b>Year</b>
                </td>
                <td>
                    <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <b>Status</b>
                </td>
                <td>
                    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessageCar" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
                </td>
            </tr>

        </table>

         <asp:Button ID="btnNewCar" runat="server" Text="Save" OnClick="btnNewCar_Click" />
         <asp:Button ID="btnBackToHome" runat="server" Text="Back" OnClick="btnBackToHome_Click" />
    </form>
</body>
</html>
