using System.Reflection.Metadata.Ecma335;

namespace questions_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5, 7, 8, 10, 90 };
            Console.WriteLine("Write a method that takes an integer array  as an input and sorts it. It's a one dimesional array");
            Console.WriteLine(searchNumber(arr, 6));
            int[] arr2 = { 4, 7, 3, 5, 1, 10, 90, 8 };
            Console.WriteLine("Write a sorted array");
            //Console.WriteLine(sortArray(arr2));
            int[] sortedArray= sortArray(arr2);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]+" ");
            }
        }

        static int[] sortArray(int [] array)
        {
            //int [] array = { 4, 7, 3, 5, 1, 10, 90, 8};
            //int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j=0; j<array.Length;j++)
                {
                    if (array[j] < array[i])
                    { 
                        int sort = array[i];
                        array[i] = array[j];
                        array[j] = sort;   
                    }
                }
            }
            return array;
        }   

        static int searchNumber(int[] array ,int number)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                if (number == array[i])
                {
                    return i;
                }

            }
            return -1;
        }



    }
}