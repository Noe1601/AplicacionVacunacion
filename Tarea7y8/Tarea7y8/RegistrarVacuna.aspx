<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarVacuna.aspx.cs" Inherits="Tarea7y8.RegistrarVacuna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
           <h1>Registro vacunas <small>VacunApp</small></h1>
           <a href="Principal.aspx" class="mt-2">Ir a pagina principal</a>
           <asp:Label ID="Label2" class="text-success mt-2" runat="server" Text=""></asp:Label>
           <hr />
           <div class="form-group">
               <asp:Label ID="Label1" runat="server" Text="Marca de vacuna"></asp:Label>
               <asp:TextBox ID="TextBox1" placeholder="Ingrese la marca de la vacuna" class="form-control" runat="server"></asp:TextBox>
           </div>
           <asp:Button ID="Button1" class="btn btn-primary btn-block mt-3" runat="server" Text="Guardar" OnClick="Button1_Click" />
       </div>
    </form>
</body>
</html>
