<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="withcheckboxes.aspx.cs" Inherits="cookiepractice.withcheckboxes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="select brand preferences"></asp:Label> 
            <br />
            <br />
            <asp:CheckBox ID="iphone" runat="server" Text="iphone" />
            <br />

            <asp:CheckBox ID="sam" runat="server" Text="sam" />
             <br />
            <asp:CheckBox ID="leno" runat="server" Text="leno" />
             <br />
            <asp:CheckBox ID="redmi" runat="server" Text="redmi" />
             <br />
            <asp:CheckBox ID="realmi" runat="server" Text="realmi" />
            <br />
            <asp:CheckBox ID="nokia" runat="server" Text="nokia" />
             <br />
            <asp:CheckBox ID="oppo" runat="server" Text="oppo" />

             <br />
            <asp:CheckBox ID="vivo" runat="server" Text="vivo" />
            <br />
            <asp:CheckBox ID="oneplus" runat="server" Text="oneplux" />
            <br />
            <asp:CheckBox ID="pixel" runat="server" Text="pixel" />
            <br />
            <asp:Button ID="button1" runat="server" Text="checkon" OnClick="button1_Click" />
             <br />

            <p>
                <asp:Label ID="label2" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
