using EjemploApiRest.Abstractions;
using Repository;
using System;
using System.Collections.Generic;

namespace EjemploApiRest.Application
{

    //Esta capa va a tener las 4 operaciones basicas del CRUD ya que todas las peticiones van a pasar por la capa de Application y Repository
    //vamos a trabajar con objectos Genericos 


    //para poder construir inyeccion de dependencias necesitamos una Interfaz que represente a la aplicacion 
    // las 4 operaciones las vamos a usar desde una clase de abstraccion ICrud

    public interface IApplication<T>:ICrud<T>
    {

    }

    public class Application<T> : IApplication<T>
    {

        //Aplication va a tener un constructor que recibe un parametro 
        //en este caso el parametro va a ser el repositorio de tipo generico 
        //Con este constructor y parametro estamos inyectando la dependencia 
        //En vez de crear la instancia del repositorio dentro de la clase Application 
        //inyectamos la dependencia ya instanciada en el contenedor de dependencias por tanto repository va  venir instanciado 

        IRepository<T> _repository;
        public Application (IRepository<T> repository)
        {
            //guardamos la instancia del repositorio en un objeto local 
            _repository = repository;
        }

        //Adaptamos los metodos del CRUD para pasarlos directamente a la capa Repository ya que Application solo es una capa 
        //de pasamanos, la capa Application pasa directamente los datos a Repository
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }
    }
}
