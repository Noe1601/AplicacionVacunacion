<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarVacunados.aspx.cs" Inherits="Tarea7y8.RegistrarVacunados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">

                <h1>Registro pacientes <small>VacunApp</small></h1>
                 <a href="Principal.aspx" class="mt-2">Ir a pagina principal</a>
                <asp:Label ID="Label7" class="text-success mt-2" runat="server" Text=""></asp:Label>
                <hr />

               <div class="form-group">
               <asp:Label ID="Label1" runat="server" Text="Cedula"></asp:Label>
               <asp:TextBox ID="TextBox1" placeholder="Ingrese su cedula" class="form-control" runat="server"></asp:TextBox>
               </div>

                 <div class="form-group">
               <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
               <asp:TextBox ID="TextBox2" placeholder="Ingrese su nombre completo" class="form-control" runat="server"></asp:TextBox>
               </div>

                 <div class="form-group">
               <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
               <asp:TextBox ID="TextBox3" placeholder="Ingrese su numero telefonico" class="form-control" runat="server"></asp:TextBox>
               </div>

                 <div class="form-group">
               <asp:Label ID="Label4" runat="server" Text="Fecha de nacimiento"></asp:Label>
               <asp:TextBox ID="TextBox4" placeholder="Ingrese su fecha de nacimiento" class="form-control" runat="server"></asp:TextBox>
               </div>

                 <div class="form-group">
               <asp:Label ID="Label5" runat="server" Text="Vacuna"></asp:Label>
                     <asp:DropDownList ID="DropDownList1" DataValueField="MARCA"  class="form-control" runat="server"></asp:DropDownList>
               </div>

                  <div class="form-group">
               <asp:Label ID="Label6" runat="server" Text="Provincia"></asp:Label>
                     <asp:DropDownList ID="DropDownList2" DataValueField="NOMBRE" class="form-control" runat="server"></asp:DropDownList>
               </div>

                <asp:Button ID="Button1" class="btn btn-primary btn-block mt-3 mb-3" runat="server" Text="Guardar" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
