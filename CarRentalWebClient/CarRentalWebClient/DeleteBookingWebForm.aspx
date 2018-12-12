<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteBookingWebForm.aspx.cs" Inherits="CarRentalWebClient.DeleteBookingWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Delete Booking Information</h2>
        <div>
            <asp:Label ID="deleteBookingLable" runat ="server">Booking ID</asp:Label>
            <asp:TextBox ID="txtDeleteBooking" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnDeleteBooking" runat="server" Text="Delete" OnClick="btnDeleteBoooking_Click" />
            <asp:Button ID="btnBackToMain" runat="server" Text="Back" OnClick="btnBackToMain_Click" />
        </div>
        <div>
            <asp:Label ID="deleteMessage" runat ="server"></asp:Label>
        </div>
    </form>
</body>
</html>
