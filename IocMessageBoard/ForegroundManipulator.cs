namespace IocMessageBoard
{
    public class ForegroundManipulator : IForegroundManipulator
    {
        public void ChangeForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}