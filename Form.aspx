<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="ProgramacionIIExamenII.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formularios UH - Examen 2</title>
</head>
<body style="background-color: aliceblue">
    <form id="form1" runat="server">
        <div hidden="hidden">
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
            <asp:Label ID="AlertaEdad" runat="server" Font-Names="Calibri Light" Visible="False">Vacio</asp:Label>
        </div>
            <br />
        <div id="contenido" visible="true" runat="server" >
            <asp:Label ID="LabelNombre" runat="server" Text="Ingrese su Nombre" Font-Names="Calibri Light" Visible="False"></asp:Label>
             <br />
                <asp:TextBox ID="TextoNombre" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light" Visible="False"></asp:TextBox>
                 <br />
            <asp:Label ID="LabelApellido" runat="server" Text="Ingrese su Apellido" Font-Names="Calibri Light" Visible="False"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoApellido" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light" Visible="False"></asp:TextBox>
                 <br />
            <asp:Label ID="LabelNacimiento" runat="server" Text="Ingrse su Fecha de Nacimiento (En formato AAAA-MM-DD)" Font-Names="Calibri Light" Visible="False"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoNacimiento" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light" Visible="False"></asp:TextBox>
                 <br />
            <asp:Label ID="LabelCorreo" runat="server" Text="Ingrese su Correo Electronico" Font-Names="Calibri Light" Visible="False"></asp:Label>
                 <br />
            <asp:TextBox ID="TextoCorreo" runat="server" OnTextChanged="TextBox1_TextChanged" class="mandatory" Font-Names="Calibri Light" Visible="False"></asp:TextBox>
                 <br />
            <asp:Label ID="LabelCarro" runat="server" Text="Cuenta con carro propio?" Font-Names="Calibri Light" Visible="False"></asp:Label>
                 <br />
            <asp:DropDownList ID="TextoCarro" runat="server" Visible="False">
                <asp:ListItem>Si</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>
                <br />
            <asp:Button ID="IngresarDatos" runat="server" Text="Ingresar Datos" OnClick="IngresarDatos_Click" Visible="False" />
                <br />

        </div>
    </form>
</body>
</html>
