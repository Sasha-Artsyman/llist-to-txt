using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Create your list of notes");
        Console.WriteLine("-------------------------");
        Console.WriteLine("(Press key 'End' to save)");
        Console.WriteLine("-------------------------\n");

        try
        {
            // создание файла
            StreamWriter ListOfNotes = new StreamWriter("D:\\Notes.txt");

            ListOfNotes.WriteLine("Notes from " + DateTime.Today.ToShortDateString() + ":\n");

            int num0 = 1;
            bool save0 = false;

            do
            {
                Console.Write("{0}. ", num0);
                
                ListOfNotes.WriteLine(Convert.ToString(num0) + ". " + Console.ReadLine());
                num0++;

                if (Console.ReadKey(true).Key == ConsoleKey.End)
                {
                    Console.WriteLine("\nSaving...");
                    save0 = true;
                }
            }
            while (!save0);


            ListOfNotes.Close();
        }
        catch (Exception e0)
        {
            Console.WriteLine("Exception: " + e0.Message);
        }

        Console.ReadLine();
    }
}