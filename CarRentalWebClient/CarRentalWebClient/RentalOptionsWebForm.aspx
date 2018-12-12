<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentalOptionsWebForm.aspx.cs" Inherits="CarRentalWebClient.RentalOptionsWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="rentalOptionsform" runat="server">
         <asp:Button ID="btnNewBooking" runat="server" Text="New Booking" OnClick="btnNewBooking_Click" />
         <asp:Button ID="btnDeleteBooking" runat="server" Text="Delete Booking" OnClick="btnDeleteBooking_Click" />
        <asp:Button ID ="btnReturn" runat="server" Text="Return Car" OnClick="btnReturn_Click" />
    </form>
</body>
</html>
