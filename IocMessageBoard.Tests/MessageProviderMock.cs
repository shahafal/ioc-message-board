using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard.Tests
{
    internal class MessageProviderMock : IMessageProvider
    {
        public string ProduceMessage()
        {
            return "life is a climb, but the view is great";
        }
    }
}
