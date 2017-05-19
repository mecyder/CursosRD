using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;
using Entidades;
using DatosRepositorio;
using System.Linq.Expressions;

namespace BussinesLogic
{


    public class Metodos : IRepositorio<Curso>
    {
        private IRepositorio<Curso> cursosRepo = null;
        private CursosRDEntities context = null;

        //declaracion de constructor de la clase
        public Metodos()
        {
            context = new CursosRDEntities();
            cursosRepo = new Repositorio<Curso>(context);

        }

        public void Adiccionar(Curso Entidad)
        {
            cursosRepo.Adiccionar(Entidad);
        }

        public IQueryable<Curso> AsQueryable()
        {
            return cursosRepo.AsQueryable();
        }

        public IEnumerable<Curso> Buscar(Expression<Func<Curso, bool>> predicado)
        {
            return cursosRepo.Buscar(predicado);
        }

        public void Eliminar(Curso Entidad)
        {
            cursosRepo.Eliminar(Entidad);
        }

        public void Guardar()
        {
            cursosRepo.Guardar();
        }

        public void Modificar(Curso Entidad)
        {
            cursosRepo.Modificar(Entidad);
        }
        //metodo que trae todos los cursos
        public IEnumerable<Curso> TraerTodo()
        {
            return cursosRepo.TraerTodo();
        }

        public Curso traeruno(Expression<Func<Curso, bool>> predicado)
        {
            return cursosRepo.traeruno(predicado);
        }

        public Curso TraerUnoPorID(int Id)
        {
            return cursosRepo.TraerUnoPorID(Id);
        }
    }
}
