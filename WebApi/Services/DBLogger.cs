namespace WebApi
{
    public class DBLogger : IloggerService
    {
        public void IWrite(string message)
        {
            System.Console.WriteLine(" [DbLogger] - " + message);
        }
    }
}