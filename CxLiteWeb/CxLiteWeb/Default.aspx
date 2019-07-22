<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>PLC Listesi</td>
                    <td>Point Listesi</td>
                </tr>
                <tr>
                    <td><asp:listbox ID="lisBox1" runat="server"></asp:listbox> </td>
                    <td><asp:listbox ID="listbox2" runat="server"></asp:listbox> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
