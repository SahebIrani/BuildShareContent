namespace ClassLibrary
{
    public interface IPrint
    {
        /// <summary>
        /// Print Show Message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string ShowMessage(string message)
        {
            System.Console.WriteLine(message);
            return message;
        }
    }
}
