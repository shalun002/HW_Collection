﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ///* 1. Создать коллекцию List <int> . Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции. Вывести на экран сумму элементов на четных позициях. */
            ///* 2.	Удалить все нечетные элементы списка List<int> */
            ///
            //List<int> dc = new List<int>();
            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    dc.Add(rand.Next(1, 20));
            //}
            //dc = dc.OrderBy(d => d).ToList();
            //Console.WriteLine(dc[dc.Count - 1]);

            //int summ = 0;
            //for (int i = 0; i < dc.Count; i += 2)
            //{
            //    Console.WriteLine("Elements\t" + dc[i]);
            //    summ += dc[i];
            //    dc.Remove(i);
            //}
            //Console.WriteLine("Summ\t" + summ);
            #endregion

            #region
            // 3.Дана коллекция типа List<double>.Вывести на экран элементы списка, значение которых больше среднего арифметического всех элементов коллекции.

            //double avgTask3 = 0;
            //List<int> gq = new List<int>();
            //Random rand = new Random();

            //for (int i = 0; i < gq.Count; i += 2)
            //{
            //    gq.Add(rand.Next(1, 100));
            //}
            //avgTask3 = gq.Sum(d => d) / gq.Count;
            //Console.WriteLine("Sum\t" + avgTask3);
            //foreach (var item in gq)
            //    if (item > avgTask3)
            //        Console.WriteLine("Value more than avg\t" + item);

            //foreach (var item in gq.Where(o => o > avgTask3))
            //        Console.WriteLine("Value more than avg\t" + item);
            #endregion

            #region
            ///* 4. Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке. */

            //string str = "sdfsdfsdf";
            //List<char> xx = str.ToList();
            //xx.Reverse();
            //foreach (var item in xx)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            #endregion

            #region

            // 5. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.

            //string s1 = "top";
            //string s2 = "pot";
            //string s3 = "";
            //foreach (char item in s1.Reverse())
            //    s3 += item;

            //if (s3 == s2)
            //    Console.WriteLine("Vectory");

            #endregion

            #region

            ///*6. Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все слова, 
            //     начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву, сохраняя исходный порядок в каждой группе слов.*/

            //string text = "Be or not to be is a question";
            //List<string> Alen = new List<string>();
            //Alen = text.Split(' ').ToList();
            //string bookva = "aoieu";
            //foreach (var item in Alen)
            //{
            //    if (bookva.Contains(item[0]))
            //        Console.Write(item);
            //}
            //Console.WriteLine();

            //foreach (var item in Alen)
            //{
            //    if (!bookva.Contains(item[0]))
            //        Console.Write(item);
            //}
            //Console.WriteLine();

            #endregion
        }
    }
}