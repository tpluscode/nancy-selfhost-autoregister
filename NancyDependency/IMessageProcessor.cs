namespace NancyDependency
{
    public interface IMessageProcessor
    {
        string DoYourThing(string msg);
    }

    public class MessageProcessor : IMessageProcessor
    {
        public string DoYourThing(string msg)
        {
            return msg.ToUpper();
        }
    }
}
