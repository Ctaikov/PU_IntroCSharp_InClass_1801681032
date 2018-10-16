using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                // Create new SoundPlayer in the using statement.
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\Staikov\Desktop\Week3\PU_IntroCSharp_InClass_1801681032\W3InClass\MusicFactory\Music\Disturbed - The Best Ones Lie [Official Lyric Video].wav"))
                {
                    // Use PlaySync to load and then play the sound.
                    // ... The program will pause until the sound is complete.
                    Console.WriteLine("Now playing...");
                    player.PlaySync();
                    while (true)
                    {
                        Console.Write(".");
                    }
                }
            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye.");
            }
            else if(answer=="Fuck you")
             {
                 Console.WriteLine("Yes, fuck you too.");
             }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}
