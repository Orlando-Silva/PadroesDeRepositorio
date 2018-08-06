#region --Using--
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Intefaces;
using Repositorio.Entidades.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Repositorio.DAL.Repositorios
{
    public class FornecedorRepositorio : Repositorio<Fornecedor>, IFornecedorRepositorio
    {
        public FornecedorRepositorio(EcommerceContexto contexto)
            : base(contexto)
        {

        }

        public IEnumerable<Fornecedor> BuscarFornecedoresPorProduto(int produtoID) => EccomerceContexto.Produtos.Where(_ => _.ID == produtoID).Select(_ => _.Fornecedor);

        protected EcommerceContexto EccomerceContexto { get => Contexto as EcommerceContexto; }

    }
}
