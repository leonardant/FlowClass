using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass
{
    public class Lifecycle<TContext>
    {
        private readonly List<ILifecycleStep<TContext>> _steps;

        public string Name { get; }

        public Lifecycle(string name, IEnumerable<ILifecycleStep<TContext>> steps)
        {
            Name = name;
            _steps = steps.ToList();
        }

        public ILifecycleStep<TContext>? GetStep(int index)
            => index >= 0 && index < _steps.Count ? _steps[index] : null;

        public int StepCount => _steps.Count;
    }
}
