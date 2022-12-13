using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class Book
    {
        public static class Notes
        {
            private static string[] notes;

            public static string[] NotesArray
            {
                get {
                    return notes;
                } 
            }

            public static void setNotesQuantity(int index)
            {
                notes = new string[index];
            }

            public static void addNote(string note, int index)
            {
                notes[index] = note;
            }
        }
        public static void FindNext(string str)
        {   
            Console.WriteLine("Пошук рядка : " + str);
            for (int i = 0; i < Notes.NotesArray.Length; i++)
            {
                if(Notes.NotesArray[i] == str)
                {
                    Console.WriteLine($"Заметка найдена под номером {i + 1}: {Notes.NotesArray[i]}");
                }
            }
        }
    }
}
