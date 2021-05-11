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
            string Min10 = @"/C " + "shutdown -s -t "+a ;
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
        }
        public Processo() // sobrecarga
        {
            string Min10 = @"/C " + "shutdown/a";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
        }

    }
}
