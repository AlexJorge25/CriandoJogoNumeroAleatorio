using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAleatorioGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            jogo();
            Console.ReadKey();
        }
        static void jogo()
        {
            int tentativas = 0;
            int num1 = 1;
            int num2 = 10;
            Random random = new Random();
            int numero_aleatorio = random.Next(num1, num2);
            Console.Write("Clique Enter para começar");
            Console.ReadLine();
            int jogador = 0;
            while (numero_aleatorio != jogador && tentativas < 5)
            {
                Console.WriteLine($"Digite um numero de {num1} a {num2}: ");
                jogador = int.Parse(Console.ReadLine());
                tentativas++;
                if (numero_aleatorio < jogador)
                {
                    Console.WriteLine("Jogada muito alta,tente novamente");
                   
                }
                else if(numero_aleatorio > jogador)
                {
                    Console.WriteLine("Jogada muito baixa,tente novamente");
                   
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine($"Voce ganhou\nNumero escolhido {jogador}\nComputador escolheu: {numero_aleatorio}");
        }
    }
}
