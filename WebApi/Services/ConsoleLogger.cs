namespace WebApi
{
    public class ConsoleLogger : IloggerService
    {
        public void IWrite(string message)
        {
            System.Console.WriteLine(" [ConsoleLogger] - " + message);
        }
    }
}