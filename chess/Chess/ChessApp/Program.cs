using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //name it chess app 5; 45 h into the 3rd video
            //\n for new line
            //min fina logiska code (swengelska)
            for (int j = 0; j < 4; j++)
                {

                    for (int i = 0; i < 4; i++)
                    {
                    //x värde
                        Console.Write("▓▓");
                        Console.Write("░░");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                    //y värde
                        Console.Write("░░");
                        Console.Write("▓▓");

                    }


                    Console.WriteLine();

                }
            Console.WriteLine();

            //Sven-Eriks Matematiska Code
            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    int characterIndex = (x / 2 + y) % 2;
                    char character = characterIndex == 0 ? '░' : '▓';

                    Console.Write(character);
                }

                Console.Write('\n');
            }

            Console.ReadKey();
        }
    }
}
