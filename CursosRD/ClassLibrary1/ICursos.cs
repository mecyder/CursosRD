using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    interface ICursos
    {
        void Adiccionar(Curso Entidad);
        IQueryable<Curso> AsQueryable();
        IEnumerable<Curso> Buscar(Expression<Func<Curso, bool>> predicado);
        void Eliminar(Curso Entidad);
        void Guardar();
        void Modificar(Curso Entidad);
        IEnumerable<Curso> TraerTodo();
        Curso traeruno(Expression<Func<Curso, bool>> predicado);
        Curso TraerUnoPorID(int Id);



    }
}
