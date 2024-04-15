using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество строк (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (M): ");
            int M = int.Parse(Console.ReadLine());
            


                int[,] matrix = new int[N, M];

                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {

                        matrix[i, j] = rnd.Next(-5, 5);
                    }
                }
                Console.WriteLine("Сгенерированная матрица:");
                PrintMatrix(matrix, N, M);


                int maxPositiveCountRowIndex = FindRowWithMaxPositiveElements(matrix, N, M);


                Console.WriteLine($"В строке {maxPositiveCountRowIndex + 1} количество положительных элементов наибольшее.");
                Console.ReadKey();
            
           
        }

        static int FindRowWithMaxPositiveElements(int[,] matrix, int N, int M)
        {
            int maxPositiveCount = 0;
            int maxPositiveCountRowIndex = -1;

            for (int i = 0; i < N; i++)
            {
                int positiveCount = 0;

                for (int j = 0; j < M; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positiveCount++;
                    }
                }

                if (positiveCount > maxPositiveCount)
                {
                    maxPositiveCount = positiveCount;
                    maxPositiveCountRowIndex = i;
                }
            }

            return maxPositiveCountRowIndex;
        }
        static void PrintMatrix(int[,] matrix, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
    }

