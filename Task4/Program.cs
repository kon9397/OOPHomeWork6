namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 76, 12, 54, 34, 12, 56, 1, 1064, 34, 67, 845 };
            myArray.SortArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.ReadKey();
        }
    }
}