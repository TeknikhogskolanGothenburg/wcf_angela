<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarRemoveWebForm.aspx.cs" Inherits="CarRentalWebClient.CarRemoveWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Delete Car Information</h2>
        <div>
            <asp:Label ID="deleteCarLable" runat ="server">Car ID</asp:Label>
            <asp:TextBox ID="deleteCarTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnDeleteCar" runat="server" Text="Delete" OnClick="btnDeleteCar_Click" />
            <asp:Button ID="btnBackToMain" runat="server" Text="Back" OnClick="btnBackToMain_Click" />
        </div>
        <div>
            <asp:Label ID="deleteCarMessage" runat ="server"></asp:Label>
        </div>
         <p>
             &nbsp;</p>
    </form>
</body>
</html>
