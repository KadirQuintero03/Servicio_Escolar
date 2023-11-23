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
    public class RepositoryUser : Conexion
    {
        public bool Add(User user)
        {
            string procedimiento = "Ing_NuevoUs";
            string Contraseña = user.UserName;
            return Crud(user.UserName, Contraseña, user.Rol, procedimiento);
        }

        public bool Exists(string UserName, string Contraseña, string Rol)
        {
            string procedimiento = "Logins";
            return Crud(UserName, Contraseña, Rol, procedimiento);
        }

        public string Update(string ContraseñaV, string ContraseñaN)
        {
            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand("Cambiar_Contra", BDD.conexion);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@ContraseñaV", ContraseñaV);
            con.Parameters.AddWithValue("@ContraseñaN", ContraseñaN);
            var actualizado = con.ExecuteNonQuery();
            return actualizado == 1?"Se actualizo correctamente":"Error, no se pudo actualizar la contraseña";
            BDD.conexion.Close();
        }

        public bool Crud(string UserName, string Contraseña, string Rol, string procedimiento) {

            Conexion BDD = new Conexion();
            BDD.conexion.Open();
            SqlCommand con = new SqlCommand(procedimiento, BDD.conexion);

            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@UserName", UserName);
            con.Parameters.AddWithValue("@Contraseña", Contraseña);
            con.Parameters.AddWithValue("@Rol", Rol);
            SqlDataReader lectura = con.ExecuteReader();
            while (lectura.HasRows==true)
            {
                return true;
            }
            return false;
            BDD.conexion.Close();
        }
    }
}
