namespace ClassLibrary
{
    public interface IPrint
    {
        /// <summary>
        /// Print Show SinjulMSBH Message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string ShowSinulMSBH()
        {
            System.Console.WriteLine("SinjulMSBH");
            return "SinjulMSBH";
        }

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
