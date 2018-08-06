#region --Using--
using Repositorio.Entidades.POCO;
using System.Data.Entity.ModelConfiguration;
#endregion

namespace Repositorio.Entidades.FluentAPI
{
    public class FornecedorConfiguracoes : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguracoes()
        {
            Property(_ => _.Nome)
                .HasMaxLength(64);

            HasMany(_ => _.Produtos)
                .WithRequired(_ => _.Fornecedor);
        }

    }
}
