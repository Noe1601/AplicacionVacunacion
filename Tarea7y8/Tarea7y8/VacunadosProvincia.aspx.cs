using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class VacunadosProvincia : System.Web.UI.Page
    {
        Datos data = new Datos();
        string provincia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Llenar();
            }
        }

        public void Llenar()
        {
            DropDownList1.DataSource = data.CompletarProvincia();
            DropDownList1.DataTextField = "NOMBRE";
            DropDownList1.DataValueField = "NOMBRE";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]"));
        }

        public void Clear()
        {
            DropDownList1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                provincia = DropDownList1.SelectedItem.Value;
                GridView1.DataSource = data.BuscarPorProvincia(provincia);
                GridView1.DataBind();
                Clear();
            }catch(Exception ex)
            {

            }
        }
    }
}