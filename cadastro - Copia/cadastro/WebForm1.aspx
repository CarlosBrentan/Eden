<!-- Esse primeiro comando vai referenciar a pagina HTML ao nosso script;
     "Page language="C#" -> define a linguagem de programação que vai ser utilizada;
     "AutoEventWireup" -> pesquisar conteudo;
     "CodeFile" -> define o nome do arquivo que contem o codigo C# da pagina;
     "Inherits" -> define o nome da classe usada pela pagina;
    
    --> 


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="cadastro.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  <!-- atributo "runat="server"" utilizado para o asp.net reconhecer como um elemento de controle possibilitando a programação--> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <p>Digite seu nome</p>
        <p>
            <asp:TextBox ID="txtNome" runat="server" ></asp:TextBox>  <!-- caixa de texto, como vamos utilizar isso na programação guardando o valor que for inserido então precisados usar o "asp:" antes de introduzir a TextBox e depois adicionamos o atributo runat="server", para que o programa entenda que aquele campo pode receber um comando do C# -->
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_click"/>  <!-- o "OnClick" define o que vai ser feito quando o botão for pressionado, estamos definindo como nome "btnEnviar_click", depois vamos criar uma void com esse mesmo nome no arquivo .aspx.cs para programar a utilização do botão -->
       </p>
        
        
         <p><asp:Label ID="saida" runat="server"></asp:Label></p> <!-- defini um campo de texto que vai receber uma mensagem quando o botão for pressionado, vamos definir isso na programação do botão no arquivo .asp.cs -->
    </form>
</body>
</html>
