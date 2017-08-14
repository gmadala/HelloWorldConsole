using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.ConsoleMain;

namespace HelloWorldConsole.ConsoleMain
{
    class HelloWorld : IHelloWorld
    {
        public void Hello(string[] args)
        {
            var displayHello = "Hello World";
            Console.WriteLine(displayHello);
            throw new NotImplementedException();
        }

    }
}
