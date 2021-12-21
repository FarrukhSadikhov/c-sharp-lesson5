using System;

namespace exercises_array8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
            try
            {
                uint nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToUInt32(Console.ReadLine());
                uint[] array = new uint[nums];
                Console.WriteLine("Введите элементы массива:");
                for (uint i = 0; i < nums; i++)
                {
                    array[i] = Convert.ToUInt32(Console.ReadLine());
                }
                nums = array[nums - 1] / 2;
                if (array.Length % 2 != 0)
                {
                    nums++;
                }
                for (uint i = nums; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
                if (array.Length % 2 != 0)
                {
                    Console.Write(array[array.Length / 2]);
                }
                for (uint i = 0; i < array.Length / 2; i++)
                {
                    Console.Write(array[i]);
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
