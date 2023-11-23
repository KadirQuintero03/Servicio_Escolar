using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class TeacherServices : IServices<Teacher>
    {
        //Llamada a la capa de Datos
        Datos.RepositoryTeacher repositoryTeacher = new RepositoryTeacher();

        //Envia un conjunto de datos de Teacher y retorna un mensaje si fue almacenado o no
        public string Add(Teacher teacher)
        {
            return repositoryTeacher.AddPR(teacher);
        }

        //Retorna una tabla con los datos de todos los estudiantes
        public DataTable Consultar_PR()
        {
            return repositoryTeacher.Consultar_PR();
        }

        //Envia el id del profesor y retorna un mensaje si fue eliminado o no
        public string Delete(string Id_PR)
        {
            return repositoryTeacher.DeletePR(Id_PR);
        }

        //Envia el id del profesor y retorna un conjunto de datos de Teacher
        public Teacher Busqueda(string Id)
        {
            return repositoryTeacher.Busqueda(Id);
        }

        //Envia un conjunto de datos de Teacher y retorna un mensaje si fue editado o no
        public string Edit(Teacher teacher)
        {
            return repositoryTeacher.EditPR(teacher);
        }
        //Envia el id del profesor y retorna una tabla con los datos de ese profesor
        public DataTable Filtro(String Id)
        {
            return repositoryTeacher.Filtro(Id);
        }

        public bool Exists(Teacher t)
        {
            throw new NotImplementedException();
        }
    }
}
