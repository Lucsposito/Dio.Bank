using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    class Program
    {
        static List<Conta>listConta = new List<Conta>();

        static void Main(string[] args)
        {
            
            string opcaoUsuario = obterOpcaoUsuario();

            while(opcaoUsuario.ToUpper()!= "x"){
                switch (opcaoUsuario){
                    case "1":
                    ListarContas();
                    break;

                    case "2":
                    InserirConta();
                    break;

                    case "3":
                    Transferir();
                    break;

                    case "4":
                    Sacar();
                    break;

                    case "5":
                    depositar();
                    break;

                    case "c":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();                    
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void depositar()
        {
            Console.Write("Digite o número da conta: ");
            int IndiceConta=int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listConta[IndiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int IndiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque= double.Parse(Console.ReadLine());

            listConta[IndiceConta].Sacar(valorSaque);

        }

        private static void Transferir()
        {
            Console.Write(" Digite o número da conta de origem: ");
            int IndiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int IndiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valortransferencia = double.Parse(Console.ReadLine());

            listConta[IndiceContaOrigem]. Tranferir(valortransferencia, listConta[IndiceContaDestino]); 
        }

        private static void ListarContas()
        {
            Console.WriteLine(" Listar Contas ");
            if (listConta.Count == 0)
            {
                Console.WriteLine(" Nenhuma conta cadastrada.");
                return;
            }
            for (int i=0; i<listConta.Count; i++){
                Conta conta = listConta[i];
                Console.Write(" # {0} -", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            Console.Write("Digite 1 para conta física e 2 para jurídica: ");

            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta NovaConta = new Conta(tipoConta:(TipoConta) entradaTipoConta, saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);
            listConta.Add(NovaConta);
        }

        private static string obterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada.");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("c - Limpar tela");
            Console.WriteLine("x - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;


        }
    }
}
