using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class Principal : System.Web.UI.Page
    {
        Datos data = new Datos();
        string cedula;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            TextBox1.Text = "";
        }

        public void Borrar(object sender, EventArgs e)
        {
            try
            {
                cedula = TextBox1.Text;
                data.EliminarVacunado(cedula);
                Clear();
            }
            catch (Exception)
            {

            }
        }
    }
}