namespace ClassLibrary
{
    public class Print : IPrint
    {
        public string ShowMessage(string message)
        {
            System.Console.WriteLine(message);
            return message;
        }
    }
}
