#region --Using--
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
#endregion

namespace Repositorio.DAL.Intefaces
{
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T entidade);
        void Adicionar(IEnumerable<T> entidades);

        T Buscar(int ID);
        IEnumerable<T> BuscarTodos();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicato);

        void Remover(T entidade);
        void Remover(IEnumerable<T> entidades);
    }
}
