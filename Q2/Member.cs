using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Member
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateJoined { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Type}, {DateJoined.ToShortDateString()}";
        }
    }
}
