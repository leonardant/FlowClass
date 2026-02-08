using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowClass
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Status { get; set; } = "New";
        public List<string> History { get; } = new List<string>();
    }
}
