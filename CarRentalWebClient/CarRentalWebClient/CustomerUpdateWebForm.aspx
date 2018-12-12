<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerUpdateWebForm.aspx.cs" Inherits="CarRentalWebClient.CustomerUpdateWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="updateCustomerInfo" runat="server">Update Customer Information</asp:Label>
        </div>
        <div>
            <asp:Label ID="customerIdLable" runat="server">Customer Id</asp:Label>
            <asp:TextBox ID="customerIdTxt" runat="server"></asp:TextBox>
            <asp:Button ID="customerIdBtn" runat="server" Text="Search by HTTP" OnClick="customerSearchByHttpBtn_Click" />
            <asp:Button ID="customerIdBtn1" runat="server" Text="Search by TCP" OnClick="customerSearchByTCPBtn_Click" />
        </div>
         <table style="font-family: Arial; border: 1px solid black;">
           <%--  <tr>
                <td>
                    <b>Customer ID</b>
                </td>
                <td>
                    <asp:TextBox ID="txtcustomerId" runat="server"></asp:TextBox>
                </td>
            </tr>--%>
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
                    <asp:Label ID="lblMessageUpdateCustomer" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
                </td>
            </tr>
        </table>
        
        <asp:Button ID="btnUpdateCustomer" runat="server" Text="Update" OnClick="btnUpdateCustomer_Click" />
         <asp:Button ID="btnBackToHome" runat="server" Text="Back" OnClick="btnBackToHome_Click" />
    </form>
</body>
</html>
