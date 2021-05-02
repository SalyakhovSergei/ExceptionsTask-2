using System;
using System.Collections.Generic;
using System.IO;

namespace Task9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Surnames srn = new Surnames();
           
            srn.MyEvent += srn.SortSurNames;

            Console.WriteLine("Введите 5 фамилий для сотрировки");

            List<string> lastNames1 = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                lastNames1.Add(Console.ReadLine());
            }
            
            Console.WriteLine("Если необходимо отсортировать от А до Я введите 1");
            Console.WriteLine("Если необходимо отсортировать от Я до А введите 2");

            try
            {
                srn.SortSurNames(lastNames1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
