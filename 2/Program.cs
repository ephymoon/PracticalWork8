using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа нахождения наибольшего модуля массива.\n");
            Console.WriteLine("Вводите элементы массива, 0 чтобы закончить: ");
            List<int> x = new List<int>();
            int temp;
            do
            {
                temp = Convert.ToInt32(Console.ReadLine());
                x.Add(temp);
            }
            while (temp != 0);
            int max = 0;
            int iter = 0;
            for (int i = 0; i < x.Count - 1; i++)
            {
                if (Math.Abs(x[i]) > max)
                {
                    iter = i;
                    max = Math.Abs(x[i]);
                }
            }
            Console.Write("Максимальное число в массиве по модулю: " + max);
            Console.Write("\nЕго индекс:" + iter);
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
