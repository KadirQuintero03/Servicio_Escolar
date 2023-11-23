using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Person : User
    {
        //Declaracion de atributos
        public String Tipo{ set; get; }
        public String Id{ set; get; }
        public String Primero_Nombre { set; get; }
        public String Segundo_Nombre { set; get; }
        public String Primer_Apellido { set; get; }
        public String Segundo_Apellido { set; get; }
        public String Correo { set; get; }
        public string Curso { get; set; }
        public String Sede { set; get; }
        public String Genero{ set; get; }
        public string Id_Curso { get; set; }
    }
}
