using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1; 
            int numero;

            Console.WriteLine("Digite um número para calcular o fatorial: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >=1 ){
                fatorial = fatorial * numero;
                numero-=1;
            }
            Console.WriteLine($"O fatorial  é = {fatorial}");

            
        }
    }
}
