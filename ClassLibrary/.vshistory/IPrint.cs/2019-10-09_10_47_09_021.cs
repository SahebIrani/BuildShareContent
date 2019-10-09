namespace ClassLibrary
{
    public interface IPrint
    {
        /// <summary>
        /// Show Message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string ShowMessage(string message) => message;
    }
}
