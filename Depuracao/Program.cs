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

        static float Dividir(int n, float d)
        {
            return n % d;
        }

        static void Main(string[] args)
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("o numero escolhido e: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("o numero modificado e: {0}", numero);
            float denominador = 0;
            denominador = float.Parse(Console.ReadLine());
            if (denominador == 0)
            {
                Console.WriteLine("numero nao pode ser dividido por 0");
            }
            else
            {
                Console.WriteLine("o quociente entre {0} e {1} é : {2}", numero, denominador, Dividir(numero, denominador));
 
            }
           
            
            Console.Read();
            

        }
    }
}
