using System;

namespace exercises_array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Найти минимальный элемент массива.
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
                uint min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }                  
                }
                Console.Write($"Mинимальный элемент массива :{min}");
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные : ");
            }
            Console.ReadKey();

        }
    }
}


