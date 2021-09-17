using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerSleep
{
    class Processo
    {
        public Processo (int a)
        {
            System.Diagnostics.Process.Start("CMD.exe", @"/C " + "shutdown -s -t " + a).WaitForExit();

        }
        public Processo() // sobrecarga
        {
            System.Diagnostics.Process.Start("CMD.exe", @"/C " + "shutdown/a").WaitForExit();
        }


    }
}
