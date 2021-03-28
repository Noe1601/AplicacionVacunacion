using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class RegistrarVacunados : System.Web.UI.Page
    {
        Datos data = new Datos();

        string cedula;
        string nombre;
        string telefono;
        string fecha;
        string vacuna;
        string provincia;

        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack)
            {
                Llenar();
            }
        }

        public void Llenar()
        {
           // Provincia
           DropDownList2.DataSource = data.CompletarProvincia();
           DropDownList2.DataTextField = "NOMBRE";
           DropDownList2.DataValueField = "NOMBRE";
           DropDownList2.DataBind();
           DropDownList2.Items.Insert(0, new ListItem("[Seleccionar]"));

           DropDownList1.DataSource = data.CompletarVacuna();
           DropDownList1.DataTextField = "MARCA";
           DropDownList1.DataValueField = "MARCA";
           DropDownList1.DataBind();
           DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]"));
        }

        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            DropDownList1.Text = "";
            DropDownList2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" &&
               TextBox4.Text != "" && DropDownList1.Text != "" && DropDownList2.Text != "")
                {
                    cedula = TextBox1.Text;
                    nombre = TextBox2.Text;
                    telefono = TextBox3.Text;
                    fecha = TextBox4.Text;
                    vacuna = DropDownList1.SelectedItem.Value;
                    provincia = DropDownList2.SelectedItem.Value;
                    data.GuardarPaciente(cedula, nombre, telefono, fecha, vacuna, provincia);
                    Label7.Text = "Paciente registrado exitosamente";
                    Clear();
                }
                else
                {
                    Label7.Text = "Datos incorrectos, intentelo de nuevo";
                }
                
            }catch( Exception ex)
            {
               Label7.Text = "Paciente registrado exitosamente";
            }
        }

       
    }
}