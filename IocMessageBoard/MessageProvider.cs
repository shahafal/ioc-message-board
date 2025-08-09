using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard
{
    public class MessageProvider : IMessageProvider
    {
        public MessageProvider(Calendar calendar)
        {
            _calendar = calendar;
        }

        public string ProduceMessage()
        {
            if (_calendar.GetDayOfWeek(DateTime.Now) == DayOfWeek.Sunday)
            {
                return "shvizut yom alef";
            }
            else if (_calendar.GetDayOfWeek(DateTime.Now) == DayOfWeek.Thursday)
            {
                return "happy end of week";
            }
            else
            {
                return "life is a climb, but the view is great";
            }
        }

        private readonly Calendar _calendar;
    }
}
