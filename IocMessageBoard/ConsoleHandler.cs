using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard
{
    public class ConsoleHandler : IConsoleHandler
    {
        public void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
