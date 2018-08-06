#region --Using--
using Repositorio.Entidades.POCO;
using System.Data.Entity.ModelConfiguration;
#endregion

namespace Repositorio.Entidades.FluentAPI
{
    public class ProdutoConfiguracoes : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguracoes()
        {
            Property(_ => _.Nome)
                .HasMaxLength(64);

            Property(_ => _.FornecedorID)
                .HasColumnName("FornecedorID");
        }
    }
}
