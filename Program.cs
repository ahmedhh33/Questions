namespace questions_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5, 7, 8, 10, 90 };
            Console.WriteLine(searchNumber(arr, 6));
        }

        //public void sortArray()
        //{
        //    int [] array = { 4, 7, 3, 5, 1, 10, 90, 8};
        //    int min = array[0];
        //    for (int i = 0; i < array.Length;i++)
        //    {
        //        if (array[i] > min)
        //        {

        //        }
        //    }
        //}

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