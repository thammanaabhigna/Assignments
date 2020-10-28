<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dropdownpractice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>select the city from the dropdown</p>
        <div>
            <asp:DropDownList ID="dropdownlsit1" runat="server" Height="75px" Width="348px">
                <asp:ListItem Value="">please select city</asp:ListItem>
                <asp:ListItem>Banglore</asp:ListItem>
                <asp:ListItem>Hyderabad</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>pune</asp:ListItem>
                
                
            </asp:DropDownList> <br /> <br />
            <br /> <br />
            <br /> <br />
            <asp:Button ID="button1" runat="server" Text="submit" Height="23px" Width="115px" OnClick="button1_Click" />

        </div>
        <p>
            <asp:Label ID="label1" runat="server"></asp:Label>
        </p>
        <asp:DropDownList ID="sachin" runat="server">
            <asp:ListItem Value="select from below">a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
            <asp:ListItem>f</asp:ListItem>
            
            
        </asp:DropDownList>
        <br />
            <br />

        <asp:TextBox ID="Email" runat="server" Width="247px">this ia an example</asp:TextBox>
    </form>
</body>
</html>
