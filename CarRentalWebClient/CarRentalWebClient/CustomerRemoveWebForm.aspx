<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRemoveWebForm.aspx.cs" Inherits="CarRentalWebClient.CustomerRemoveWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Delete Customer Information</h2>
        <div>
            <asp:Label ID="deleteCustomerLable" runat ="server">Customer ID</asp:Label>
            <asp:TextBox ID="deleteCustomerTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnDeleteCustomer" runat="server" Text="Delete" OnClick="btnDeleteCustomer_Click" />
            <asp:Button ID="btnBackToMain" runat="server" Text="Back" OnClick="btnBackToMain_Click" />
        </div>
        <div>
            <asp:Label ID="deleteMessage" runat ="server"></asp:Label>
        </div>
    </form>
</body>
</html>
