using System;
using System.Collections.Generic;
using System.Text;

namespace Depuracao
{
    class Program
    {
        static int Mudar(int n)
        {
            n = n + 1;
            return n;
        }
        static void Main(string[] args)
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("o numero escolhido e: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("o numero modificado e: {0}", numero);
            Console.Read();
            

        }
    }
}
