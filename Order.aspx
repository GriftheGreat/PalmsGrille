<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Judah.aspx.cs" Inherits="Judah" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Start Order</h1>
        First Name:
        <asp:TextBox ID="inpFName" runat="server" style="margin-top: 0px" Height="16px" Width="122px"></asp:TextBox>
        
        

        &nbsp;&nbsp;&nbsp;&nbsp; Last Name:&nbsp;&nbsp;
        <asp:TextBox ID="inpLName" runat="server" style="margin-top: 0px" Height="16px" Width="122px"></asp:TextBox>
        
        

        <br />
        <br />
        
        

        <asp:RadioButton id="inpPickup" runat="server" GroupName="inpOrderOrDelivery" text="Pickup"/>
        <asp:RadioButton id="inpDelivery" runat="server" GroupName="inpOrderOrDelivery" Text="Delivery"/>

        <br />
        <asp:DropDownList ID="inpHour" runat="server">
            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem Value="7"></asp:ListItem>
            <asp:ListItem Value="8"></asp:ListItem>
            <asp:ListItem Value="9"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="11"></asp:ListItem>
            <asp:ListItem Value="12"></asp:ListItem>
        </asp:DropDownList>
        :<asp:DropDownList ID="inpMinute" runat="server">
            <asp:ListItem Value="00"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
            <asp:ListItem Value="30"></asp:ListItem>
            <asp:ListItem Value="45"></asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:DropDownList ID="inpMeridian" runat="server">
            <asp:ListItem Selected="True" Value="AM">AM</asp:ListItem>
            <asp:ListItem Value="PM">PM</asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Button id="inpSubmit" runat="server" OnClick="S_Clicked" Text="Submit" />


        <br />
        <br />
        <p>



        <asp:TextBox ID="results" runat="server" Height="345px" Width="269px" TextMode="MultiLine"></asp:TextBox>



        </p>



    </form>
</body>
</html>
