<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="datatableAss.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ths is my datalist assignment</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>The data present in list</p>
        <div>
            <asp:DataList ID="datalist1" runat="server">
                <ItemTemplate>
                    <asp:Table ID="table1" runat="server" CellPadding="2" CellSpacing="0"
                        Border="1" Style="width:250px;height:100px;background-color:darkslategrey ">

                    </asp:Table>
                    <tr>
                        <td>
                            <strong>Firstname</strong><span class="fn"><%# Eval("Firstname") %></span><br /><br />
                             <strong>Lastname</strong><span class="ln"><%# Eval("Lastname") %></span><br /><br />
                             <strong>Designation</strong><span class="dg"><%# Eval("Designation") %></span><br /><br />
                             <strong>Location</strong><span class="loc"><%# Eval("Location") %></span><br /><br />
                             <strong>Country</strong><span class="ctry"><%# Eval("Country") %></span><br /><br />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
