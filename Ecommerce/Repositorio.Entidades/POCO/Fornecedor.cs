#region --Using--
using System.Collections.Generic;
#endregion

namespace Repositorio.Entidades.POCO
{
    public class Fornecedor
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}
