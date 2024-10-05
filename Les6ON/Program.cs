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
            /* Убрать!

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
                        str = str + tmp;
                        str += arrCh1[i];
                    }
                    //arrCh2[i] = arrCh1[i];
                }
                else 
                {
                    if (tmp != 1)
                    {
                        str = str + tmp;
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

            убрать!
            */

            /*
             Задача #2 Дана матрица целых чисел int[,] matrix размером MхN. Вернуть все её элементы,
            развёрнутые в массив в спиральном порядке против часовой стрелки.
            Пример 1: Входной параметр: int[,] matrix = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
            Результирующий массив: [1,4,7,8,9,6,3,2,5] 
            Пример 2: Входной параметр: int[,] matrix = new int[3,4]{{1,2,3,4},{5,6,7,8},{9,10,11,12}};
            Результирующий массив: [1,5,9,10,11,12,8,4,3,2,6,7]
             */
            const int rows = 4;
            
            const int cols = 3;
                        
            int[,] matrix = new int[rows, cols];
            int[] arr = new int[rows*cols];
            //{ 
            //   { 1,  2,  3 },
            //   { 4,  5,  6 },
            //   { 7,  8,  9 },
            //   { 10, 11, 12 }          
            // };
            int tmp = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tmp++;
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            tmp = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    if (j == 0 )
                    {
                        Console.WriteLine(matrix[i,j]);
                        arr[tmp] = matrix[i,j];
                        tmp++;
                    }
                                                              
                }
            }
            Console.WriteLine();
            Console.Write(matrix[0,0]+" " + matrix[1,0]+ " " + matrix[2,0]+ " " + matrix[3,0]
                + " " + matrix[3,1]+ " "+ matrix[3,2] + " "+ matrix[2,2]+ " "+ matrix[1,2]+ " "+ matrix[0,2] +
                " "+ matrix[0,1]);

            Console.WriteLine();

        }
    }
}
    

