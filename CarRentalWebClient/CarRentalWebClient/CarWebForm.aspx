<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarWebForm.aspx.cs" Inherits="CarRentalWebClient.CaWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAddCustomer" runat="server" Text="Add Car" OnClick="btnAddCustomer_Click" />
        <asp:Button ID ="btnRemoveCustomer" runat="server" Text="Remove Car" OnClick="btnRemoveCustomer_Click" />
        <asp:Button ID ="btnViewAllCustomers" runat="server" Text="View All Cars" OnClick="btnViewAllCustomers_Click" />

    </form>
</body>
</html>
