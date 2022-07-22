using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework3.Models
{
    public class Finance
    {

        public Finance(int FinanceId, int PizzaId, string Description, double Sum)
        {
            this.FinanceId = FinanceId;
            this.PizzaId = PizzaId;
            this.Description = Description;
            this.Sum = Sum;
        }

        public int FinanceId { get; set; }
        public int PizzaId { get; set; }
        public string Description { get; set; }
        public double Sum { get; set; }

    }
}
