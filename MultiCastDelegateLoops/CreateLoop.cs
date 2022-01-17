using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiCastDelegateLoops
{
    public class CreateLoop
    {
        private string Name { get; set; }

        public CreateLoop(string name)
        {
            this.Name = name;
            LoopManager.OnLoopStart += LoopRun;
        }

        private void LoopRun()
        {
            for (int i = 0; i < 3; i++)
            {
                DateTime now = DateTime.Now; 
                Console.WriteLine($"{this.Name}::{now.Millisecond}");

            }
        }

    }

   

}


