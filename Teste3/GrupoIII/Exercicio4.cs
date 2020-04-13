using System;

namespace GrupoIII
{
    public class Exercicio4
    {
        
        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if(op != '+' && op != '-' && op != '*' && op != '/' && op != '%' ) throw new InvalidOperationException();
            if (op == '/'  && b == 0) throw new DivideByZeroException();
            if(a<0 || a > 100 || b<0 || b >100) throw new ArgumentOutOfRangeException();
            if(a%5==0 || b%3==0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {
           
            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }

        /*public static void Calculadora()
        {
            int num1,
                num2;
            char op;

            Console.Write("\nPrimeiro Número:\t");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nSegundo Número:\t");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("\nOperação:\t");
            op = Console.ReadKey().KeyChar;

            switch (op)
            {
                case '+':
                    Console.WriteLine($"\n\n{num1} + {num2} == {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"\n\n{num1} - {num2} == {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"\n\n{num1} x {num2} == {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"\n\n{num1} / {num2} == {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"\n\n{num1} % {num2} == {num1 % num2}");
                    break;
                default:
                    break;
            }

        }*/

        public static void Calculadora()
        {
            int num1=0,
                num2=0;
            string op = string.Empty;


            try
            {
                Console.Write("\nPrimeiro Número:\t");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("\nSegundo Número:\t");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("\nOperação:\t");
                op = Console.ReadLine();

                ValidarInput(num1, num2, op);

            }
            catch (InvalidOperationException i){
                Console.WriteLine("O operador não é reconhecido.");
            }catch (DivideByZeroException d) {
                Console.WriteLine("Ocorreu uma tentativa de divisão por 0. ");
            }catch(ArgumentOutOfRangeException a) {
                Console.WriteLine("Um dos valores introduzidos não se encontra entre 0 e 100. ");
            }catch(ArithmeticException e) {
                Console.WriteLine("O primeiro número é divisivel por 5 ou o segundo número é divisivel por 3. ");
            }


            switch (op)
            {
                case "+":
                    Console.WriteLine($"\n\n{num1} + {num2} == {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"\n\n{num1} - {num2} == {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"\n\n{num1} x {num2} == {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"\n\n{num1} / {num2} == {num1 / num2}");
                    break;
                case "%":
                    Console.WriteLine($"\n\n{num1} % {num2} == {num1 % num2}");
                    break;
                default:
                    break;
            }

            Console.ReadKey();

           

        }


    }
}
