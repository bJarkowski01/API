using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace API
{
    internal class Currency
    {

        public int timestamp { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }

        public override string ToString()
        {
            return $"Timestamp: {timestamp} ,\tbase: {@base}," + Environment.NewLine + $"Rates:" + Environment.NewLine + $"{rates.ToString()} " + Environment.NewLine;
        }
    }
    internal class Rates
    {
        public double CHF { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double JPY { get; set; }
        public double PLN { get; set; }

        public override string ToString()
        {
            return $"CHF: {CHF},"+ Environment.NewLine + $"EUR: {EUR}" + Environment.NewLine
                + $"GBP: {GBP}" + Environment.NewLine + $"JPY: {JPY}" + Environment.NewLine + $"PLN: {PLN}" + Environment.NewLine;
        }
    }
}
