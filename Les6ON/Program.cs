using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6ON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Убрать!

            Console.Write("\tВведите строку: ");
            string str = Console.ReadLine();
            
            char[] arrCh1 = str.ToCharArray();

            //char[] arrCh2 = new char[str.Length];
            
            //Console.WriteLine("str1.Length = " + str.Length + "\n");

            for (int i = 0; i < arrCh1.Length; i++)
            {
                for (int j = 0; j < arrCh1.Length - 1 - i; j++)
                {
                    if (arrCh1[j] > arrCh1[j+1])
                    {
                        char chTemp = arrCh1[j];
                        arrCh1[j] = arrCh1[j+1];
                        arrCh1[j+1] = chTemp;
                    }
                }
            }
            Console.Write("\tОтсортированная строка: ");
            for (int i = 0;i < arrCh1.Length;i++)
            {
                Console.Write(arrCh1[i]);
            }
            //str1 = Convert.ToString(arrCh1);

            //Console.WriteLine("\nString--------\n\n");

           // for (int i = 0; i < str1.Length; i++)
            //{
               // Console.Write(str1[i]);
            //}

            Console.WriteLine();

            str = null;
            
            int tmp = 1;

            //Console.WriteLine();
            //str2 = Convert.ToString(arrCh1) + "S";
            //arrCh1 = str2.ToCharArray();
            //str2 = null;
            for (int i = 0; i < arrCh1.Length - 1;i ++)
            {
                if (arrCh1[i] == arrCh1[i + 1])
                {
                    
                    tmp++;
                    if(i == arrCh1.Length - 2)
                    {
                        str += tmp;
                        str += arrCh1[i];
                    }
                    //arrCh2[i] = arrCh1[i];
                }
                else 
                {
                    if (tmp != 1)
                    {
                        str += tmp;
                        str += arrCh1[i];
                        tmp = 1;
                    }
                    else
                    {
                        str += arrCh1[i];
                        tmp = 1;
                    }

                }
            }
            
            Console.Write("\tИтоговая строка: " + str);
            Console.WriteLine("\n\n\n\n\n");

            //убрать!


            /*
             Задача #2 Дана матрица целых чисел int[,] matrix размером MхN. Вернуть все её элементы,
            развёрнутые в массив в спиральном порядке против часовой стрелки.
            Пример 1: Входной параметр: int[,] matrix = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
            Результирующий массив: [1,4,7,8,9,6,3,2,5] 
            Пример 2: Входной параметр: int[,] matrix = new int[3,4]{{1,2,3,4},{5,6,7,8},{9,10,11,12}};
            Результирующий массив: [1,5,9,10,11,12,8,4,3,2,6,7]
             */

            const int n = 6;
            const int m = 8;
            int[,] matrix = new int[n, m];

            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = m;
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0)
                {
                    visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }

                col += dx;
                row += dy;
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
    

