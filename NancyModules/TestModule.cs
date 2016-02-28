using Nancy;
using NancyDependency;

namespace NancyModules
{
    public class TestModule : NancyModule
    {
        public TestModule(IMessageProcessor processor)
        {
            Get[""] = o => processor.DoYourThing("hello world");
        }
    }
}
