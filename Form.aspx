<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="ProgramacionIIExamenII.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formularios UH - Examen 2</title>
</head>
<body style="background-color: aliceblue">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="NFormulario" runat="server" Text="Numero De Formulario" Font-Names="Calibri Light"></asp:Label>
        </div>
          <br />
        <div id"Verificacion_Edad">
            <asp:Label ID="LabelEdad" runat="server" Text="Ingrese su Edad" Font-Names="Calibri Light"></asp:Label>
                <br />
            <asp:TextBox ID="TextoEdad" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light"></asp:TextBox>
                <br />
            <asp:Button ID="VerificarEdad" runat="server" Text="Verificar edad" BackColor="#9999FF" BorderColor="White" ForeColor="White" OnClick="VerificarEdad_Click" />
                <br />
            <asp:Label ID="AlertaEdad" runat="server" Font-Names="Calibri Light" Visible="False"></asp:Label>
        </div>
            <br />
        <div id="contenido" style="background-color: #">
            <asp:Label ID="LabelNombre" runat="server" Text="Ingrese su Nombre" Font-Names="Calibri Light"></asp:Label>
             <br />
                <asp:TextBox ID="TextoNombre" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light"></asp:TextBox>
                 <br />
            <asp:Label ID="TextoApellido" runat="server" Text="Ingrese su Apellido" Font-Names="Calibri Light"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoNacimiento" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light"></asp:TextBox>
                 <br />
            <asp:Label ID="Label6" runat="server" Text="Ingrse su Fecha de Nacimiento (En formato AAAA-MM-DD)" Font-Names="Calibri Light"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoCorreo" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light"></asp:TextBox>
                 <br />
            <asp:Label ID="Label7" runat="server" Text="Ingrese su Correo Electronico" Font-Names="Calibri Light"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoCarroPropio" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light"></asp:TextBox>
                 <br />
            <asp:Label ID="Label8" runat="server" Text="Cuenta con carro propio?" Font-Names="Calibri Light"></asp:Label>
                 <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Si</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>
                <br />
            <asp:Button ID="Button1" runat="server" Text="Verificar edad" BackColor="#9999FF" BorderColor="White" ForeColor="White" OnClick="VerificarEdad_Click" />

        </div>
    </form>
</body>
</html>
