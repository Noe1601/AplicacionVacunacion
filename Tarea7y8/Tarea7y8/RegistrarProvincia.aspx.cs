﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea7y8
{
    public partial class RegistrarProvincia : System.Web.UI.Page
    {

        Datos data = new Datos();
        string nombreProvincia;
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
                    nombreProvincia = TextBox1.Text;
                    data.GuardarProvincia(nombreProvincia);
                    Label7.Text = "Provincia registrada exitosamente!";
                    Clear();
                }
                else
                {
                    Label7.Text = "Datos incorrectos, intentelo de nuevo";
                }
               

            }catch( Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }
    }
}