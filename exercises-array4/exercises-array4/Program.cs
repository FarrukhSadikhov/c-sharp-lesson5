using System;

namespace exercises_array4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Найти индекс максимального элемента массива.
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
                uint max = array[0];
                uint index = 0;
                for (uint i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        index = i;
                    }
                }
                Console.WriteLine($"Индекс максимального элемента массива :{index}");
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные :");
            }
            Console.ReadKey();
        }






        /*try
        {
            int[] array = { 5, 8, 4, 7, 8, 9 };

            int max = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)

                if (max < array[i])
                {
                    index = i;
                }
            Console.WriteLine($"Индекс минимального элемента массива :{index}");
        }
        catch
        {
            Console.Write("Вы ввели некорректные данные :");
        }

        Console.ReadKey();
    }*/
    }
}
