using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatosRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        //Retorna Queryable
        IQueryable<T> AsQueryable();
        //Retorna Todo como Enumerable
        IEnumerable<T> TraerTodo();
        //Metodo para buscar
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);
        //Metodo Para Traer Un Solo Objeto
        T traeruno(Expression<Func<T, bool>> predicado);
        //Metodo Para Buscar Uno Por ID
        T TraerUnoPorID(int Id);
        //Agregar uno
        void Adiccionar(T Entidad);
        void Modificar(T Entidad);
        void Eliminar(T Entidad);
        void Guardar();
    }
}
