using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTram.Contracts.Documents
{
    public class Grade
    {
        public string Id { get; set; }
        public Driver Driver { get; set; }
        public short Value { get; set; }
        public string Comment { get; set; }
    }
}
