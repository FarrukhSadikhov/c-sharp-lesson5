using System;

namespace exercises_array7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7) Посчитать количество нечетных элементов массива.
            try
            {
                uint nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToUInt32(Console.ReadLine());
                uint[] array = new uint[nums];
                Console.WriteLine("Введите элементы массива :");
                for (int i = 0; i < nums; i++)
                {
                    array[i] = Convert.ToUInt32(Console.ReadLine());
                }
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"количество нечетных элементов массива= {count}");
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные :");
            }          
            Console.ReadKey();
        }
    }
}
