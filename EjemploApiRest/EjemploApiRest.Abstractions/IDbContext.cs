using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApiRest.Abstractions
{

    //implementamos la intefraz de ICRUD con las operaciones basicas 
    //Nota personal: siendo una implementacion de un Interfaz sobre otra interfaz no se obliga a implementar los metodos 
    public interface IDbContext<T> :ICrud<T>
    {
    }
}
