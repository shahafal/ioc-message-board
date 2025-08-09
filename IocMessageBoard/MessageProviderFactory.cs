using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard
{
    public class MessageProviderFactory
    {
        public MessageProvider GetInstance()
        {
            var calendar = new GregorianCalendar();
            var messageProvider = new MessageProvider(calendar);
            return messageProvider;
        }
    }
}
