using Singleton;

Console.Title = "singleton";


//call the property getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("instances are the same");
}

instance1.Log($"message from {nameof(instance1)}");
//or
instance1.Log($"message from {nameof(instance2)}");
//or
Logger.Instance.Log($"message from {nameof(Logger.Instance)}");

Console.WriteLine();