using System;

namespace DesafioFdevs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio 1
            Console.WriteLine("---------------------------------------------------------------------\n");
            Console.WriteLine("Desafio FDEVS 1)\n");

            int soma = 0;
            for (int i = 0; i <= 10; i++)
            {
                soma += i;
            }

            Console.WriteLine("A soma de 1 até 10 é: " + soma);


            // Desafio 2
            Console.WriteLine("\n---------------------------------------------------------------------\n");
            Console.WriteLine("Desafio FDEVS 2)\n");

            Console.Write("Digite sua altura em metros: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu peso em kg: ");
            var peso = Convert.ToDouble(Console.ReadLine());

            var imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Você está no peso ideal!");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Você está com obesidade grau I.");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Você está com obesidade grau II.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau III.");
            }


            // Desafio 3
            Console.WriteLine("\n\n---------------------------------------------------------------------\n");
            Console.WriteLine("Desafio FDEVS 3)\n");

            Console.Write("Digite o primeiro número: ");
            var num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o operador desejado:\n");
            Console.WriteLine(" Adição: +");
            Console.WriteLine(" Subtração: -");
            Console.WriteLine(" Multiplicação: *");
            Console.WriteLine(" Divisão: /\n");
            Console.Write("Operador: ");
            var operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"A soma entre {num1} + {num2} é: {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"A subtração entre {num1} - {num2} é: {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"A multiplicação entre {num1} x {num2} é: {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"A divisão entre {num1} / {num2} é: {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Operador não é válido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
