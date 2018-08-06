#region --Using--
using Repositorio.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace Repositorio.DAL
{
    //A classe Repositorio deve ser genérica pois o diálogo com o banco de dados sempre é o mesmo.
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        #region --Atributos--
        //Note como o contexto é DbContext e não EcommerceContexto. Isto é porque a Repositorio não é construida para uma aplicação mas sim para todas as aplicações independentes do contexto.
        protected readonly DbContext Contexto;

        protected readonly DbSet<T> Entidades;
        #endregion

        #region --Construtor--
        public Repositorio(DbContext contexto)
        {
            Contexto = contexto;
            Entidades = Contexto.Set<T>();
        }
        #endregion

        public void Adicionar(T entidade) => Entidades.Add(entidade);

        public void Adicionar(IEnumerable<T> entidades) => Entidades.AddRange(entidades);

        public T Buscar(int ID) => Entidades.Find(ID);

        public T BuscarPrimeiro(Expression<Func<T, bool>> predicato) => Entidades.FirstOrDefault(predicato);

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicato) => Entidades.Where(predicato);

        public IEnumerable<T> BuscarTodos() => Entidades.ToList();

        public void Remover(T entidade) => Entidades.Remove(entidade);

        public void Remover(IEnumerable<T> entidades) => Entidades.RemoveRange(entidades);

    }
}
