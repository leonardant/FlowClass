using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass.Steps
{
    public class StepC : ILifecycleStep<Order>
    {
        public string Name => "C";

        public void Execute(Order context)
        {
            context.Status = "Processed C";
            context.History.Add("Step C executed");
            Console.WriteLine($"Order {context.Id}: Step C");
        }
    }
}
