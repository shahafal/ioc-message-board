
namespace IocMessageBoard.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var calendar = new CalendarMock();
            _messageProvider = new MessageProvider(calendar);
        }

        [Test]
        public void ProduceMessage_ShouldReturnOnSunday_LifeIsAClimb()
        {
            var theMessage = _messageProvider.ProduceMessage();
            Assert.AreEqual(theMessage, "life is a climb, but the view is great");
        }

        private MessageProvider _messageProvider;
    }
}