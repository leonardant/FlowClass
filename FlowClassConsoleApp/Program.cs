

using FlowClass;
using FlowClassConsoleApp;
using FlowClassConsoleApp.Lifecycles;


    var lifecycle1 = Lifecycles.CreateLifecycle1(); // A, B, C
    var lifecycle2 = Lifecycles.CreateLifecycle2(); // A, B

    var order1 = new Order();
    var order2 = new Order();

    var instance1 = new LifecycleInstance<Order>(order1, lifecycle1);
    var instance2 = new LifecycleInstance<Order>(order2, lifecycle2);

    // Run order1 through lifecycle 1 (A -> B -> C)
    instance1.RunToEnd();

    // Run order2 step-by-step through lifecycle 2 (A -> B)
    instance2.MoveNext(); // A
    instance2.MoveNext(); // B

    Console.WriteLine($"Order1 final status: {order1.Status}");
    Console.WriteLine($"Order2 final status: {order2.Status}");
