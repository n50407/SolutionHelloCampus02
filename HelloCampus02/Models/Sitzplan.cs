using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02.Models
{
    internal class Sitzplan: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void InformGUI(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public List<string> Reihe1 { get; set; }
        public List<string> Reihe2 { get; set; }
        public List<string> Reihe3 { get; set; }

        //public string Farbe1 { get; set; }
        private string _Farbe1;

        public string Farbe1
        {
            get { return _Farbe1; }
            set { 
                _Farbe1 = value;
                InformGUI("Farbe1");
            }
        }

        public string Farbe2 { get; set; }
        public string Farbe3 { get; set; }

        public int EingabeReihe { get; set; }

       
    }
}
