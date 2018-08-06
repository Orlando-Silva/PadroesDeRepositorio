#region --Using--
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Intefaces;
using Repositorio.DAL.Repositorios;
#endregion

namespace Repositorio.DAL
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private readonly EcommerceContexto _contexto;

        public UnidadeDeTrabalho(EcommerceContexto contexto)
        {
            _contexto = contexto;
            Fornecedores = new FornecedorRepositorio(_contexto);
            Produtos = new ProdutoRepositorio(_contexto);
        }

        public IFornecedorRepositorio Fornecedores { get; private set; }

        public IProdutoRepositorio Produtos { get; private set; }

        public void Finalizar() => _contexto.SaveChanges();

        public void Dispose() => _contexto.Dispose();

    }
}
