namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество заметок для сохранения");
            int notesQuantity = Convert.ToInt32(Console.ReadLine());
            Book.Notes.setNotesQuantity(notesQuantity);
            for (int i = 0; i < notesQuantity; i++)
            {
                Console.WriteLine($"Введите заметку {i + 1}");
                Book.Notes.addNote(Console.ReadLine(), i);
            }
            Console.WriteLine("Введите текст для поиска");
            Book.FindNext(Console.ReadLine());
            Console.ReadKey();
        }
    }
}