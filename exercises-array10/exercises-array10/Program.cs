using System;

namespace exercises_array10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10) Заполнить массив из 20 элементов числами Фибоначчи и вывести его
            на экран(Fk = Fk - 1 + Fk - 2). Первые два числа - 0, 1.*/
            int[] fibonaci = new int[20];
            fibonaci[0] = 0;
            fibonaci[1] = 1;
            for (int i = 2; i < fibonaci.Length; i++)
            {
                fibonaci[i] = fibonaci[ i - 1 ] + fibonaci[ i - 2 ];
                Console.WriteLine(fibonaci[i]);
            }           
            Console.ReadKey();
        }
    }
}
