using System;

namespace exercises_array9
{
    class Program
    {

        static void Main(string[] args)
        {
            // 9) Отсортировать массив(пузырьком (Bubble) и почитать методы:  выбором(Select), вставками(Insert)) и попробовать отсортировать.
            try
            {
                int nums;
                Console.Write("Введите число массива :");
                nums = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[nums];
                for (int i = 0; i < nums; i++)
                {
                    Console.Write("Введите элементы :");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка!!!Вы ввели некорректные данные");
            }
            Console.ReadKey();
           









            /*
                           int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };


                           int temp;
                           for (int i = 0; i < nums.Length - 1; i++)
                           {
                               for (int j = i + 1; j < nums.Length; j++)
                               {
                                   if (nums[i] > nums[j])
                                   {
                                       temp = nums[i];
                                       nums[i] = nums[j];
                                       nums[j] = temp;
                                   }
                               }
                           }
                           Console.WriteLine("Вывод отсортированного массива");
                           for (int i = 0; i < nums.Length; i++)
                           {
                               Console.WriteLine(nums[i]);
                           }*/

        }
    }
}
