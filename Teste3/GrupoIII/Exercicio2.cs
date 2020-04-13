using System;

namespace GrupoIII
{
    public class Exercicio2
    {

        public static void OlaPessoa(string name)
        {
            Console.WriteLine($"Olá {name}");
        }

        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            return (vacas * 4) + (porcos * 4) + (galinhas * 2);
        }

        public static string ParOuImpar(int num)
        {
            if (num % 2 == 0)
                return ($"{num} é Par");
            
            return ($"{num} é Impar");
        }

        public static void Somar(int num1, int num2)
        {
            if (num1 == num2)
                Console.WriteLine(3 * (num1 + num2));
            else
                Console.WriteLine(num1 + num2);
        }

        public static int Potencia(int num1, int num2)
        {
            int total = num1;
            for(int i = 1; i < num2; i++)
            {
                total *= num1;
            }
            return total;
        }
    }
}
