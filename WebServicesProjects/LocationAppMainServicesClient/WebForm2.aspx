﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LocationAppMainServicesClient.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="font-family: Arial">
        <tr>
            <td>
                <b>First Number</b>
            </td>
            <td>
                <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Second Number</b>
            </td>
            <td>
                <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Result</b>
            </td>
            <td>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAdd" runat="server" Text="Add" 
                OnClick="btnAdd_Click" />
                
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvCalculations" runat="server">
                </asp:GridView>
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
