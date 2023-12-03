using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CurrencyConverter.Base;
using CurrencyConverter.Models;
using CurrencyConverter.Views;

namespace CurrencyConverter.ViewModels
{
    public class ResultViewModel : BaseNotifyPropertyChanged
    {
        public ResultViewModel() { }
        public ResultViewModel(decimal result)
        {
            _result = result.ToString();
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        public ICommand btnGetResult
        {
            get
            {
                return new BaseCommand((obj) =>
                {
                    Clipboard.SetText(Result);
                });
            }
        }
    }
}
