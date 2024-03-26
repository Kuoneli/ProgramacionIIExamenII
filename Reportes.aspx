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
            <br />
            <asp:Label ID="Label2" runat="server" Text="Personas Con carro"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Personas Sin Carro"></asp:Label>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="nEncuesta" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="nParticipante" HeaderText="nParticipante" SortExpression="nParticipante" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="fNacimiento" HeaderText="fNacimiento" SortExpression="fNacimiento" />
                    <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="CarroPropio" HeaderText="CarroPropio" SortExpression="CarroPropio" />
                    <asp:BoundField DataField="nEncuesta" HeaderText="nEncuesta" InsertVisible="False" ReadOnly="True" SortExpression="nEncuesta" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EncuestaConnectionString2 %>" ProviderName="<%$ ConnectionStrings:EncuestaConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [Encuestas] WHERE ([CarroPropio] = @CarroPropio)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="No" Name="CarroPropio" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />         

        </div>
    </form>
</body>
</html>
