<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnCarWebForm.aspx.cs" Inherits="CarRentalWebClient.ReturnCarWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formReturnCar" runat="server">
        <div>
            <h2>Returning Car</h2>
        </div>
        <div>
             <asp:Label ID="bookingIdReturnedLabel" runat="server" ForeColor="Black" Font-Bold="true"> Booking Id</asp:Label>
             <asp:TextBox ID="txtReturningCar" runat="server"></asp:TextBox><br />
                <asp:Button ID="searchingBookingBtn" runat="server" Text="Search" OnClick="searchingBookingBtn_Click" />
        </div>
        <div>
            <asp:Label ID="startTimeLabel" runat="server" ForeColor="Black" Font-Bold="true"> Start Time</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="startTimeTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="returnTimeLabel" runat="server" ForeColor="Black" Font-Bold="true"> Return Time</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="returnTimeTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="customerFirstNameLabel" runat="server" ForeColor="Black" Font-Bold="true"> First Name</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="customerFirstNameTxt" runat="server" ></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="customerLastNameLabel" runat="server" ForeColor="Black" Font-Bold="true"> Last Name</asp:Label>
        </div>
         <div>
            <asp:TextBox ID="customerLastNameTxt" runat="server" ></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="customerEmailLabel" runat="server" ForeColor="Black" Font-Bold="true"> Email</asp:Label>
        </div>
         <div>
            <asp:TextBox ID="customerEmailTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="carRegisterNumberLabel" runat="server" ForeColor="Black" Font-Bold="true"> Car Register Number</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="carRegisterNumberTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="carBrandLabel" runat="server" ForeColor="Black" Font-Bold="true"> Car Brand</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="carBrandTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="carModelLabel" runat="server" ForeColor="Black" Font-Bold="true"> Car Model</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="carModelTxt" runat="server" ></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="carYearLabel" runat="server" ForeColor="Black" Font-Bold="true"> Year</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="carYearTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="carDayRentLabel" runat="server" ForeColor="Black" Font-Bold="true"> Day Rent</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="carDayRentTxt" runat="server" ></asp:TextBox>
        </div>
       
        <div>
             <asp:Button ID="btnReturningCar" runat="server" Text="Return Car" OnClick="btnReturningCar_Click" />
        </div>
        <div>
             <asp:Label ID="lblMessageReturning" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
        </div>
        </form>
</body>
</html>
