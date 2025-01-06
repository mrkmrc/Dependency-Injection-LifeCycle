using DI_LifeCycle_NET6.Interface;

namespace DI_LifeCycle_NET6.LifeCycles
{
    public class ExampleTransient : ILifeCycle
    {
        string uuid = string.Empty;

        public ExampleTransient()
        {
            uuid = Guid.NewGuid().ToString();
        }
        public void Run()
        {
            Console.WriteLine($@"Transient: {uuid}");
        }
    }
}
