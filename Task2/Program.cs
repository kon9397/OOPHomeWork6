namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            FindAndReplaceManager.FindNext(Console.ReadLine());
            Console.ReadKey();
        }
    }
}