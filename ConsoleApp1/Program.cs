using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
 

        static void Main(string[] args)
        {
           
            Console.Write("Столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] A = new int[x, y];
            Console.WriteLine();

            Console.WriteLine("Заполни матрицу");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write( A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i=0;i<x;i++)
            {
                 for(int j=0;j<x;j++)
                 sum+=A[i,j];
                    Console.WriteLine("Сумма равна" + sum + " ");
            }  





        }
    }

    
}
    
