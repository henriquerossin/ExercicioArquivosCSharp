using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Library
    {
        public List<Livro> livros = new List<Livro>();

        static string filePath = "livros.txt";
        static string directoryPath = "C:\\Biblioteca\\";
        static string fullPath = Path.Combine(directoryPath, filePath);

        public void PopularLista()
        {
            StreamReader sr = new StreamReader(fullPath);

            string line;
            while ((line = sr.ReadLine()!) != null)
            {
                var dado = line.Split(',');

                string Titulo = dado[0];
                string Autor = dado[1];
                string AnoLancamento = dado[2];
                string Genero = dado[3];

                Livro l = new Livro(Titulo, Autor, AnoLancamento, Genero);

                livros.Add(l);
            }
            sr.Close();
        }

        public Livro CreateBook()
        {
            Livro livro = new Livro();

            Console.Write("Informe o Título do livro: ");
            livro.Titulo = Console.ReadLine()!;

            Console.Write("Informe o Autor do livro: ");
            livro.Autor = Console.ReadLine()!;

            Console.Write("Informe o Ano de Lançamento do livro: ");
            livro.AnoLancamento = Console.ReadLine()!;

            Console.Write("Informe o Gênero do livro: ");
            livro.Genero = Console.ReadLine()!;

            livros.Add(livro);

            return livro;
        }

        public void SaveFile()
        {
            using (StreamReader reader = new StreamReader(fullPath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
                reader.Close();
            }

            StreamWriter writer = new StreamWriter(fullPath/*, append: true*/);
            foreach (var livro in livros)
            {
                writer.WriteLine(livro);
            }
            writer.Close();
        }

        public void ReadBooks()
        {
            foreach (var livro in livros)
            {
                Console.WriteLine(livro.ToString());
            }
        }

        public Livro UpdateBook()
        {
            Console.Write("Informe o Título do livro que será atualizado: ");
            string titulo = Console.ReadLine()!;

            var livroASerAtualizado = livros.Find(l => l.Titulo == titulo)!;

            Console.Write("Informe o novo Título do livro: ");
            livroASerAtualizado.Titulo = Console.ReadLine()!;

            Console.Write("Informe o novo Autor do livro: ");
            livroASerAtualizado.Autor = Console.ReadLine()!;

            Console.Write("Informe o novo Ano de Lançamento do livro: ");
            livroASerAtualizado.AnoLancamento = Console.ReadLine()!;

            Console.Write("Informe o novo Gênero do livro: ");
            livroASerAtualizado.Genero = Console.ReadLine()!;



            return livroASerAtualizado;


        }

        public List<Livro> DeleteBook()
        {
            Console.Write("Informe o nome do livro que será deletado: ");
            string titulo = Console.ReadLine()!;

            var livroASerRemovido = livros.Remove(livros.Find(l => l.Titulo == titulo)!);

            return livros;
        }
    }
}
