using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int primeiroNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int segundoNum = Convert.ToInt32(Console.ReadLine());

            int soma = primeiroNum + segundoNum;
            int sub = primeiroNum - segundoNum;
            int multi = primeiroNum * segundoNum;
            int divisao = primeiroNum / segundoNum;

            Console.WriteLine($"A soma entre {primeiroNum} + {segundoNum} = {soma}");
            Console.WriteLine($"A subtração entre {primeiroNum} - {segundoNum} = {sub}");
            Console.WriteLine($"A multiplicação entre {primeiroNum} X {segundoNum} = {multi}");
            Console.WriteLine($"A divisão entre {primeiroNum} / {segundoNum} = {divisao}");
        }
    }
}
