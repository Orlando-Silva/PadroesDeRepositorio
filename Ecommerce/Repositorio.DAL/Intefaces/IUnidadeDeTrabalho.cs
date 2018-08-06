#region --Using--
using System;
#endregion

namespace Repositorio.DAL.Intefaces
{
    public interface IUnidadeDeTrabalho : IDisposable
    {
        IFornecedorRepositorio Fornecedores { get; }
        IProdutoRepositorio Produtos { get; }
        void Finalizar();
    }
}
