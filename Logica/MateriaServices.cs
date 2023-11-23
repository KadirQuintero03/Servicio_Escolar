using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MateriaServices 
    {
        //Llamada a la capa Datos
        RepositorioMaterias repositorioMaterias = new RepositorioMaterias();

        //Envia el id de la Materia y del profesor y retorna si lo agrego o no al profesor
        public string Add2(string Id_Materia, string Id_PR)
        {
            return repositorioMaterias.Asig_Materia(Id_Materia,Id_PR);
        }

        //Envia el id de la Materia y del profesor y retorna el nombre de la Materia
        public Materia GetById(string Id_Materia, string Id_PR)
        {
            return repositorioMaterias.Busqueda(Id_Materia, Id_PR);
        }

        //Envia el nombre de la Materia y retorna el id de la Materia
        public string GetByName(Materia materia)
        {
            return repositorioMaterias.Bus_Nombre(materia.Nombre_Materia);
        }

        //Envia el id del profesor, no retorna nada porque es un proceso interno
        public void Delete(string Id_PR)
        {
            repositorioMaterias.Eliminar_AP(Id_PR);
        }

    }
}
