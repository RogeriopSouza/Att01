using Exercicio01R;
using System;

namespace Exercicio01R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            while (opcao != "X")
            {
                Console.WriteLine("1 - Tarefa 1: Soma de dois Números e Comparação com o 3°");
                Console.WriteLine("2 - Tarefa 2: Informações Pessoais - Nome, Gênero e Estado Civil");
                Console.WriteLine("3 - Tarefa 3: Verificar se um número é Par ou Ímpar");
                Console.WriteLine("4 - Tarefa 4: Ler dois valores inteiros A e B. Se forem idênticos, some-os; caso contrário, multiplique A por B.");
                Console.WriteLine("5 - Tarefa 5: Determinar o dobro de um número positivo ou o triplo se for negativo.");
                Console.WriteLine("6 - Tarefa 6: Verificar se dois valores booleanos são AMBOS verdadeiros ou FALSOS.");
                Console.WriteLine("7 - Tarefa 7: Ler uma variável e adicionar 5 se for par ou 8 se for ímpar.");
                Console.WriteLine("8 - Tarefa 8: Ler três valores inteiros distintos e exibi-los em ordem decrescente.");
                Console.WriteLine("9 - Tarefa 9: Calcular o peso ideal com base na altura e no sexo.");
                Console.WriteLine("10 - Tarefa 10: Calcular o IMC e avaliar a condição de peso.");
                Console.WriteLine("11 - Tarefa 11: Calcular o valor a ser pago por um produto com base na forma de pagamento.");
                Console.WriteLine("12 - Tarefa 12: Calcular a média de desempenho de um aluno e determinar conceito e situação.");
                Console.WriteLine("X - Fechar o Programa");
                Console.Write("Digite o número da tarefa desejada: ");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Atividade01.Executar();
                        break;
                    case "2":
                        Atividade02.Executar();
                        break;
                    case "3":
                        Atividade03.Executar();
                        break;
                    case "4":
                        Atividade04.Executar();
                        break;
                    case "5":
                        Atividade05.Executar();
                        break;
                    case "6":
                        Atividade06.Executar();
                        break;
                    case "7":
                        Atividade07.Executar();
                        break;
                    case "8":
                        Atividade08.Executar();
                        break;
                    case "9":
                        Atividade09.Executar();
                        break;
                    case "10":
                        Atividade10.Executar();
                        break;
                    case "11":
                        Atividade11.Executar();
                        break;
                    case "12":
                        Atividade12.Executar();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
