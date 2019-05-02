using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matr = new int[n, c];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    matr[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(matr[i,j]== numero)
                    {
                        Console.WriteLine("posição: " + i +", "+ j);
                        if (j > 0)
                        {
                            Console.WriteLine("Numero a esquerda: "+ matr[i,j-1]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Numero a Direita: "+ matr[i,j + 1]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Numero acima: " + matr[i -1,j]);
                        }
                        if (i < c - 1)
                        {
                            Console.WriteLine("Numero abaixo: "+ matr[i + 1,j]);
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
