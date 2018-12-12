<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeWebForm.aspx.cs" Inherits="CarRentalWebClient.HomeWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
    ul{
        list-style-type:none;
        margin:0;
        padding:0;
        overflow:hidden;
        background-color:#333;
    }

    li{
        float:left;
    }

    li a{
        display:flex;
        color:white;
        text-align:center;
        padding:14px 16px;
        text-decoration:none;
    }

    li a:hover{
        background-color:yellow;
        color:black;
    }
    h1{
        margin:150px;
    }

</style>
</head>

<body>
    <form id="form1" runat="server">
        <ul>
            <li><a class="active" href="#home">Home</a></li>
            <li><a href="CustomerWebForm.aspx">Customer</a></li>
            <li><a href="CarWebForm.aspx">Car</a></li>
            <li><a href="BookingWebForm.aspx">Booking</a></li>
        </ul>
        <h1>Welcome to Car Rental Booking System</h1>
    </form>
</body>
</html>
