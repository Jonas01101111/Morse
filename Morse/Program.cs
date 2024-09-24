using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Morse
{
    internal class Program
    {
        static string ToMorse(char letra)
        {
            string codificado = "";

            switch (letra)
            {
                case 'a':
                    codificado = ".-";
                    break;
                case 'b':
                    codificado = "-...";
                    break;
                case 'c':
                    codificado = "-.-.";
                    break;
                case 'd':
                    codificado = "-..";
                    break;
                case 'e':
                    codificado = ".";
                    break;
                case 'f':
                    codificado = "..-.";
                    break;
                case 'g':
                    codificado = "--.";
                    break;
                case 'h':
                    codificado = "....";
                    break;
                case 'i':
                    codificado = "..";
                    break;
                case 'j':
                    codificado = ".---";
                    break;
                case 'k':
                    codificado = "-.-";
                    break;
                case 'l':
                    codificado = ".-..";
                    break;
                case 'm':
                    codificado = "--";
                    break;
                case 'n':
                    codificado = "-.";
                    break;
                case 'o':
                    codificado = "---";
                    break;
                case 'p':
                    codificado = ".--.";
                    break;
                case 'q':
                    codificado = "--.-";
                    break;
                case 'r':
                    codificado = ".-.";
                    break;
                case 's':
                    codificado = "...";
                    break;
                case 't':
                    codificado = "-";
                    break;
                case 'u':
                    codificado = "..-";
                    break;
                case 'v':
                    codificado = "...-";
                    break;
                case 'w':
                    codificado = ".--";
                    break;
                case 'x':
                    codificado = "-..-";
                    break;
                case 'y':
                    codificado = "-.--";
                    break;
                case 'z':
                    codificado = "--..";
                    break;
                case ' ':
                    codificado = " ";
                    break;
            }
            return codificado;

        } 
        static void ToSound (char codi_ficado)
        {
            switch (codi_ficado) 
            {

                case '.':
                    Console.Beep(800, 200);
                    break;
                case '-':
                    Console.Beep(800, 600);
                    break;
                case ' ':
                    Console.Beep(37, 600);
                    break;
                
            }
            }




        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite sua mensagem:");
                string texto = Console.ReadLine();
                string codigo = "";

                foreach (char c in texto)
                {
                    codigo += ToMorse(c) + " ";
                }
                Console.Clear();
                Console.WriteLine("Mensagem:");
                Console.WriteLine(codigo);

                foreach (char c in codigo)
                {
                    ToSound(c);
                }

                Console.Clear();
                Console.WriteLine("Aperte enter");

                Console.ReadKey();
            }
        
        }
    }
}
