﻿namespace Repositorio.Entidades.POCO
{
    public class Produto
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public int FornecedorID { get; set; }

    }
}
