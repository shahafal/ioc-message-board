using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard
{
    public class BackgroundManipulator : IBackgroundManipulator
    {
        public void ChangeBackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
