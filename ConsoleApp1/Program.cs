using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Menu {Soma = 1, Subtracao, Divisao, Multiplicao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, Selecione uma das opções:");
                Console.WriteLine("1-soma\n2-Subrtracao\n3-Divião\n4-Multiplicao\n5-Potencia\n6-Raiz\n7-Sair");
                /*
                String opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
                */

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                            break;
                }
                
                Console.Clear();
            }

           
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o priemeiro Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o priemeiro Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o priemeiro Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o priemeiro Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de um numeros: ");
            Console.WriteLine("Digite a Base: ");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(basenum, expo);
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite a Base: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é:{resultado} ");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
