using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScharpExecuteJavascript
{
    public class Task
    {
        public Task(string number, int quantity, decimal beeingFirstPenaltyFactor, decimal beeingSecondPenaltyFactor)
        {
            Number = number;
            Quantity = quantity;
            BeeingFirstPenaltyFactor = beeingFirstPenaltyFactor;
            BeeingSecondPenaltyFactor = beeingSecondPenaltyFactor;
        }

        public string Number { get; }
        public int Quantity { get; }
        public decimal BeeingFirstPenaltyFactor { get; }
        public decimal BeeingSecondPenaltyFactor { get; }
    }
}
