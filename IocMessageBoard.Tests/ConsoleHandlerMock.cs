using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard.Tests
{
    public class ConsoleHandlerMock : IConsoleHandler
    {
        public int countWriteToConsole { get; set; }
        public string writeToConsoleWith { get; set; }
        public void WriteToConsole(string message)
        {
            countWriteToConsole++;
            writeToConsoleWith = message;
        }
    }
}
