<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BiduleServoceWebClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 113px;
        }
    </style>
</head>
<body>
<body>
    <form id="form1" runat="server">

    <div style="font-family: Arial">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Get Text" OnClick="Button1_Click" /><br/>
        <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
        <br/>
        
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        
    </div>
        
    <div>
        
         <table>
            <tr>
                <td class="auto-style1"><b>ID :</b></td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Name :</b></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Gender :</b></td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Date Ofb :</b></td>
                <td>
                    <asp:TextBox ID="txtDateofb" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1"><b>Employee Type :</b></td>
                <td>
                    <asp:DropDownList ID="ddlEmployeeType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployeeType_SelectedIndexChanged" OnTextChanged="ddlEmployeeType_TextChanged" Height="17px" Width="157px">
                        <asp:ListItem Text="Select Employee Type" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Full Time Employee" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Part Time Employee" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr ID="trAnnualSalary" runat="server" visible="false">
                <td class="auto-style1"><b>Annual Salary :</b></td>
                <td>
                    <asp:TextBox ID="txtAnnualSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr id="trHourlyPay" runat="server" visible="false">
                <td class="auto-style1"><b>Hourly Pay :</b></td>
                <td>
                    <asp:TextBox ID="txtHourlyPay" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr id="trHoursworked" runat="server" visible="false">
                <td class="auto-style1"><b>Hours worked :</b></td>
                <td>
                    <asp:TextBox ID="txtHoursworked" runat="server"></asp:TextBox>
                </td>
            </tr>

<%--        <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnGetEmployee" runat="server" Text="GetEmployee" Width="107px" OnClick="btnGetEmployee_Click" />
                </td>
            </tr>--%>

            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnGetEmployeeDB" runat="server" Text="GetEmployeeDB" Width="107px" OnClick="btnGetEmployeeDB_Click" />
                </td>
                <td>
                    <asp:Button ID="btnSaveEmployee" runat="server" Text="SaveEmployee" Width="127px" OnClick="btnSaveEmployee_Click" />
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="LblMessage" runat="server" Text="Label" Width="150"></asp:Label>
                </td>
            </tr>
        </table>

    </div>        

    </form>
</body>
</body>
</html>
