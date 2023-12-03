using CurrencyConverter.Base;
using CurrencyConverter.Models;
using CurrencyConverter.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CurrencyConverter.ViewModels
{
    public class MainViewModel : BaseNotifyPropertyChanged
    {
        private Currency _selectedFirstType;
        private Currency _selectedSecondType;
        private string _inputValue = "0";

        private ObservableCollection<Currency> _currencies = CurrenciesList.Values;
        public ObservableCollection<Currency> Currencies
        {
            get { return _currencies; }
            set
            {
                _currencies = value;
                OnPropertyChanged();
            }
        }
        
        public Currency SelectedFirstType
        {
            get { return _selectedFirstType;}
            set
            {
                _selectedFirstType = value; 
                OnPropertyChanged();
            }
        }
        public Currency SelectedSecondType
        {
            get { return _selectedSecondType;}
            set
            {
                _selectedSecondType = value;
                OnPropertyChanged();
            }
        }

        public string InputValue
        {
            get { return _inputValue; }
            set
            {
                _inputValue = value;
                OnPropertyChanged();
            }
        }

        public ICommand btnCommand
        {
            get
            {
                return new BaseCommand((obj) =>
                {
                    AppProcessor processor = new AppProcessor();
                    processor.Calculating(SelectedFirstType, SelectedSecondType, InputValue);
                });
            }
        }
        public MainViewModel()
        {
            if (_currencies.Count > 1)
            {
                SelectedFirstType = _currencies[1];
                SelectedSecondType = _currencies[0];
            }
            else throw new Exception("Класс \"CurrenciesList\" содержит менее двух экзэмпляров класса \"Currency\"");
        }
    }

}
