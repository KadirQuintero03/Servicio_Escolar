using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositoryTeacher : Conexion
    {
        public string AddPR(Teacher teacher)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("AggPR", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Tipo1", teacher.Tipo);
            con.Parameters.AddWithValue("@Id_PR", teacher.Id);
            con.Parameters.AddWithValue("@Primero_Nombre1", teacher.Primero_Nombre);
            con.Parameters.AddWithValue("@Segundo_Nombre1", teacher.Segundo_Nombre);
            con.Parameters.AddWithValue("@Primer_Apellido1", teacher.Primer_Apellido);
            con.Parameters.AddWithValue("@Segundo_Apellido1", teacher.Segundo_Apellido);
            con.Parameters.AddWithValue("@Genero1", teacher.Genero);
            con.Parameters.AddWithValue("@Correo1", teacher.Correo);
            con.Parameters.AddWithValue("@Sede1", teacher.Sede);
            con.Parameters.AddWithValue("@Grado1", teacher.Id_Curso);

            try
            {
                BDD.conexion.Open();
                var mensaje = con.ExecuteNonQuery();
                BDD.conexion.Close();
                return mensaje == 1 ? "Almacenado correctamente" : "No se pudo almacenar";
            }
            catch (Exception)
            {
                return "Error, No se pudo almacenar el profesor";
            }
        }

        public string DeletePR(string Id_PR)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("EliminarPR", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR2", Id_PR);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            return mensaje == 1 ? "Eliminado correctamente" : "No se pudo eliminar";
        }

        public string EditPR(Teacher teacher)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("ModificarPR", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR3", teacher.Id);
            con.Parameters.AddWithValue("@Tipo1", teacher.Tipo);          
            con.Parameters.AddWithValue("@Primero_Nombre1", teacher.Primero_Nombre);
            con.Parameters.AddWithValue("@Segundo_Nombre1", teacher.Segundo_Nombre);
            con.Parameters.AddWithValue("@Primer_Apellido1", teacher.Primer_Apellido);
            con.Parameters.AddWithValue("@Segundo_Apellido1", teacher.Segundo_Apellido);
            con.Parameters.AddWithValue("@Genero1", teacher.Genero);
            con.Parameters.AddWithValue("@Correo1", teacher.Correo);
            con.Parameters.AddWithValue("@Sede1", teacher.Sede);
            con.Parameters.AddWithValue("@Grado1", teacher.Id_Curso);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            return mensaje == 1 ? "Modificado correctamente" : "No se pudo modificar";
        }

        public Teacher Busqueda(string Ide)
        {
            Teacher Teacher = new Teacher();
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Buscar_Id_PR", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id_PR4", Ide);

            SqlDataReader lectura = con.ExecuteReader();

            if (lectura.Read()==true)
            {
                Teacher.Tipo = Convert.ToString(lectura[0]);
                Teacher.Id = Convert.ToString(lectura[1]);
                Teacher.Primero_Nombre = Convert.ToString(lectura[2]);
                Teacher.Segundo_Nombre = Convert.ToString(lectura[3]);
                Teacher.Primer_Apellido = Convert.ToString(lectura[4]);
                Teacher.Segundo_Apellido = Convert.ToString(lectura[5]);
                Teacher.Genero = Convert.ToString(lectura[6]);
                Teacher.Correo = Convert.ToString(lectura[7]);
                Teacher.Sede = Convert.ToString(lectura[8]);
                Teacher.Curso = Convert.ToString(lectura[9]);
                Teacher.Materia = Convert.ToString(lectura[10]);
            }
            
            BDD.conexion.Close();
            return Teacher;
          
        }

        public DataTable Consultar_PR()
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Listar_PR", BDD.conexion);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataTable tablaPR = new DataTable();
            data.Fill(tablaPR);
            return tablaPR;
        }

        public DataTable Filtro(String Id)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("FIltro_PR", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id4", Id);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataTable tablaES = new DataTable();
            data.Fill(tablaES);
            return tablaES;
        }
    }
}