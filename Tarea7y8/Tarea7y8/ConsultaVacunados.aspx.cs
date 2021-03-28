using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class ConsultaVacunados : System.Web.UI.Page
    {
        Datos data = new Datos();
        string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = data.CargarInfo();
            GridView1.DataBind();
        }

        public void Clear()
        {
            TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = TextBox1.Text;
                GridView1.DataSource = data.BuscarPorNombre(nombre);
                GridView1.DataBind();
                Clear();

            }catch( Exception ex)
            {

            }
        }
    }
}