using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.NetProject
{
    public class ConsoleColor : IDisposable
    {
        private readonly System.ConsoleColor _previousColor;

        public ConsoleColor(System.ConsoleColor color)
        {
            _previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }

        public void Dispose()
        {
            Console.ForegroundColor = _previousColor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Normal color");
            using (new ConsoleColor(System.ConsoleColor.Red))
            {
                Console.WriteLine("Now I am Red");
                using (new ConsoleColor(System.ConsoleColor.Green))
                {
                    Console.WriteLine("Now I am Green");
                }
                Console.WriteLine("and back to Red");
            }
            Console.ReadKey();
        }
    }
}
