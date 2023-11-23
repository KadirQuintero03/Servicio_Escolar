using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Logica
{
    public class AdminServices
    {
        //Llamada a la capa Datos
        Datos.RepositoryUser repositoryUser = new Datos.RepositoryUser();

        //Envia el conjunto de datos del User y retorna un booleano si lo agregò o no
        public bool Add(User user)
        {
            return repositoryUser.Add(user);
        }

        //Envia la contraseña vieja y nueva y retorna un mensaje de si lo agregò o no
        public string Update(string ContraseñaV, string ContraseñaN)
        {
            return repositoryUser.Update(ContraseñaV, ContraseñaN);
        }

        //Envia el UserName, Contraseña y rol del User y retorna un booleano si existe o no
        public bool Exists(User user)
        {
            return repositoryUser.Exists(user.UserName, user.Contraseña, user.Rol);
        }

    }
}