using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass.Interfaces
{
    public interface ILifecycleStep<TContext>
    {
        string Name { get; }

        // Do whatever this step needs to do with the object/context
        void Execute(TContext context);
    }
}
