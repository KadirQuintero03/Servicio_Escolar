using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notas : Materia
    {
        //Declaracion de atributos
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Definitiva { get; set; }

        //Declaracion de constructores 
        public Notas(string Materia,decimal nota1, decimal nota2, decimal nota3, decimal definitiva)
        {
            Nombre_Materia=Materia;
            Nota1=nota1;
            Nota2=nota2;
            Nota3=nota3;    
            Definitiva=definitiva;
           
        }
    }
}
