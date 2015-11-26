using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTram.Contracts.Documents
{
    public class Driver
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int DriverIdentifier { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}
