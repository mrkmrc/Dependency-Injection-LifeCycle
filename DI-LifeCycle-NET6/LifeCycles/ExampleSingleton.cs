using DI_LifeCycle_NET6.Interface;

namespace DI_LifeCycle_NET6.LifeCycles
{
    public class ExampleSingleton : ILifeCycle
    {
        string uuid = string.Empty;

        public ExampleSingleton()
        {
            uuid = Guid.NewGuid().ToString();
        }
        public void Run()
        {
            Console.WriteLine($@"Singleton: {uuid}");
        }
    }
}
