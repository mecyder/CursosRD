using DatosRepositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data;

namespace DatosRepositorio
{
   public class Repositorio<T>:IRepositorio<T>,IDisposable where T:class
    {
        private readonly DbContext _contexto;
        public Repositorio(DbContext contexto)
        {
            _contexto = contexto;
        }
        

        public void Adiccionar(T Entidad)
        {
            if (_contexto.Entry<T>(Entidad).State != EntityState.Detached)
                _contexto.Entry<T>(Entidad).State = EntityState.Added;
            else
                _contexto.Set<T>().Add(Entidad);
        }

        public IQueryable<T> AsQueryable()
        {
            return _contexto.Set<T>().AsQueryable();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            return _contexto.Set<T>().Where(predicado);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T Entidad)
        {
            if (_contexto.Entry<T>(Entidad).State == EntityState.Detached)
                _contexto.Set<T>().Attach(Entidad);
            else
                _contexto.Entry<T>(Entidad).State = EntityState.Deleted;
        }

        public void Guardar()
        {
            _contexto.SaveChanges();
        }
        public void IDisposable()
        {
            return;
        }

        public void Modificar(T Entidad)
        {
            if (_contexto.Entry<T>(Entidad).State == EntityState.Detached)
                _contexto.Set<T>().Add(Entidad);
            else
                _contexto.Entry<T>(Entidad).State = EntityState.Modified;
        }

        public IEnumerable<T> TraerTodo()
        {
            return _contexto.Set<T>();
        }

        public T traeruno(Expression<Func<T, bool>> predicado)
        {
            return _contexto.Set<T>().Where(predicado).FirstOrDefault();
        }

        public T TraerUnoPorID(int Id)
        {
            return _contexto.Set<T>().Find(Id);
        }
    }
}
