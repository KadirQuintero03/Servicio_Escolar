using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Logica
{
    public class CursosServices
    {
        //Llamada a la capa de Datos
        Datos.RepositoryCourses repositoryCourses = new RepositoryCourse();

        //Envia el nombre del Curso y retorrna el Id del curso
        public string GetById(string nameCourse)
        {
            return repositoryCourses.GetById(nameCourse);
        }

    }
}
