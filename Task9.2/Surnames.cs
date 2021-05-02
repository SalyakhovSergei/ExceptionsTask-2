using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._2
{
    public class Surnames
    {
        public delegate void myDelegate(List<string> list);
        public event myDelegate MyEvent;

        Exception myException = new Exception("Неверный ввод");

        public void SortSurNames(List <string> lastNames)
        {
            byte i = Convert.ToByte(Console.ReadLine());

            if (i != 1 && i != 2) throw myException;

            switch (i)
            {
                case 1:
                    lastNames.Sort();

                    Console.WriteLine();
                    Console.WriteLine("Отсортированный список от А до Я");

                    foreach (string s in lastNames)
                    {
                        Console.WriteLine(s);
                    }
                    break;

                case 2:
                    lastNames.Sort();
                    lastNames.Reverse();

                    Console.WriteLine();
                    Console.WriteLine("Отсортированный список от Я до А");

                    foreach (string s in lastNames)
                    {
                        Console.WriteLine(s);
                    }
                    break;
            }

            SurnamesCheck(lastNames);
        }
        protected virtual void SurnamesCheck(List<string> list)
        {
            MyEvent?.Invoke(list);
        }
    }
}
