using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioNotas:Conexion
    {
        public string ADD(string Id)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Crear_Nota", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id5", Id);

            try
            {
                BDD.conexion.Open();
                var mensaje = con.ExecuteNonQuery();
                BDD.conexion.Close();
                return mensaje == 1 ? "Almacenado correctamente" : "No se pudo almacenar";
            }
            catch (Exception)
            {
                return "";
            }

        }
       public void Eliminar(string Id)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Eliminar_NES", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id", Id);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            
        }

        public string Actualizar(string Id, string Id_Materia, decimal Nota1, decimal Nota2, decimal Nota3, decimal Definitiva)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Actualizar_Nota", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id6", Id);
            con.Parameters.AddWithValue("@Id_Materia", Id_Materia);
            con.Parameters.AddWithValue("@Nota_1", Nota1);
            con.Parameters.AddWithValue("@Nota_2", Nota2);
            con.Parameters.AddWithValue("@Nota_3", Nota3);
            con.Parameters.AddWithValue("@Definitiva", Definitiva);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            return mensaje == 1 ? "Las notas se actualizaron con exito" : "Error, no se pudo actualizar";
        }
        public DataTable Consultar_Notas(string Materia, string Curso)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Listar_Notas", BDD.conexion);
            SqlDataAdapter data = new SqlDataAdapter(con);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_Materia", Materia);
            con.Parameters.AddWithValue("@Id_Curso", Curso);

            DataTable tablaES = new DataTable();
            data.Fill(tablaES);

            return tablaES;
        }
        public DataTable Filtro(String Id, string NMateria, string NCurso)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("FIltro_N", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id4", Id);
            con.Parameters.AddWithValue("@NMateria", NMateria);
            con.Parameters.AddWithValue("@NCurso", NCurso);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataTable tablaES = new DataTable();
            data.Fill(tablaES);
            return tablaES;
        }
        public List<Notas> Reporte(String id)
        {
            List<Notas> notas = new List<Notas>();
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Generar_PDF", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id7", id);

            SqlDataReader lectura = con.ExecuteReader();

            while (lectura.Read()==true)
            {
                notas.Add(new Notas(lectura.GetString(0),lectura.GetDecimal(1), lectura.GetDecimal(2), lectura.GetDecimal(3), lectura.GetDecimal(4)));
            }

            BDD.conexion.Close();
            return notas;
        }
    }
}
