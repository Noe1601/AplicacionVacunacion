using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class VacunadosMarca : System.Web.UI.Page
    {
        Datos data = new Datos();
        string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Llenar();
            }
        }

        public void Llenar()
        {
            DropDownList1.DataSource = data.CompletarVacuna();
            DropDownList1.DataTextField = "MARCA";
            DropDownList1.DataValueField = "MARCA";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                nombre = DropDownList1.SelectedItem.Value;
                GridView1.DataSource = data.BuscarPorVacuna(nombre);
                GridView1.DataBind();

            }
            catch (Exception ex)
            {

            }
        }
    }
}