using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositoryCourses : Conexion
    {
        //Busca por Nombre del curso en la tabla de curso y retorna el id del curso
        public string GetById(string Nombre_Curso)
        {
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Buscar_Curso", BDD.conexion);

            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Nombre_Curso", Nombre_Curso);

            SqlDataReader lectura = con.ExecuteReader();
            while (lectura.Read()==true)
            {
                var Id = lectura[0];
                return Id.ToString();
            }
            return "No encontrado";
            BDD.conexion.Close();
        }
    }
}
