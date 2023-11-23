using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using Datos;
using System.Security.Cryptography.X509Certificates;

namespace Logica
{
    public class StudentServices : IServices<Student>
    {
        //Llamada a la capa de Datos
        Datos.RepositoryStudent repositoryStudent = new RepositoryStudent();

        //Envia un conjunto de datos de Student y retorna un mensaje si fue almacenado o no
        public string Add(Student student)
        {
            return repositoryStudent.ADD(student);
        }

        //Envia un conjunto de datos de Student y retorna un mensaje si fue editado o no
        public string Edit(Student student)
        {
            return repositoryStudent.Edit(student);
        }

        //Envia el id del alumno y retorna un mensaje si fue eliminado o no
        public string Delete(string Id)
        {
            return repositoryStudent.Delete(Id);
        }

        //Envia el id del alumno y retorna un conjunto de datos de Student
        public Student Busqueda(string Id)
        {
            return repositoryStudent.Busqueda(Id); 
        }

        //Retorna una tabla con los datos de todos los estudiantes
        public DataTable Consultar_ES()
        {
            return repositoryStudent.Consultar_ES();
        }

        //Envia el id del alumno y retorna una tabla con los datos de ese alumno
        public DataTable Filtro(String Id)
        {
            return repositoryStudent.Filtro(Id);
        }

        public bool Exists(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
