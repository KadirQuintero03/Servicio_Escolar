using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace Datos
{
    public class RepositoryStudent : Conexion
    {
        
        public string ADD(Student student)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Ing_ES", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Tipo", student.Tipo);
            con.Parameters.AddWithValue("@Id", student.Id);
            con.Parameters.AddWithValue("@Primero_Nombre", student.Primero_Nombre);
            con.Parameters.AddWithValue("@Segundo_Nombre", student.Segundo_Nombre);
            con.Parameters.AddWithValue("@Primer_Apellido", student.Primer_Apellido);
            con.Parameters.AddWithValue("@Segundo_Apellido", student.Segundo_Apellido);
            con.Parameters.AddWithValue("@Genero", student.Genero);
            con.Parameters.AddWithValue("@Correo", student.Correo);
            con.Parameters.AddWithValue("@Sede", student.Sede);
            con.Parameters.AddWithValue("@Id_Curso", student.Id_Curso);

            try
            {
                BDD.conexion.Open();
                var mensaje = con.ExecuteNonQuery();
                BDD.conexion.Close();
                return mensaje == 1 ? "Almacenado correctamente" : "No se pudo almacenar";
            }
            catch (Exception)
            {
                return "Error, No se pudo almacenar al estudiante";
            }
        }

        public string Delete(string Id)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Eliminar_Estudiante", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id2", Id);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            return mensaje == 1 ? "Eliminado correctamente" : "No se pudo eliminar";
        }

        public string Edit(Student student)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Modificar_Estudiante", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id3", student.Id);
            con.Parameters.AddWithValue("@Tipo", student.Tipo);
            con.Parameters.AddWithValue("@Primero_Nombre", student.Primero_Nombre);
            con.Parameters.AddWithValue("@Segundo_Nombre", student.Segundo_Nombre);
            con.Parameters.AddWithValue("@Primer_Apellido", student.Primer_Apellido);
            con.Parameters.AddWithValue("@Segundo_Apellido", student.Segundo_Apellido);
            con.Parameters.AddWithValue("@Genero", student.Genero);
            con.Parameters.AddWithValue("@Correo", student.Correo);
            con.Parameters.AddWithValue("@Sede", student.Sede);
            con.Parameters.AddWithValue("@Id_Curso", student.Id_Curso);

            BDD.conexion.Open();
            var mensaje = con.ExecuteNonQuery();
            BDD.conexion.Close();
            return mensaje == 1 ? "Modificado correctamente" : "No se pudo modificar";
        }

        public Student Busqueda(string Ide)
        {
            Student student = new Student();
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Buscar_Id_ES", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id4", Ide);

            SqlDataReader lectura = con.ExecuteReader();

            if (lectura.Read()==true)
            {
                student.Tipo = Convert.ToString(lectura[0]);
                student.Id = Convert.ToString(lectura[1]);
                student.Primero_Nombre = Convert.ToString(lectura[2]);
                student.Segundo_Nombre = Convert.ToString(lectura[3]);
                student.Primer_Apellido = Convert.ToString(lectura[4]);
                student.Segundo_Apellido = Convert.ToString(lectura[5]);
                student.Genero = Convert.ToString(lectura[6]);
                student.Id_Curso = Convert.ToString(lectura[7]);
                student.Correo = Convert.ToString(lectura[8]);
                student.Sede = Convert.ToString(lectura[9]);
            }
            
            BDD.conexion.Close();
            return student;
        }

        public DataTable Consultar_ES()
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("Listar_ES", BDD.conexion);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataTable tablaES = new DataTable();
            data.Fill(tablaES);

            return tablaES;
        }
        public DataTable Filtro(String Id)
        {
            Conexion BDD = new Conexion();
            SqlCommand con = new SqlCommand("FIltro_ES", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Id4", Id);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataTable tablaES = new DataTable();
            data.Fill(tablaES);

            return tablaES;
        }

    }
}
