<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrationform.aspx.cs" Inherits="studentadmissions.Registrationform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 218px;
        }
        .auto-style3 {
            width: 258px;
        }
        .auto-style4 {
            width: 218px;
            height: 26px;
        }
        .auto-style5 {
            width: 258px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 1077px;
            height: 208px;
        }
        .auto-style8 {
            margin-left: 310px;
        }
        .auto-style9 {
            margin-top: 174px;
        }
        .auto-style10 {
            width: 218px;
            height: 203px;
        }
        .auto-style11 {
            width: 258px;
            height: 203px;
        }
        .auto-style12 {
            height: 203px;
        }
    </style>
</head>
<body style="width: 1078px">
    <form id="form1" runat="server">
        <div class="auto-style7">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">FirstName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="190px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*FirstNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">LastName</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*LastNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Father&#39;sName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" Width="190px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Father'sNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mother&#39;sName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" Width="192px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Mother'sNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td class="auto-style3">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="male" />
&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="female" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                    
                    </td>
                    <td class="auto-style2">&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Aggregate</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server" Width="190px"></asp:TextBox>
&nbsp;&nbsp;

                        
                    </td>
                    <td>
                   <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="*should be &gt;65%" ForeColor="Red" MaximumValue="100" MinimumValue="66" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Courses</td>
                    <td class="auto-style11">
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Cources" Text="ECE" OnCheckedChanged="RadioButton3_CheckedChanged" />
&nbsp;<br />
                        &nbsp;
                        <asp:CheckBox ID="CheckBox7" runat="server" Text="MPMC" />
&nbsp;
                        <asp:CheckBox ID="CheckBox8" runat="server" Text="EDC"  />
&nbsp;<asp:CheckBox ID="CheckBox9" runat="server" Text="STLD" />
&nbsp;<br />
                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Cources" Text="CSE" OnCheckedChanged="RadioButton5_CheckedChanged" />             
                        <br />
                        <asp:CheckBox ID="CheckBox10" runat="server" Text="JAVA" />
&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox11" runat="server" Text="OS" />
                        
                &nbsp;&nbsp;&nbsp;
                        
                &nbsp;<asp:CheckBox ID="CheckBox12" runat="server" Text="DBMS" />
                        
                
                    <td>
&nbsp;&nbsp;
                        &nbsp;&nbsp;
                                                
                        <br />
                        
                    </td>
                    <td class="auto-style12">
                        
                    </td>
                    
                        &nbsp;
            
            </table>
        </div>
        <p>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="."></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="."></asp:Label>

            <br />
            <br />

            <asp:Button ID="Button1" runat="server" CssClass="auto-style8" OnClick="Button3_Click1" Text="submit" Width="126px" BackColor="Yellow" ForeColor="Blue" Height="29px" />

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="*required" CssClass="auto-style9" />

    </form>
</body>
</html>
