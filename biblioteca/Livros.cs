namespace BibliotecaApp.Models
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicado;
        public bool Emprestado;

        public Livro(string titulo, string autor, int anoPublicado)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicado = anoPublicado;
            Emprestado = false;
        }

        public void Emprestar()
        {
            Emprestado = true;
        }

        public void Devolver()
        {
            Emprestado = false;
        }

        public override string ToString()
        {
            string status = Emprestado ? "Emprestado" : "Disponível";
            return $"{Titulo} - {Autor} ({AnoPublicado}) [{status}]";
        }
    }
}
