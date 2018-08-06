#region --Using--
using Repositorio.Entidades.POCO;
using System.Collections.Generic;
#endregion

namespace Repositorio.DAL.Intefaces
{
    public interface IFornecedorRepositorio : IRepositorio<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarFornecedoresPorProduto(int produtoID);
    }
}
