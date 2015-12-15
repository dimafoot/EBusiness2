<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetEmployee.aspx.cs" Inherits="LocationAppMainWebService.SetEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        
    <script type="text/javascript" language="javascript">
        
        function GetEmployeeById() {
            var id = document.getElementById("txtId").value;
            LocationAppMainWebService.WebServicesWCF.GetEmployeeById(id, GetEmployeeByIdCallBack); 
        }

        function GetEmployeeByIdCallBack(result) {
            document.getElementById("txtName").value = result["Name"];
            document.getElementById("txtGender").value = result["Gender"];
            document.getElementById("txtDateofb").value = result["Dateofb"];
        }

    </script>

</head>
<body>
    
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebServicesWCF.asmx" />
            </Services>
        </asp:ScriptManager>
        <table>
            <tr>
                <td>Id</td>
                <td style="font-weight: 700">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    <input id="Button1" type="button" value="Get Employee" onclick="GetEmployeeById()" /></td>
            </tr>
            
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Dateofb</td>
                <td>
                    <asp:TextBox ID="txtDateofb" runat="server"></asp:TextBox>
                </td>
            </tr>

        </table>
        
        <table>
            <tr>
                <td>Number : </td>
                <td style="font-weight: 700">
                    <asp:TextBox ID="TextNumber" runat="server"></asp:TextBox>
                    <input id="ButtonNbr" type="button" value="Set Employee" /></td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvRandoms" runat="server"></asp:GridView>
                </td>
            </tr>

        </table>

    </form>
    

</body>
</html>
