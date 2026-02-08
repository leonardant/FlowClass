using FlowClass;
using FlowClass.Interfaces;
using FlowClass.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClassConsoleApp.Lifecycles
{
    internal class Lifecycles
    {
        public static Lifecycle<Order> CreateLifecycle1()
        {
            return new Lifecycle<Order>(
                name: "Lifecycle1",
                steps: new ILifecycleStep<Order>[]
                {
                new StepA(),
                new StepB(),
                new StepC()
                });
        }

        public static Lifecycle<Order> CreateLifecycle2()
        {
            return new Lifecycle<Order>(
                name: "Lifecycle2",
                steps: new ILifecycleStep<Order>[]
                {
                new StepA(),
                new StepB()
                });
        }
    }
}
