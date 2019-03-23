<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtualizarCliente.aspx.cs" Inherits="CrudWebForm.AtualizarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <div class="container-fluid center-block" style="max-width:50%; margin-top:10%">
        <h1 class="text-center">Atualizar Clientes</h1>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="exampleInputEmail1">Código</label>
                <asp:TextBox class="invisible" ID="txtId" runat="server"></asp:TextBox>                    
                <asp:TextBox class="form-control" ID="txtCodigo" runat="server"></asp:TextBox>                    
                <br />                
                <asp:Button class="btn btn-primary" ID="btnGetDetalhes" runat="server" Text="Obter Detalhes" OnClick="btnGetDetalhes_Click" />
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Nome</label>                
                <asp:TextBox class="form-control" ID="txtNome" runat="server" placeholder="Nome"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Data Cadastro</label>                
                <asp:TextBox class="form-control" ID="txtData" runat="server" disable></asp:TextBox>
            </div>
            <br />
            <asp:Label ID="lblMsg" runat="server" EnableViewState="False"></asp:Label>
            <br />            
            <asp:Button class="btn btn-primary" ID="btnAtualiza" runat="server" Text="Atualizar Contato" Enabled="false" OnClick="btnAtualizar_Click" /><br />
        </form>
    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
