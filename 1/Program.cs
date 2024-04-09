using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа удвоения чисел массива.\n");
            Console.WriteLine("Вводите элементы массива, 0 чтобы закончить: ");
            List <int> x = new List<int>();
            int temp;
            do
            {
                temp = Convert.ToInt32(Console.ReadLine());
                x.Add(temp);
            }
            while (temp != 0);
            Console.WriteLine("\nВывод получившегося массива: ");
            for (int i = 0; i < x.Count - 1; i++)
            {
                Console.Write(x[i] * 2 + " ");

            }
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
