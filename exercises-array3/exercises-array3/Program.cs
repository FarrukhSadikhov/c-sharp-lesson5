using System;

namespace exercises_array3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  3) Найти индекс минимального элемента массива.
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
                uint min = array[0];
                uint index = 0;
                for (uint i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        index = i;
                    }                  
                }
                Console.WriteLine($"Индекс минимального элемента массива :{index}");
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные :");
            }
            Console.ReadKey(); 
            }
        }
    }

