using System;

namespace GrupoIII
{
    public class Exercicio3
    {

        public static void ApresentarTabela()
        {
            int lines,
                columns;
            char c;

            do
            {
                Console.Write("\nQuantas linhas:\t");
            } while (!int.TryParse(Console.ReadLine(), out lines));

            do
            {
                Console.Write("\nQuantas colunas:\t");
            } while (!int.TryParse(Console.ReadLine(), out columns));

            Console.Write("\nQual o caracter:\t");
            c = Console.ReadKey().KeyChar;

            Console.WriteLine("\n\n");

            for(int i = 0; i < lines; i++)
            {
                for (int x = 0; x < columns; x++)
                    Console.Write(c + " ");
                Console.WriteLine();
            }
        }

        public static void MultiploDeTresESete(int num)
        {
            if ((num % 3 == 0) && (num % 7 == 0))
            {
                Console.WriteLine("Múltiplo de 3 e 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Múltiplo de 3");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Múltiplo de 7");
            }
            else
            {
                Console.WriteLine("Nem múltiplo de 3 nem de 7");
            }
        }

        public static void Fatorial()
        {
            int num;

            do
            {
                Console.WriteLine("Qual o número:\t");
            } while (!int.TryParse(Console.ReadLine(), out num));

            Console.Clear();
            Console.Write($"{num}! = {num} X ");

            for(int i = (num - 1); i >= 1; i--)
            {
                num *= i;
                if (i != 1)
                    Console.Write($"{i} X ");
                else
                    Console.Write($"{i} = {num}");
            }
        }

    }
}