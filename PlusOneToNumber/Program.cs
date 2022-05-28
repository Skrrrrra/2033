using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlusOneToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2033\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2033\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            int a;
            using (var readera = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(readera.ReadLine());  // записываем в переменную
            };
            //переменная для обьвления размера массива#2
            int b;
            using (var readerb = new StreamReader(inputpath))
            {
                readerb.ReadLine(); //пропуск 1 строки
                readerb.ReadLine(); //пропуск 2 строки
                b = Convert.ToInt32(readerb.ReadLine());  // записываем в переменную 3 строку
            };

            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine(); //пропуск 1 строки
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            string[] secondlineforint = secondLine.Split(' ');

            //создание массивов куда будут записываться числа
            int[] A;
            A = new int[a];

            //запись элементов в А
            int count = 0;
            foreach (var s in secondlineforint)
            {
                if (count <= a)
                {
                    A[count] = Convert.ToInt32(s);
                    count++;
                }
            }

            string firstnumber = "";
            for (int i = 0; i < A.Length; i++)
            {
                firstnumber = firstnumber + A[i];
            }

            int first = Convert.ToInt32(firstnumber);


            string[] B;
            B = new string[a];

            //Само заданиe)))))
            first++; ;

            string result = Convert.ToString(first);
            int counter = 0;

            foreach (var s in result)
            {
                B[counter] = Convert.ToString(s);
                counter++;
            }




            //вывод
            string outputstring = "";
            for (int i = 0; i < a; i++)
            {
                outputstring = outputstring + B[i] + ' ';
            }
            File.WriteAllText(outputpath, outputstring);


           


        }


    }
}
