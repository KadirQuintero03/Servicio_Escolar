using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioMaterias : Conexion
    {
        public string Asig_Materia(string Id_PR, string Id_Materia) {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Asig_Materia", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR", Id_PR);
            con.Parameters.AddWithValue("@Id_Materia", Id_Materia);

            try
            {
                BDD.conexion.Open();
                var mensaje = con.ExecuteNonQuery();
                BDD.conexion.Close();
                return "";
            }
            catch (Exception)
            {
                return "Falta asignar una materia al profesor";
            }
        }

        public Materia Busqueda(string Id_PR, string Id_Materia)
        {
            Materia Materia = new Materia();
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Buscar_Materia", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR", Id_PR);
            con.Parameters.AddWithValue("@Id_Materia", Id_Materia);

            SqlDataReader lectura = con.ExecuteReader();

            if (lectura.Read()==true)
            {
                Materia.Id_Materia = Convert.ToString(lectura[0]);
            }

            BDD.conexion.Close();
            return Materia;
        }
        public string Bus_Nombre(String N_Materia)
        {
            Materia Materia = new Materia();
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Buscar_NoMateria", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Nombre_Materia", N_Materia);

            SqlDataReader lectura = con.ExecuteReader();

            if (lectura.Read()==true)
            {
                Materia.Id_Materia = Convert.ToString(lectura[0]);
            }

            BDD.conexion.Close();
            return Materia.Id_Materia;
        }

        public void Eliminar_AP(string Id_PR)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Eliminar_AP", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR", Id_PR);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
        }
    }
}
