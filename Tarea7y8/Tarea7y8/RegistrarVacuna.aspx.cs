using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class RegistrarVacuna : System.Web.UI.Page
    {
        Datos data = new Datos();
        string nombreVacuna;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if( TextBox1.Text != "")
                {
                    nombreVacuna = TextBox1.Text;
                    data.GuardarVacuna(nombreVacuna);
                    Label2.Text = "Vacuna registrada exitosamente!";
                    Clear();
                }
                else
                {
                    Label2.Text = "Datos incorrectos, intentelo de nuevo";
                
                } 
            }catch( Exception ex)
            {
                Label2.Text = ex.Message;
            }
           
        }
    }
}