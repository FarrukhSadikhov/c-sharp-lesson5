using System;

namespace exercises_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Найти максимальный элемент массива.       
            try
            {
                uint nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToUInt32(Console.ReadLine());
                uint[] arr = new uint[nums];
                for (uint i = 0; i < nums; i++)
                {
                    Console.Write("Введите элементы :");
                    arr[i] = Convert.ToUInt32(Console.ReadLine());
                }
                uint max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                Console.Write($"Mаксимальный элемент массива :{max}");
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные : ");
            }
            Console.ReadKey();
        }
    }
}
