using System;
using System.Security.Cryptography.X509Certificates;

namespace EditorHtml {
    public static class Menu
    {
        public static void Show() 
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            DrawScreen();
            WriteOptions();
        }

        public static void DrawScreen()
        {
            Console.WriteLine("+");
            for (int i = 0; i <=  30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for( int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for( int i = 0; i <= 30; i++)
                    Console.Write(" ");

                    Console.Write("|");
                    Console.WriteLine("\n");
            }

            Console.WriteLine("+");
            for (int i = 0; i <=  30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");



        }

        public static void WriteOptions() 
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
        }
    }


}