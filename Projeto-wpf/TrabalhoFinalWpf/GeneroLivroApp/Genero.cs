using System;
using System.Collections.Generic;
using System.Text;

namespace GeneroLivroApp
{
    class Genero
    {
        private string nome;
        private Livro[] livros = new Livro[10];
        private int g = 0;
        public Genero(string a)
        {
            nome = a;
        }

        public void Inserir(Livro l)
        {
            livros[g] = l;
            g++;
        }
        public Livro[] Listar()
        {
            Livro[] vetor = new Livro[g];
            Array.Copy(livros, vetor, g);
            return vetor;
        }
        public Livro MenorPreco()
        {
            Livro menor = livros[0];
            for (int i = 1; i <= g - 1; i++)
            {
                if (livros[i].GetPreco() < menor.GetPreco()) menor = livros[i];
            }
            return menor;
        }
        public override string ToString()
        {
            return $"Genero: {nome}";
        }
    }
}
