using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;

namespace EditorHtml
{
    public static class Menu
    {

        public static void Show()
        {
            //Show monta o fundo, chama o Draw pra definir o tamanho da tela e chama o Write pra imprimir o menu,
            //Coleta a opção desejada e chama Handle pra manipular a opção.
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void WriteOptions()
        {
            //Só imprime o menu na tela quando é chamado por Show

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            //Manipula a opção que o usuário digitou e armazenou em option em show e trazida por parâmetro pra cá.

            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

        public static void DrawScreen()
        {
            //Questiona ao usuário o tamanho de tela que ele deseja e chama as  funções COL e LINES passando os desejos do usuário.
            //

            Console.WriteLine("Digite o número de colunas que deseja que o quadrado tenha: ");
            var col = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas que deseja que o quadrado tenha: ");
            var lines = int.Parse(Console.ReadLine());

            Col(col);
            Lines(lines, col);
            Col(col);
        }

        public static void Col(int col)
        {
            //Recebe de Draw a qtd de colunas que o menu deve ter e cuida para realizar o desejo
            Console.Write("+");
            for (int i = 0; i < col; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

        }

        public static void Lines(int lines, int col)
        {
            //Recebe de Draw a quantia de linhas e colunas de draw, imprime nas pontas
            for (int i = 0; i < lines; i++)
            {
                Console.Write("|");

                //O laço de dentro percorre imprimindo espaços em branco, garantindo que vá até o final para que possamos imprimi "|"
                //Ao finali de cada linha quando sair do loop.
                for (int j = 0; j < col; j++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}