
using IocMessageBoard;

var factory = new Factory();
var messageBoard = (MessageBoard)factory.GetInstance(typeof(MessageBoard));

messageBoard.OutputMessage();
