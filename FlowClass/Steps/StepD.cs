using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass.Steps
{
    public class StepD : ILifecycleStep<Order>
    {
        public string Name => "D";

        public void Execute(Order context)
        {
            context.Status = "Processed D";
            context.History.Add("Step D executed");
            Console.WriteLine($"Order {context.Id}: Step D");
        }
    }
}
