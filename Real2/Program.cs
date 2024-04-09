using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа прикола :3\n");
            Console.WriteLine("Вводите элементы массива, 0 чтобы закончить: ");
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int temp;
            do
            {
                temp = Convert.ToInt32(Console.ReadLine());
                a.Add(temp*2);
                b.Add(temp);
            }
            while (temp != 0);
            a.Remove(0);
            b.Remove(0);
            ArrayList main = new ArrayList();
            main.AddRange(a);
            main.AddRange(b);
            main.Sort();
            main.Reverse();
            Console.Write("Вывод получившегося Array list'а:\n");
            for (int i = 0; i < main.Count; i++)
            {
                Console.WriteLine(main[i]);
            }
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
