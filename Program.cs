using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double sucessor = num + 1;
            double antecessor = num - 1;
            Console.WriteLine("O número digitado foi " + num + ", seu antecessor é " + antecessor +" e seu sucessor é " + sucessor);
        }
    }
}
