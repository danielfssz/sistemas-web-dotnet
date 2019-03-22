<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Incluir.aspx.cs" Inherits="CrudWebForm.Incluir" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>
       Incluir novo Contato</h2>
        <table>
            <tr>
                <td>
                    Nome</td>
                <td><asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
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
        <asp:Button ID="btnIncluir" runat="server" Text="Incluir Contato" OnClick="btnIncluir_Click" /><br />
        <br />
        <asp:Label ID="lblMsg" runat="server" EnableViewState="False"></asp:Label><br />
        <p />
        <a href="Default.aspx">Retorna ao Menu</a>
    </form>
</body>
</html>
