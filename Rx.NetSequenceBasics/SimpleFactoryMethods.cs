using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetSequenceBasics
{
    class SimpleFactoryMethods
    {
        static void Main(string[] args)
        {
            ReturnMethod();
            Console.ReadKey();
        }

        static void ReturnMethod()
        {
            var singleValue = Observable.Return<string>("Value");
            //which could have also been simulated with a replay subject
            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
            subject.OnCompleted();
        }
    }

}
