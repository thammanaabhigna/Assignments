<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString1.aspx.cs" Inherits="QueryString_Assignment.QueryString1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 128px;
        }
    </style>
</head>
<body style="width: 386px; height: 133px">
    <form id="form1" runat="server" >
        <div>
            <p style="font-style: italic">Query String </p>
            <table class="auto-style1">
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>DateOfRegistering</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>Aggregate</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    
                    
                
                    
                        <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="182px" />
                        <br />
                         </td>
                    </tr>
                </table>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <%--<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
                        <br />
                    
                
        </div>
    </form>
</body>
</html>
