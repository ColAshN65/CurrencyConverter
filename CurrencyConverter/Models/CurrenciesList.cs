using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public static class CurrenciesList
    {
        public static ObservableCollection<Currency> Values { get; private set; } = new ObservableCollection<Currency>()
        {
            new Currency("Российский Рубль", 89.29m),
            new Currency("Доллар США", 1m),
            new Currency("Евро", 0.91m),
            new Currency("Белорусский Рубль", 3.28m),
            new Currency("Казахстанский Тенге", 460.04m),
            new Currency("Китайский Юань", 7.09m)
        };
    }
}
