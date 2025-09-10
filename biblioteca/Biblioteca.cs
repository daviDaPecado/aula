using System.Collections.Generic;
using System.Linq;
using BibliotecaApp.Models;

namespace BibliotecaApp.Services
{
    public class Biblioteca
    {
        private List<Livro> livros = new();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public bool RemoverLivro(string titulo)
        {
            var livro = livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null)
            {
                livros.Remove(livro);
                return true;
            }
            return false;
        }

        public List<Livro> PesquisarPorTitulo(string titulo)
        {
            return livros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Livro> PesquisarPorAutor(string autor)
        {
            return livros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool EmprestarLivro(string titulo)
        {
            var livro = livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase) && !l.Emprestado);
            if (livro != null)
            {
                livro.Emprestar();
                return true;
            }
            return false;
        }

        public bool DevolverLivro(string titulo)
        {
            var livro = livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase) && l.Emprestado);
            if (livro != null)
            {
                livro.Devolver();
                return true;
            }
            return false;
        }

        public List<Livro> ListarTodos()
        {
            return livros;
        }
    }
}
