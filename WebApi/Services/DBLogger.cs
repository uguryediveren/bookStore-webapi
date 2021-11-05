namespace WebApi
{
    public class DBLogger : ILoggerService
    {
        public void Write(string message)
        {
            System.Console.WriteLine(" [DbLogger] - " + message);
        }
    }
}