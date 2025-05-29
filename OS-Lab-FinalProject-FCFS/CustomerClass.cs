using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab_FinalProject_FCFS
{
    public class Customer
    {
        public int LineNumber { get; set; }
        public string FullName { get; set; }
        public int BurstTime { get; set; }
    }
}
