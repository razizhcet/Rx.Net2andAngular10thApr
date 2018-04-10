using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    class RxAsyncSubject
    {
        static void Main(string[] args)
        {
            //AsyncSubjectNotCompleted();
            AsyncSubjectCompleted();
            Console.ReadKey();
        }

        static void AsyncSubjectNotCompleted()
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
        }

        static void AsyncSubjectCompleted()
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
        }

        //Takes an IObservable<string> as its parameter. 
        //Subject<string> implements this interface.
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            //The next two lines are equivalent.
            //sequence.Subscribe(value=>Console.WriteLine(value));
            sequence.Subscribe(Console.WriteLine);
        }
    }
}
