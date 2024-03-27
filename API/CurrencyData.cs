using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class CurrencyData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Timestamp { get; set; }
        public string Base { get; set; }
        public double CHF { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double JPY { get; set; }
        public double PLN { get; set; }
    }
}
