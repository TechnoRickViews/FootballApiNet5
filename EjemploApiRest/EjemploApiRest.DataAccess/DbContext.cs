using EjemploApiRest.Abstractions;
using System;
using System.Collections.Generic;

namespace EjemploApiRest.DataAccess
{
    //la capa de acceso a datos es un proveedor de datos que este puede ser 
    //una bbdd algo guardado en memoria, adonet
    //Es el contexto de base de datos 
    //Va ser generico y va a implementar una Interfaz que se define en la capa de abstracciones 
    public class DbContext<T> : IDbContext<T>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
