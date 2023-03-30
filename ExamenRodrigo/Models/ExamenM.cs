using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenRodrigo.Models
{
    public class ExamenM
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable Obtener()
        {
            string query = "select * from cer_addendas";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);

            DataTable tabla = new DataTable();
            cmd.Fill(tabla);

            return tabla;

        }

        public void Insertar(string Nombre, string ApellidoP, string apellidom)
        {
            string query = $"Insert into cer_addendas values ('{Nombre}', '{ApellidoP}', '{apellidom}')";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Editar(string Nombre, string ApellidoP, string apellidom, int id)
        {
            string query = $"update cer_addendas set Nombre = '{Nombre}', ApellidoP = '{ApellidoP}', ApellidoM = '{apellidom}' where Id = id";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void eliminar(int id)
        {
            string query = $"delete cer_addendas where Id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable Buscar(string valor)
        {
            string query = $"select * from cer_addendas where Nombre = '{valor}' or ApellidoP= '{valor}' or ApellidoM = '{valor}";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);

            DataTable tabla = new DataTable();
            cmd.Fill(tabla);

            return tabla;
        }
    }
}