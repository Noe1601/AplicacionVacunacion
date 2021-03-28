using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tarea7y8
{
    public class Datos
    {
        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=TAREA7Y8;Integrated Security=True");
        SqlCommand comando;

        public void GuardarPaciente(string cedula,string nombre,string telefono,string fecha,string vacuna,string provincia )
        {
            conexion.Open();
            string consulta = $"INSERT INTO PERSONA VALUES('{cedula}','{nombre}','{telefono}','{fecha}','{vacuna}','{provincia}')";
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void GuardarVacuna(string nombre)
        {
            conexion.Open();
            string consulta = $"INSERT INTO VACUNA VALUES('{nombre}')";
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void GuardarProvincia(string nombre)
        {
            conexion.Open();
            string consulta = $"INSERT INTO PROVINCIA VALUES('{nombre}')";
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarVacunado(string cedula)
        {
            conexion.Open();
            string consulta = $"DELETE FROM PERSONA WHERE CEDULA = '{cedula}'";
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataSet CompletarVacuna()
        {
            conexion.Open();
            string consulta = "SELECT * FROM VACUNA";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet CompletarProvincia()
        {
            conexion.Open();
            string consulta = "SELECT * FROM PROVINCIA";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataTable CargarInfo()
        {
            conexion.Open();
            string consulta = "SELECT * FROM PERSONA";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable BuscarPorNombre( string nombre)
        {
            conexion.Open();
            string consulta = $"SELECT * FROM PERSONA WHERE NOMBRE = '{nombre}'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable BuscarPorProvincia(string nombre)
        {
            conexion.Open();
            string consulta = $"SELECT * FROM PERSONA WHERE PROVINCIA = '{nombre}'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable BuscarPorVacuna(string nombre)
        {
            conexion.Open();
            string consulta = $"SELECT * FROM PERSONA WHERE VACUNA = '{nombre}'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

    }
}