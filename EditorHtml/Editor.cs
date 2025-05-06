using System;
using System.Text;
using System.IO;




namespace EditorHtml
{
    public static class Editor
    {
        static string path = "C:\\balta\\EditorHtml\\";
        public static void Show()
        {
            //Menu do modo editor, sem mais.

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("===========");
            Start();
        }

        public static void Start()
        {

            //Cria uma var que suporta longos textos
            var file = new StringBuilder();

            //Enquanto não apertar ESC não sai do loop
            do
            {
                //Coloca em file tudo que digitou
                file.Append(Console.ReadLine());
                //Se apertar ENTER, abre nova linha para poder ler novamente.
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("===========");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("1 para sim");
            Console.WriteLine("2 para não");

            //Grava a vontade do user de gravar ou não.
            var option = short.Parse(Console.ReadLine());

            //Passa para o método salvar o arquivo digitado e o comando de salvar ou não.
            Save(option, file);

        }

        public static void Save(short option, StringBuilder file)
        {
            //Se o usuário não quiser salvar, quebra
            if (option == 2)
                return;

            Console.Clear();

            //Se ele quiser salvar, define o nome que o arquivo de texto terá
            Console.Write("Digite o nome do arquivo: ");
            var nome = Console.ReadLine();

            var end_final = Path.Combine(path, nome + ".txt");

            //Using abre e fecha o arquivo automaticamente
            using (var text = new StreamWriter(end_final))
            //Text recebe um fluxo de escrita com o caminho 
            {
                //O que está escrito em file, está sendo gravado em text que tem o caminho passado junto
                //Com a informação do fluxo de escrita
                text.Write(file);
            }

            //Informa que foi salvo e retorna.
            Console.WriteLine($"Arquivo {end_final}  foi salvo com sucesso!");
            Console.ReadLine();

            var conteudo = File.ReadAllText(end_final);

            Viewer.Show(conteudo);

        }
    }
}