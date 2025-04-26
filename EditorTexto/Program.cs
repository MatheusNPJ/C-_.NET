using System;
using System.IO;


namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar novo arquivo");
            Console.WriteLine("0- Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.Write("Qual o nome do nome do arquivo? ");
            var nome = Console.ReadLine();

            using (var file = new StreamReader(Path.Combine(path, nome + ".txt")))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (Esc para sair) ");
            Console.WriteLine("_______________________");
            string text = "";

            do
            {
                //Lê a linha
                text += Console.ReadLine();
                text += Environment.NewLine;
                //Caso usuário quebrou a linha, ele atribui nova linha no fim de cada leitura

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            //Enquanto não digitar ESC

            Salvar(text);

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.Write("Digite o nome do arquivo: ");
            var nome = Console.ReadLine();


            using (var file = new StreamWriter(Path.Combine(path, nome + ".txt")))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} foi salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

        static string path = "C:\\balta\\EditorTexto\\";
    }
}