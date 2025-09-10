using System;
using BibliotecaApp.Models;
using BibliotecaApp.Services;

namespace BibliotecaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var biblioteca = new Biblioteca();
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\n ( === BIBLIOTECA === ) ");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Remover livro");
                Console.WriteLine("3. Pesquisar por título");
                Console.WriteLine("4. Pesquisar por autor");
                Console.WriteLine("5. Emprestar livro");
                Console.WriteLine("6. Devolver livro");
                Console.WriteLine("7. Listar todos os livros");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        int ano = int.Parse(Console.ReadLine());
                        biblioteca.AdicionarLivro(new Livro(titulo, autor, ano));
                        Console.WriteLine(" Livro adicionado.");
                        break;

                    case "2":
                        Console.Write("Título do livro a remover: ");
                        string tituloRemover = Console.ReadLine();
                        if (biblioteca.RemoverLivro(tituloRemover))
                            Console.WriteLine(" Livro removido.");
                        else
                            Console.WriteLine(" Livro não encontrado.");
                        break;

                    case "3":
                        Console.Write("Título para pesquisa: ");
                        string tituloBusca = Console.ReadLine();
                        var encontradosTitulo = biblioteca.PesquisarPorTitulo(tituloBusca);
                        MostrarLivros(encontradosTitulo);
                        break;

                    case "4":
                        Console.Write("Autor para pesquisa: ");
                        string autorBusca = Console.ReadLine();
                        var encontradosAutor = biblioteca.PesquisarPorAutor(autorBusca);
                        MostrarLivros(encontradosAutor);
                        break;

                    case "5":
                        Console.Write("Título do livro para empréstimo: ");
                        string tituloEmprestimo = Console.ReadLine();
                        if (biblioteca.EmprestarLivro(tituloEmprestimo))
                            Console.WriteLine(" Livro emprestado.");
                        else
                            Console.WriteLine(" Livro não disponível ou não encontrado.");
                        break;

                    case "6":
                        Console.Write("Título do livro para devolução: ");
                        string tituloDevolucao = Console.ReadLine();
                        if (biblioteca.DevolverLivro(tituloDevolucao))
                            Console.WriteLine(" Livro devolvido.");
                        else
                            Console.WriteLine(" Livro não encontrado ou já disponível.");
                        break;

                    case "7":
                        var todos = biblioteca.ListarTodos();
                        MostrarLivros(todos);
                        break;

                    case "0":
                        executando = false;
                        Console.WriteLine(" Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine(" Opção inválida.");
                        break;
                }
            }
        }

        static void MostrarLivros(System.Collections.Generic.List<Livro> livros)
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado.");
                return;
            }

            Console.WriteLine("\n Livros encontrados:");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
    }
}
