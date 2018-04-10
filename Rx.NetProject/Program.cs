using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var obs = Observable.Generate(
                0,
                _ => true,
                i => i + 1,
                i => new string('*', i),
                i => TimeSpan.FromSeconds(i)
                );
            //obs.Subscribe(x => Console.WriteLine(x));
            using (obs.Subscribe(Console.WriteLine))
            {
                Console.WriteLine("Press any key to stop...");
                Console.ReadKey();
            }
        }
    }
}
