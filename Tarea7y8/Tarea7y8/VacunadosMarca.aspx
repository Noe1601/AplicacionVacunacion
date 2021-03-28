<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VacunadosMarca.aspx.cs" Inherits="Tarea7y8.VacunadosMarca" %>

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
            <h1>Listado de vacunados por marca <small>VacunApp</small></h1>
            <a href="Principal.aspx">Ir a pagina principal</a>
            <hr />

                 <div class="form-group">
               
                     <asp:DropDownList ID="DropDownList1" DataValueField="NOMBRE"  class="form-control" runat="server"></asp:DropDownList>
               </div>

            <asp:Button ID="Button1" class="btn btn-primary btn-block mt-3 mb-3" runat="server" Text="Buscar" OnClick="Button1_Click" />

            <asp:GridView ID="GridView1" class="table table-bordered mt-3" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
