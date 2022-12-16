using System;
using System.Collections.Generic;
using System.Text;

namespace GeneroLivroApp
{
    class Livro
    {
        private string nome, autores;
        private double preco;
        public Livro(string nome, string autores, double preco)
        {
            if (nome != null) this.nome = nome;
            if (autores != null) this.autores = autores;
            if (preco > 0) this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }
        public override string ToString()
        {
            return $"Livro: {nome} - autor(es): {autores} - preco: {preco}";
        }
    }
}
