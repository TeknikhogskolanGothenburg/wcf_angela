<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAddWebForm.aspx.cs" Inherits="CarRentalWebClient.CustomerAddWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Add Customer Information</h2>
        </div>
        <table style="font-family: Arial; border: 1px solid black;">
            <tr>
                <td>
                    <b>ID</b>
                </td>
                <td>
                    <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>First Name</b>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Last Name</b>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Mobile</b>
                </td>
                <td>
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Email</b>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Customer Type</b>
                </td>
                <td>
                    <asp:DropDownList ID="customerTypeDropDownList" runat="server" 
                          OnSelectedIndexChanged ="customerTypeDropDownList_SelectedIndexChanged"
                            AutoPostBack="true">
                        <asp:ListItem Text="Select Customer Type" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Pay As Go" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Contract" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr id="trdiscount" runat="server" visible="false">
                <td>
                    <b>Discount</b>
                </td>
                <td>
                    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessageCustomer" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
                </td>
            </tr>
        </table>
         <asp:Button ID="btnSaveCustomer" runat="server" Text="Save" OnClick="btnSaveCustomer_Click" />
         <asp:Button ID="btnBackToHome" runat="server" Text="Back" OnClick="btnBackToHome_Click" />
    </form>
</body>
</html>
