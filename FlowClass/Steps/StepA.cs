using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass.Steps
{
    public class StepA : ILifecycleStep<Order>
    {
        public string Name => "A";

        public void Execute(Order context)
        {
            context.Status = "Processed A";
            context.History.Add("Step A executed");
            Console.WriteLine($"Order {context.Id}: Step A");
        }
    }
}
