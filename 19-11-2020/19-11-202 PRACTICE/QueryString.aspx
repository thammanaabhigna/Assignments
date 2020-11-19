<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStrings.aspx.cs" Inherits="WebQueryStrings.QueryState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 13px;
        }
        .auto-style2 {
            width: 92%;
            height: 173px;
        }
        .auto-style3 {
            width: 17px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="60px" Height="29px" />
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style1" Text="Reset" OnClick="Button2_Click" Width="63px" Height="30px" />
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
               <td>
                    <asp:Label ID="lblstatus" runat="server" ></asp:Label>
                </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
