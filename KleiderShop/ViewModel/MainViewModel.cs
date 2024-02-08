using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DataAccess;

namespace KleiderShop.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _ladeDaten;

        public string ladeDaten
        {
            get { return _ladeDaten; }
            set
            {
                if (_ladeDaten != value)
                {
                    _ladeDaten = value;
                    OnPropertyChanged(nameof(ladeDaten));
                    DbManager.DbConnection();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

