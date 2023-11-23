using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Conexion
    {
        //Url de conexion a la base de datos
        public SqlConnection conexion = new SqlConnection("Server = LENOVODEKADIR\\SQLEXPRESS ; DataBase = proyecto; Integrated Security = true");

        //Funcion que abre la conexion y valida si esta cerrada para abrirla
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        //Funcion que cierra la conexion y valida si esta abierta para cerrarla
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
