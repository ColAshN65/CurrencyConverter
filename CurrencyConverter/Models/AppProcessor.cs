using CurrencyConverter.ViewModels;
using CurrencyConverter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CurrencyConverter.Models
{
    public class AppProcessor
    {
        public void Calculating(Currency first, Currency second, string value)
        {
            decimal inputValue;
            if (!decimal.TryParse(value, out inputValue))
            {
                MessageBox.Show("Введенное число бессмысленно большое/маленькое или имеет неправильный формат", "Ошибка ввода данных");
                return;
            }
            try
            {
                ResultWindow resultWindow = new ResultWindow();
                ResultViewModel viewModel = new ResultViewModel(ConvertCurrency(first, second, inputValue));
                resultWindow.DataContext = viewModel;
                resultWindow.Show();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введенное число бессмысленно большое/маленькое", "Ошибка ввода данных");
            }
        }
        private decimal ConvertCurrency(Currency first, Currency second, decimal value)
        {
            return value / first.Value * second.Value;
        }
    }
}
