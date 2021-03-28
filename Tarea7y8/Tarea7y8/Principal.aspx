<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Tarea7y8.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="#">VacunApp</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link" href="RegistrarVacunados.aspx">Registrar personas</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="RegistrarVacuna.aspx">Registrar vacuna</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="ConsultaVacunados.aspx">Consultar</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="RegistrarProvincia.aspx">Registrar provincia</a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="VacunadosProvincia.aspx">por provincia</a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="VacunadosMarca.aspx">por vacuna</a>
      </li>
    </ul>
       <div class="form-inline my-2 my-lg-0">
           <asp:TextBox ID="TextBox1" runat="server" class="form-control ml-10 mr-sm-2" type="search" placeholder="Ingrese cedula" ></asp:TextBox>
           <asp:Button ID="Button1" OnClick="Borrar" class="btn btn-outline-danger my-2 my-sm-0" runat="server" Text="Eliminar" />
    </div>
  </div>
</nav>

        
    <div class="jumbotron mt-5 text-center" style="width: 90%; margin-left: 60px">
        <h1>VacunApp</h1>
        <p class="lead">Aplicacion para registro de vacunados y consulta de estos</p>
        <p><a href="#">Equipo super trabajador K &copy;</a></p>
    </div>
    </form>
</body>
</html>
