<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ProgramacionIIExamenII.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

         
            <asp:Label ID="Label1" runat="server" Text="Encuestas Totales"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Personas Con carro"></asp:Label>
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Personas Sin Carro"></asp:Label>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <br />         

        </div>
    </form>
</body>
</html>
