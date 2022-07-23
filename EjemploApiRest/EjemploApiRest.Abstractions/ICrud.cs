using System;
using System.Collections.Generic;

namespace EjemploApiRest.Abstractions
{

    //las 4 operaciones basicas del CRUD se necesitan en varias capas como Application, Repository y DataAccess 
    //Asique las vamos a representar en una Interface  y para que no sea repetitivo y sea reutilizable creamos la Interface en la 
    //capa de Abstractions 


    public interface ICrud<T>
    {

        //operacion que actualice o inserte segun corresponda
        T Save(T entity);

        //devolver una lista de todo
        //usando lo mas generico posible en Este caso una lista coin IList<>
        IList<T> GetAll();

        //devolver un Objecto a partir de su ID
        T GetById(int id);

        //eliminar por Id

        void Delete(int id);


    }
}
 