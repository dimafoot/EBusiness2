<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebServicesProjects.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" language="javascript">
            function GetRandomList() {
                WebServicesProjects.WebServices.GetCalculationsList(GetRandomCallBack);
            }

            function GetRandomCallBack(result) {
                document.getElementById("txtName").value = result["Name"];
                //document.getElementById("txtGender").value = result["Gender"];
                //document.getElementById("txtDateofb").value = result["Dateofb"];
            }

     </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebServices.asmx" />
            </Services>
    </asp:ScriptManager>
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
                
                <input id="Button1" type="button" value="GetList" onclick="GetRandomList()" />
            </td>
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
