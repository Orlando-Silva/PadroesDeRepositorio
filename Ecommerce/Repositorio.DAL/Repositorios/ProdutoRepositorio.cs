#region --Using--
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Intefaces;
using Repositorio.Entidades.POCO;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Repositorio.DAL.Repositorios
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {

        #region --Construtor--
        public ProdutoRepositorio(EcommerceContexto contexto)
            : base(contexto)
        {

        }
        #endregion

        public Produto BuscarProdutoComMaiorQuantidade() => Entidades.OrderByDescending(_ => _.Quantidade).FirstOrDefault();

        public IEnumerable<Produto> ProdutosSemQuantidade() => Entidades.Where(_ => _.Quantidade == 0);

    }
}
