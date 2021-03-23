using System;

namespace Gritador
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			Console.WriteLine("Digite o que quiser...:");
			string Gritador = Console.ReadLine();
			Console.Clear();
			Console.WriteLine(Gritador.ToUpper());
        }
    }
}