using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CommandLine
    {
        public Command Command { get; set; }
        public int Message { get; set; }
    }
}
