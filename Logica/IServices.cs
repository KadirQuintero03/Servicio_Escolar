using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServices<T>
    {
        //Declaracion de funciones y metodos que pueden heredar los otros Iservices
        string Add(T t);
        string Delete(string id);
        bool Exists(T t);
        string Edit(T t);
        T Busqueda(string Id);

    }
}
