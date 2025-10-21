namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library biblioteca = new Library();
            int opcao;

            biblioteca.Verificador();
            biblioteca.PopularLista();

            do
            {
                Console.WriteLine("--- Biblioteca ---");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Atualizar Livro");
                Console.WriteLine("4 - Apagar livro");
                Console.WriteLine("5 - Sair.");
                Console.Write("Informe a operação desejada: ");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        biblioteca.CreateBook();
                        break;
                    case 2:
                        biblioteca.ReadBooks();
                        break;
                    case 3:
                        biblioteca.UpdateBook();
                        break;
                    case 4:
                        biblioteca.DeleteBook();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 5);

            biblioteca.SaveFile();
        }
    }
}
