#region --Using--
using Repositorio.Entidades.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Repositorio.DAL.Intefaces
{
    public interface IFornecedorRepositorio : IRepositorio<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarFornecedoresPorProduto(int produtoID);
    }
}
