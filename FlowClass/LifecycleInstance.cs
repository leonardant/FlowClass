using FlowClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass
{
    public class LifecycleInstance<TContext>
    {
        private readonly Lifecycle<TContext> _lifecycle;
        private int _currentIndex = 0;

        public TContext Context { get; }
        public string LifecycleName => _lifecycle.Name;
        public bool IsCompleted => _currentIndex >= _lifecycle.StepCount;

        public ILifecycleStep<TContext>? CurrentStep =>
            _lifecycle.GetStep(_currentIndex);

        public LifecycleInstance(TContext context, Lifecycle<TContext> lifecycle)
        {
            Context = context;
            _lifecycle = lifecycle;
        }

        // Execute current step and advance
        public void MoveNext()
        {
            if (IsCompleted)
                return;

            var step = CurrentStep;
            step?.Execute(Context);
            _currentIndex++;
        }

        // Optionally run until finished
        public void RunToEnd()
        {
            while (!IsCompleted)
            {
                MoveNext();
            }
        }
    }
}