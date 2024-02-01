using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingSample.Models
{
    internal class ProductViewModel: INotifyPropertyChanged
    {
        public ProductViewModel()
        {
            Wochentagen = new List<string>()
                {
                    "Montag",
                    "Dienstag",
                    "Mittwoch"
                };
        }
        public int Anzahl { get; set; }
        public Product MyProduct { get; set; }

        //public string MyFirstname { get; set; }
        private string _MyFirstname;

        public string MyFirstname
        {
            get { return _MyFirstname; }
            set { 
                _MyFirstname = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MyFirstname"));
                }
            }
        }

        private string _CurrentWeekday;

        public string CurrentWeekday
        {
            get { return _CurrentWeekday; }
            set {
                _CurrentWeekday = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CurrentWeekday"));
                }
            }
        }



        public List<string> Wochentagen { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
