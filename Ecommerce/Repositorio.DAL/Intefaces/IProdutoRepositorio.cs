#region --Using--
using Repositorio.Entidades.POCO;
using System.Collections.Generic;
#endregion

namespace Repositorio.DAL.Intefaces
{
    public interface IProdutoRepositorio : IRepositorio<Produto> 
    {
        Produto BuscarProdutoComMaiorQuantidade();

        IEnumerable<Produto> ProdutosSemQuantidade();

    }
}
