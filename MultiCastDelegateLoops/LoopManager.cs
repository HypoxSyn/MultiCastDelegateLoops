using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateLoops
{
    class LoopManager
    {
        public delegate void LoopDelegate();

        public static LoopDelegate OnLoopStart;
        public static void TriggerLoops()
        {

            if(OnLoopStart != null)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine($"Time: {now.Hour}:{now.Minute}:{now.Second}:{now.Millisecond}");
                //Console.WriteLine($"The loop has started.");
                //OnGameStart triggers all the methods subscribed to the event
                OnLoopStart();
            }



        }




    }
}
