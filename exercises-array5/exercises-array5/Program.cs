using System;

namespace exercises_array5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Посчитать сумму элементов массива с нечетными индексами.
            try
            {
                uint nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToUInt32(Console.ReadLine());
                uint[] array = new uint[nums];               
                for (int i = 0; i < nums; i++)
                {
                    Console.Write("Введите элементы :");
                    array[i] = Convert.ToUInt32(Console.ReadLine());
                }
                uint sum = 0;
                for (uint i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum = sum + array[i];
                    }
                }
                Console.WriteLine($"сумма элементов массива с нечетными индексами = {sum}");
                Console.ReadKey();
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные :");
            }
            Console.ReadKey();
        }
    }
}
