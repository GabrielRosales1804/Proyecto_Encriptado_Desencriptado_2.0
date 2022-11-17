using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Proyecto_Encriptado_Desencriptado_2._0
{
    static class ArrayExtensions
    {
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }
    }
    
    internal class Program
    { 
        public static int[] conNumberos(string frase)
        {
            char[] charFrase = frase.ToCharArray();
            int[] numbrsus = new int[charFrase.Length];
            for(int i = 0; i < charFrase.Length; i++)
            {
                numbrsus[i] = numberToht(charFrase[i]);
            }
            return numbrsus;
        }

        public static int numberToht(char letter)
        {
            char[] alfabeto = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '.', };
            int index = alfabeto.IndexOf (letter);
            return index;
        }
        static void Main(string[] args)
        {
            string Tipo_de_accion = " "; //Escribo mi dato para que escriba en string y no en int 
            Console.WriteLine("Escirbe Encriptado si quieres encriptado o desencriptado si quieres hacer lo contraio");
            Console.WriteLine(" ");
            Tipo_de_accion = Console.ReadLine();
            switch (Tipo_de_accion) //Pongo la funcion switch para que pueda escoger la opcion
            {
                case "encriptado":
                    Console.WriteLine(" ");
                    Console.WriteLine("Escogiste Encriptado");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingresa una frase: ");
                    Console.WriteLine(" ");
                    string fraseses = Console.ReadLine();

                    int[] numerrus = conNumberos(fraseses);
                    for(int i = 0; i<numerrus.Length; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write(numerrus[i] + " ");

                    }
                    break;

                case "desencriptado":
                    Console.WriteLine("Escogiste encriptado");
                    break;
                    
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}
