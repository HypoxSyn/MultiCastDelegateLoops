using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program is designed to understand multicast delegate loops using a timer to show to the millisecond the execution of each
             * loop that is loaded into the OnLoopStart Method stored under the LoopDelegate
             */
             
            CreateLoop loop1 = new CreateLoop("#1 Loop");
            CreateLoop loop2 = new CreateLoop("#2 Loop");
            CreateLoop loop3 = new CreateLoop("#3 Loop");
            CreateLoop loop4 = new CreateLoop("#4 Loop");
            CreateLoop loop5 = new CreateLoop("#5 Loop");
            CreateLoop loop6 = new CreateLoop("#6 Loop");
            CreateLoop loop7 = new CreateLoop("#7 Loop");
            CreateLoop loop8 = new CreateLoop("#8 Loop");

            while (true)
            {
                
                Console.WriteLine("MultiCast Delegate Using Method Loops");
                Console.WriteLine("Press 'space' to begin.");

                ConsoleKeyInfo keyinfo;
                keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.Spacebar)
                {
                    while (true)
                    {
                        LoopManager.TriggerLoops();
                        Console.Read();
                        Console.Clear();
                        
                    }
                   
                }
                
                Console.Clear();

                
            }
        }
    }
}
