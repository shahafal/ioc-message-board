using System.Globalization;

namespace IocMessageBoard
{
    public class MessageBoard
    {
        public MessageBoard(IMessageProvider messageProvider, IConsoleHandler consoleHandler, IBackgroundManipulator backgroundManipulator, IForegroundManipulator foregroundManipulator)
        {
            _messageProvider = messageProvider;
            _consoleHandler = consoleHandler;
            _backgroundManipulator = backgroundManipulator;
            _foregroundManipulator = foregroundManipulator;
        }
        public void OutputMessage()
        {
            _backgroundManipulator.ChangeBackgroundColor(ConsoleColor.Blue);
            _foregroundManipulator.ChangeForegroundColor(ConsoleColor.Red);
            var theMessage = _messageProvider.ProduceMessage();
            _consoleHandler.WriteToConsole(theMessage);
        }

        private readonly IMessageProvider _messageProvider;
        private readonly IConsoleHandler _consoleHandler;
        private readonly IBackgroundManipulator _backgroundManipulator;
        private readonly IForegroundManipulator _foregroundManipulator;
    }
}
