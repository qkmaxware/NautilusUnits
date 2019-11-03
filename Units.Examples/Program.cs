using System;
using System.Diagnostics;

namespace Tutorials {
    class Program {

        static void TimedRun(string name, Action act) {
            Console.WriteLine(string.Format("// {0} ----------------------------------------", name));
            var timer = Stopwatch.StartNew();
            act.Invoke();
            var elapsed = timer.Elapsed;
            timer.Stop();
            Console.WriteLine(string.Format("// ------------------------------------[{0}]", elapsed));
        }

        static void Main(string[] args) {
            TimedRun("Tutorial 1", Tutorial1.Program.Run);
            //TimedRun("Tutorial 2", Tutorial2.Program.Run);
            TimedRun("Tutorial 3", Tutorial3.Program.Run);
        }
    }
}
