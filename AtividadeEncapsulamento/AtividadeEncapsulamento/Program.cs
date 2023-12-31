﻿using System;
using System.Globalization;

    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;

            Console.WriteLine("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
