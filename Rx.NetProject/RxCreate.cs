using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    class RxCreate
    {
        static void Main(string[] args)
        {
            var disposable = Disposable.Create(() => Console.WriteLine("Being disposed."));
            Console.WriteLine("Calling dispose...");
            disposable.Dispose();
            Console.WriteLine("Calling again...");
            disposable.Dispose();
            Console.ReadKey();
        }
    }
}
