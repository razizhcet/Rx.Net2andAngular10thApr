using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    class RxBehaviorSubject
    {
        static void Main(string[] args)
        {
            //BehaviorSubjectExample1();
            //BehaviorSubjectExample2();
            //BehaviorSubjectExample3();
            BehaviorSubjectCompletedExample();
            Console.ReadKey();
        }

        static void BehaviorSubjectExample1()
        {
            //Need to provide a default value.
            var subject = new BehaviorSubject<string>("a");
            subject.Subscribe(Console.WriteLine);
        }

        static void BehaviorSubjectExample2()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
        }

        static void BehaviorSubjectExample3()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");
        }

        static void BehaviorSubjectCompletedExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            subject.Subscribe(Console.WriteLine);
        }
    }
}
