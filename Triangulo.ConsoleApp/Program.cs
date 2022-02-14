using System;
/**
 Contexto:

Triângulo é uma figura geométrica formada por três retas que se encontram duas a duas e não
passam pelo mesmo ponto, formando três lados e três ângulos.
 
Observando o triângulo podemos identificar alguns de seus elementos:
 
-> A, B e C são os vértices
-> Os lados dos triângulos são simbolizados pelo encontro dos vértices (pontos de encontros)
 
Tipos de Triângulos
 O triângulo pode ser classificado segundo a medida do seu lado:
 Triângulo escaleno: Todos os lados e ângulos são diferentes.
 Triângulo isósceles: dois lados iguais e os ângulos opostos a esses lados iguais.
 Triângulo equilátero: Todos os lados e ângulos iguais. Concluímos que seus ângulos serão de 60°.
 Condição de existência de um triângulo

 Para construir um triângulo não podemos utilizar qualquer medida, tem que seguir a condição de
existência:
 
Para construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a
soma dos outros dois lados.

Questão

a) Crie uma aplicação Console Application que receba três valores X, Y, Z, escrever uma mensagem
informando se é um triângulo eqüilátero, isósceles ou escaleno. Abaixo segue as possibilidades possíveis:
• Eqüilátero: Todos os lados iguais
• Isósceles: Dois lados iguais
• Escaleno: Todos os lados diferentes

b) Caso algum comprimento dos lados do triângulo for inválido, escrever a mensagem “Triângulo
Inválido”

c) O usuário poderá verificar vários triângulos, ou seja, crie um menu de opções que possibilite isso.
 
 */
namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando = "";
            do
            {
                Console.Write("Digite o valor do lado A: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do lado B: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do lado C: ");
                double z = double.Parse(Console.ReadLine());

                if (x + y < z || x + z < y || y + z < x)
                {
                    Console.WriteLine("\nTriângulo Inválido");
                }
                else if (x == y && x == z)
                {
                    Console.WriteLine("\nÉ um triângulo Eqüilátero: Todos os lados iguais.");
                }
                else if ((x == y || y == z || z == x))
                {
                    Console.WriteLine("\nÉ um triângulo Isósceles: Dois lados iguais.");
                }
                else
                {
                    Console.WriteLine("\nÉ um triângulo Escaleno: Todos os lados diferentes.");
                }

                Console.WriteLine("\nDigite 1 para verificar o Tipo do Triângulo\nDigite s para sair");
                comando = Console.ReadLine();
            } while (comando != "s");

        }
    }
}
