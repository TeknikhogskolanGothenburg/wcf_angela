<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerWebForm.aspx.cs" Inherits="CarRentalWebClient.CustomerWebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer" OnClick="btnAddCustomer_Click" />
        <asp:Button ID ="btnUpdateCustomer" runat="server" Text="Update Customer" OnClick="btnUpdateCustomer_Click" />
        <asp:Button ID ="btnRemoveCustomer" runat="server" Text="Remove Customer" OnClick="btnRemoveCustomer_Click" />
        <asp:Button ID ="btnViewAllCustomers" runat="server" Text="View All Customers" OnClick="btnViewAllCustomers_Click" />
    </form>
</body>
</html>
