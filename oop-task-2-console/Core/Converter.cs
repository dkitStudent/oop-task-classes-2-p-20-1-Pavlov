using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_2_console.Core
{
    internal class Converter
    {
        public double Btc { get; set; }
        public double Eth { get; set; }
        public double Bnb { get; set; }

        public Converter(double btc, double eth, double bnb)
        {
            Btc = btc;
            Eth = eth;
            Bnb = bnb;
        }
    }
}
