using DI_LifeCycle_NET6.Interface;

namespace DI_LifeCycle_NET6.LifeCycles
{
    public class ExampleScoped : ILifeCycle
    {
        string uuid = string.Empty;

        public ExampleScoped()
        {
            uuid = Guid.NewGuid().ToString();
        }
        public void Run()
        {
            Console.WriteLine($@"Scoped: {uuid}");
        }
    }
}
