using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass.Steps
{
    public class StepB : ILifecycleStep<Order>
    {
        public string Name => "B";

        public void Execute(Order context)
        {
            context.Status = "Processed B";
            context.History.Add("Step B executed");
            Console.WriteLine($"Order {context.Id}: Step B");
        }
    }
}
