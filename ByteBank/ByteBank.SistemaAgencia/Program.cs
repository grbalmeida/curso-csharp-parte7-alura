using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int indice = 4;
            int idadeNoIndice4 = idades[indice];

            Console.WriteLine(idadeNoIndice4);

            Console.ReadLine();
        }
    }
}
