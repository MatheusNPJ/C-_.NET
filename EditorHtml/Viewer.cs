using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string conteudo)
        {
            //Menu do modo Viewer, sem mais.

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("===========");
            Replace(conteudo);
            Console.WriteLine("===========");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string conteudo)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);
            var matches = strong.Matches(conteudo);

            int currentIndex = 0;

            foreach (Match match in matches)
            {
                // Imprime o texto antes da tag <strong>
                string beforeStrong = conteudo.Substring(currentIndex, match.Index - currentIndex);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(beforeStrong);

                // Imprime o conteúdo dentro do <strong>
                string boldText = match.Groups[1].Value;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(boldText);

                currentIndex = match.Index + match.Length;
            }

            // Imprime o restante do texto
            if (currentIndex < conteudo.Length)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(conteudo.Substring(currentIndex));
            }

            Console.ResetColor();
        }
    }
}