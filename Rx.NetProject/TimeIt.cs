using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    public class TimeIt : IDisposable
    {
        private readonly string _name;
        private readonly Stopwatch _watch;

        public TimeIt(string name)
        {
            _name = name;
            _watch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _watch.Stop();
            Console.WriteLine("{0} took {1}", _name, _watch.Elapsed);
        }

        static void Main(string[] args)
        {
            using (new TimeIt("Outer scope"))
            {
                using (new TimeIt("Inner scope A"))
                {
                    DoSomeWork("A");
                }
                using (new TimeIt("Inner scope B"))
                {
                    DoSomeWork("B");
                }
               // Cleanup();
            }
            Console.ReadKey();
        }

        static void DoSomeWork(string str)
        {
            Console.WriteLine(str + " Active");
        }
    }
}
