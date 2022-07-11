

// 2. Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.
namespace seminar6
{
    class Program
    {
        public static int[] FillArray(int[] array, int count)
        {
            for (int i = 0; i < count; i++)
            {
                array[i] = new Random().Next(-99, 100);
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static int[] CopyArray(int[] initialArray, int[] copyArr)
        {
            for (int i = 0; i < initialArray.Length; i++)
            {
                copyArr[i] = initialArray[i];
            }
            return copyArr;
        }
        public static void Main()
        {
            int count = new Random().Next(5, 11);
            int[] firstArray = new int[count];
            int[] secondArray = new int[count];
            FillArray(firstArray, count);
            Console.WriteLine("Исходный массив:");
            PrintArray(firstArray);
            Console.WriteLine();
            Console.WriteLine("Новый массив:");
            PrintArray(secondArray);
            Console.WriteLine();
            Console.WriteLine("Копия исходного массива:");
            PrintArray(CopyArray(firstArray, secondArray));
        }
    }
}