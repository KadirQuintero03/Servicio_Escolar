using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NotasServices 
    {
        //Llamada a la capa de Datos
        Datos.RepositorioNotas repositorioNotas = new RepositorioNotas();

        //Envia el id del estudiante y retorna un mensaje interno
        public string Add2(string Id)
        {
            return repositorioNotas.ADD(Id);
        }
        //Envia el id del estudiante, no retorna nada porque esun proceso interno
        public void Delete(string Id)
        {
            repositorioNotas.Eliminar(Id);
        }

        //Envia el id del estudiante, la materia y las 4 notasmodificas y retorna un mensaje si lo modifico o no
        public string Edit2(string Id, string Id_Materia, decimal Nota1, decimal Nota2, decimal Nota3, decimal Definitiva)
        {
            return repositorioNotas.Actualizar(Id, Id_Materia, Nota1, Nota2, Nota3, Definitiva);
        }

        //Envia el id de la Materia y del curso y retorna una tabla de los alumnos de esa materia y curso
        public DataTable Consultar_Notas(Materia materia, Curso curso)
        {
            return repositorioNotas.Consultar_Notas(materia.Id_Materia, curso.Id_Curso);
        }

        //Envia el Id, el nombre de la materia y el curso y retorna una tabla de los alumnos buscados
        public DataTable Filtro(string Id, string NMateria, string Curso)
        {
            return repositorioNotas.Filtro(Id,NMateria,Curso);
        }

        //Envia el Id del alumno y retorna una lista de las notas de ese alumno
        public List<Notas> Reporte (String id)
        {
            return repositorioNotas.Reporte(id);
        }
    }
}
