/* ***********************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 26/03/2022
 * Autores do Projeto: Henrique Curtis Correa Marques
 *                     Arthur Kinderman Peres de Oliveira
 * Turma: 2F
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * projeto.cs
 * ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // criação de variavel:
            float mediamenor25 = 0;
            float salariomenor25 = 0;
            int pessoas_maior25 = 0;
            float salario_25 = 0;
            float media_25 = 0;
            int pessoas_sup500 = 0;
            float diferenca_menor25 = 0;
            int pessoas_menor25 = 0;
            int idade_mediamedio = 0;
            int desejo = 0;
            int aux_sup = 0;
            int acima_mediasup = 0;
            int pessoas_total = 0;
            int pessoas_primario = 0;
            int pessoas_medio = 0;
            int pessoas_sup = 0;
            int pessoas25 = 0;
            int resp;
            float aux = 0;
            float maior = 0;
            float menor = 0;
            float salario_sup = 0;
            float salario_sup500 = 0;
            float salario_menor25 = 0;
            float media_sup = 0;
            float media_sup500 = 0;
            float diferenca_25 = 0;
            float media_menor25 = 0;
            float media_medio = 0;
            int salario_medio = 0;
            int idade_media = 0;
            int idade_mediasup = 0;
            float percentual_primario = 0;
            int idade_sup = 0;
            float percentual_sup = 0;
            // inicialização do programa:
            Console.WriteLine("Deseja iniciar o programa? (1-SIM/2-NÃO) \n");
            int iniciar = int.Parse(Console.ReadLine());
            while (iniciar != 1 && iniciar != 2)
            {
                Console.WriteLine("ERRO!, digite um valor valido:");
                iniciar = int.Parse(Console.ReadLine());
            }
            if (iniciar == 1)
            {

                while (iniciar == 1)
                {
                    Console.WriteLine("Digite o valor do seu salario: \n");
                    float salario = float.Parse(Console.ReadLine());
                    maior = salario;

                    while (salario < 1)
                    {
                        Console.WriteLine("Digite um valor valido: \n");
                        salario = float.Parse(Console.ReadLine());

                    }
                    
                    
                    if (salario > maior)
                    {
                        maior = salario;
                    }
                    
                    if (salario < menor)
                    {
                        menor = salario;
                    }
                    Console.WriteLine("Digite sua idade: \n");
                    int idade = int.Parse(Console.ReadLine());
                    while (idade < 1 || idade > 70)
                    {
                        Console.WriteLine("Digite um valor valido: \n");
                        idade = int.Parse(Console.ReadLine());
                    }
                    if (idade >= 25)
                    {
                        salario_25 = salario_25 + salario;
                    }
                    if (idade < 25)
                    {
                        salario_menor25 = salario_menor25 + salario;
                    }
                    Console.WriteLine("====================");
                    Console.WriteLine("(1) PRIMARIO");
                    Console.WriteLine("(2) MEDIO");
                    Console.WriteLine("(3) SUPERIOR");
                    Console.WriteLine("====================");
                    resp = int.Parse(Console.ReadLine());
                    while (resp < 1 || resp > 3)
                    {
                        Console.WriteLine("Digite um valor valido: \n");
                        resp = int.Parse(Console.ReadLine());
                    }
                    switch (resp)
                    {
                        case 1:
                            pessoas_total++;
                            pessoas_primario++;

                            break;

                        case 2:
                            idade_mediamedio = idade_mediamedio + idade;
                            pessoas_total++;
                            pessoas_medio++;
                            salario_medio++;

                            break;

                        case 3:
                            pessoas_total++;
                            pessoas_medio++;
                            pessoas_sup++;
                            idade_mediasup = idade / pessoas_sup;
                            break;

                    }
                    if (resp == 3 && salario <= 500)
                    {
                        pessoas_sup500++;
                        media_sup500 = salario_sup500 / pessoas_sup500;
                        media_sup = salario / pessoas_sup;

                    }
                    if (resp == 2 && idade < 25)
                    {
                        media_menor25 = salario_menor25 / pessoas_medio;
                        media_medio = salario_medio / pessoas_medio;

                    }
                    if (idade >= 25)
                    {
                        pessoas_maior25++;
                        salario_25 = salario_25 + salario;
                        media_25 = salario_25 / pessoas_maior25;

                    }
                    if (idade < 25)
                    {
                        pessoas_menor25++;
                        salariomenor25 = salario_menor25 + salario;
                        mediamenor25 = salariomenor25 / pessoas_menor25;

                    }


                    Console.WriteLine("Deseja continuar: (1-SIM/2-NÃ0) \n");
                    desejo = int.Parse(Console.ReadLine());
                    while (desejo != 1 && desejo != 2)
                    {
                        Console.WriteLine("Digite um valor valido: \n");
                        desejo = int.Parse(Console.ReadLine());
                    }
                    percentual_sup = (pessoas_sup * 100) / pessoas_total;
                    percentual_primario = (pessoas_primario * 100) / pessoas_total;
                    idade_media = idade_mediamedio / pessoas_medio;
                    diferenca_25 = media_sup - media_25;
                    diferenca_menor25 = media_medio - mediamenor25;
                    if (desejo == 2)
                    {
                        Console.WriteLine("====================================================================================");
                        Console.WriteLine("Número de pessoas que possuem curso superior e ganham menos que 500 reais e de: " + pessoas_sup500.ToString("0.00"));
                        Console.WriteLine("A diferença entre a média dos salários das pessoas com mais de 25 anos e de: " + diferenca_25.ToString("0.00"));
                        Console.WriteLine("A diferença entre média dos salários com menos de 25 anos e de: " + diferenca_menor25.ToString("0.00"));
                        Console.WriteLine("A idade média das pessoas que possuem 2o grau e de: " + idade_media.ToString("0.00"));
                        Console.WriteLine("O percentual de pessoas que possuem o curso Primário e de: " + percentual_primario.ToString("0.00"));
                        Console.WriteLine("O percentual de pessoas que possuem curso superior e de: " + percentual_sup.ToString("0.00"));
                        Console.WriteLine("A idade média das pessoas com nível superior e de: " + idade_mediasup.ToString("0.00"));
                        Console.WriteLine("O maior salário informado e de: " + maior.ToString("0.00"));
                        Console.WriteLine("O menor salário informado e de: " + menor.ToString("0.00"));
                        Console.WriteLine("====================================================================================");
                        Console.WriteLine("FIM DO PROGRAMA!");
                        break;
                    }







                }
            }
            if (iniciar == 2)
            {
                Console.WriteLine("FIM DO PROGRAMA!");

            }


            Console.Read();
        }

    }

}