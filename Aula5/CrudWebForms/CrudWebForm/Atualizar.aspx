<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atualizar.aspx.cs" Inherits="CrudWebForm.Atualizar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form3" runat="server">
   <h2>
        Atualizar Contato</h2>
        <table>
             <tr>
                <td>Codigo</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                    <asp:Button ID="btnGetDetalhes" runat="server" Text="Obter Detalhes" OnClick="btnGetDetalhes_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Nome</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Idade</td>
                <td>
                    <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar Contato" Enabled="false" OnClick="btnAtualizar_Click" /><br />
        <br />
        <asp:Label ID="lblmsg" runat="server" EnableViewState="False"></asp:Label><br />
        <p />
        <a href="Default.aspx">Retornar ao Menu</a>
    </form>
</body>
</html>

