using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    internal class Program
    {
        static string ToMorse(char letra) 
        {
            string codificado="";
            
            switch (letra) 
            {
                case 'a':
                    codificado = ".-";
                    break;
                case 'b':
                    codificado = "a";
                    break;
                case 'c':
                    codificado = "a";
                    break;
                case 'd':
                    codificado = "a";
                    break;
                case 'e':
                    codificado = "a";
                    break;
                case 'f':
                    codificado = "a";
                    break;
                case 'g':
                    codificado = "a";
                    break;
                case 'h':
                    codificado = "a";
                    break;
                case 'i':
                    codificado = "a";
                    break;
                case 'j':
                    codificado = "a";
                    break;
                case 'k':
                    codificado = "a";
                    break;
                case 'l':
                    codificado = "a";
                    break;
                case 'm':
                    codificado = "a";
                    break;
                case 'n':
                    codificado = "a";
                    break;
                case 'o':
                    codificado = "a";
                    break;
                case 'p':
                    codificado = "a";
                    break;
                case 'q':
                    codificado = "a";
                    break;
                case 'r':
                    codificado = "a";
                    break;
                case 's':
                    codificado = "a";
                    break;
                case "t":
                    codificado = "a";
                    break;
                case "u":
                    codificado = "a";
                    break;
                case "v":
                    codificado = "a";
                    break;
                case "w":
                    codificado = "a";
                    break;
                case "x":
                    codificado = "a";
                    break;
                case "y":
                    codificado = "a";
                    break;
                case "z ":
                    codificado = "a";
                    break;

            }
            return codificado;

        }



        static void Main(string[] args)
        {   
            string texto = "aaaa";
            string codigo = "";

            foreach (char c in texto) 
            {
                codigo = ToMorse(c);
            }


        }
    }
}
