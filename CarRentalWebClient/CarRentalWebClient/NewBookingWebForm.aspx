<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewBookingWebForm.aspx.cs" Inherits="CarRentalWebClient.BookingWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formNewBooking" runat="server">
        <div>
             <asp:Label ID="bookingIdLable" runat="server" ForeColor="Black" Font-Bold="true"> Booking Id</asp:Label>
             <asp:TextBox ID="txtBooking" runat="server"></asp:TextBox><br />

        </div>
        <div>
            <asp:Label ID="CustomerLable" runat="server" ForeColor="Black" Font-Bold="true"> Select a customer</asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="customerList" runat="server" ></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="newCustomerBtn" runat="server" Text="New Customer" OnClick="newCustomerBtn_Click" />
        </div>
        <div id="addCustomer" style="display:none">
            <asp:Label ID="customerIDLable" runat="server" ForeColor="Black" Font-Bold="true"> Customer ID</asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox><br />
            <asp:Label ID="customerFirstName" runat="server" ForeColor="Black" Font-Bold="true"> First Name</asp:Label>
            <asp:TextBox ID="txtCustomerFirstName" runat="server"></asp:TextBox><br />
            <asp:Label ID="customerLastName" runat="server" ForeColor="Black" Font-Bold="true"> Last Name</asp:Label>
            <asp:TextBox ID="txtCustomerLastName" runat="server"></asp:TextBox><br />
            <asp:Label ID="mobileLabel" runat="server" ForeColor="Black" Font-Bold="true"> Mobile</asp:Label>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox><br />
            <asp:Label ID="emailLabel" runat="server" ForeColor="Black" Font-Bold="true"> Email</asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        </div>
         <div style="font-family: Arial">
            <asp:Label ID="Car" runat="server" ForeColor="Black" Font-Bold="true"> Choose one car</asp:Label>
            <asp:DropDownList ID="carList" runat="server" ></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="startDateLabel" runat="server" ForeColor="Black" Font-Bold="true"> Start Date</asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/Image/calendar.jpg" OnClick="ImageButton1_Click" style="margin-top: 58px" Width="30px" />
            <asp:Calendar ID="startCalenda" runat="server" OnSelectionChanged="startCalenda_SelectionChanged"> </asp:Calendar> 
         </div>
        <div>
            <asp:Label ID="endDateLabel" runat="server" ForeColor="Black" Font-Bold="true"> Return Date</asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" ImageUrl="~/Image/calendar.jpg" OnClick="ImageButton2_Click" Width="30px" />
            <asp:Calendar ID="endCalenda" runat="server" OnSelectionChanged="endCalenda_SelectionChanged"> </asp:Calendar> 
        </div>
            <asp:Button ID="bookBtn" runat="server" Text ="Book" OnClick="bookBtn_Click"/>
        <div>
             <asp:Label ID="lblMessageBooking" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
        </div>
    </form>
   

</body>

</html>
