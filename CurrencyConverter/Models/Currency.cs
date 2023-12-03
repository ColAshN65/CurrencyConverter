using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Currency
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public Currency(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}
