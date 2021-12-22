using System;

namespace exercises_array6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Сделать реверс массива(массив в обратном направлении).
            try
            {
                uint nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToUInt32(Console.ReadLine());
                uint[] array = new uint[nums];
                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < nums; i++)
                {
                    array[i] = Convert.ToUInt32(Console.ReadLine());
                }
                Console.WriteLine("Массив в обратном направлении:");
                for (uint i = nums - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch
            {
                Console.Write("Вы ввели некорректные данные :");
            }
            Console.ReadKey();
        }
    }
}
