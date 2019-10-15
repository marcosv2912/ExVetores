using System;

namespace ExVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Rooms[] vect = new Rooms[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Rooms(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(i +": "+vect[i]);
            }
        }
    }
}
