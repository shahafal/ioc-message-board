using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocMessageBoard.Tests
{
    public class MessageBoardTests
    {
        [SetUp]
        public void Setup()
        {
            _messageProvider = new MessageProviderMock();
            _consoleHandler = new ConsoleHandlerMock();
            _backgroundManipulator = new BackgroundManipulator();
            _messageBoard = new MessageBoard(_messageProvider, _consoleHandler, _backgroundManipulator);
        }

        [Test]
        public void OutputMessage_ShouldCallConsoleHandlerWith_LifeIsAClimb()
        {
            _messageBoard.OutputMessage();

            var count = _consoleHandler.countWriteToConsole;
            var with = _consoleHandler.writeToConsoleWith;
            Assert.AreEqual(count, 1);
            Assert.AreEqual(with, "life is a climb, but the view is great");
        }

        private MessageBoard _messageBoard;
        private MessageProviderMock _messageProvider;
        private ConsoleHandlerMock _consoleHandler;
        private BackgroundManipulator _backgroundManipulator;
    }
}
