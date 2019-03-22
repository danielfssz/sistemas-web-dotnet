<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="CrudWebForm.Listar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form4" runat="server">
        <h2>Lista de Contatos</h2>
        <asp:GridView ID="GridView1" runat="server" Width="100%" OnRowCommand="GridView1_RowCommand">
            <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <br />
        <a href="Default.aspx">Retornar ao Menu</a>
    </form>
</body>
</html>