#region --Using--
using Repositorio.Entidades.FluentAPI;
using Repositorio.Entidades.POCO;
using System.Data.Entity;
#endregion

namespace Repositorio.DAL.Contexto
{
    public class EcommerceContexto : DbContext
    {
        #region --Atributos--
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        #endregion

        #region --Construtor--
        public EcommerceContexto()
            : base("name=localhost")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        #endregion

        #region --Override--
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FornecedorConfiguracoes());
            modelBuilder.Configurations.Add(new ProdutoConfiguracoes());
        }
        #endregion

    }
}
