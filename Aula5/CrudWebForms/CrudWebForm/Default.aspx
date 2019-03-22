<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrudWebForm.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 90%;
        }
        .style2
        {
            font-family: "Trebuchet MS";
            color: #3333FF;
        }
        .style3
        {
            height: 27px;
            text-align: center;
        }
        .style4
        {
            height: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    <strong>CRUD COM ADO.NET</strong></td>
            </tr>
            <tr>
                <td bgcolor="#33CCFF">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Incluir.aspx" 
                        style="font-family: 'Trebuchet MS'">1 - Incluir novo Contato </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Atualizar.aspx" 
                        style="font-family: 'Trebuchet MS'">2- Atualizar Contato</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Deletar.aspx" 
                        style="font-family: 'Trebuchet MS'">3- Deletar Contato</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Listar.aspx" 
                        style="font-family: 'Trebuchet MS'">4- Listar Contatos</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td bgcolor="#33CCFF" class="style4">
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
