using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard
{
    public class Factory
    {
        public Factory()
        {
            _interfaces = new Dictionary<Type, Type>();
            RegisterInterfaces();
        }

        public object GetInstance(Type type)
        {
            if (_interfaces.ContainsKey(type))
            {
                type = _interfaces[type];
            }

            var constructor = type.GetConstructors().First();
            var parameters = constructor.GetParameters();

            var arguments = new object[parameters.Length];
            for (int i=0; i<parameters.Length; i++)
            {
                var parameter = parameters[i];
                arguments[i] = GetInstance(parameter.ParameterType);
            }

            return Activator.CreateInstance(type, arguments);
        }

        private void RegisterInterfaces()
        {
            _interfaces.Add(typeof(Calendar), typeof(GregorianCalendar));
            _interfaces.Add(typeof(IMessageProvider), typeof(MessageProvider));
            _interfaces.Add(typeof(IConsoleHandler), typeof(ConsoleHandler));
            _interfaces.Add(typeof(IBackgroundManipulator), typeof(BackgroundManipulator));
            _interfaces.Add(typeof(IForegroundManipulator), typeof(ForegroundManipulator));
        }

        private readonly Dictionary<Type, Type> _interfaces;
    }
}
