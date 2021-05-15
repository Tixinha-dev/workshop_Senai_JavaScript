using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina_do_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
        Volta:
            try
            {
                Console.Clear();
                Console.WriteLine("Informe o primeiro numero");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma operação abaixo: \n Adição (+) \n Subtração (-) \n Divisão (/) \n Multiplicação (x)");
                string operacao = Console.ReadLine();
                Console.WriteLine("Informe o Segundo numero");
                int numero2 = int.Parse(Console.ReadLine());
                int resultado = 0;



                switch (operacao)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;

                }


                Console.WriteLine("o resultado é = " + resultado);
                Console.ReadKey();
            }
            catch (Exception Erro)
            {
                Console.WriteLine("Houve um erro! "+Erro);
                Console.ReadKey();
            }
            goto Volta;
        }
    }
}