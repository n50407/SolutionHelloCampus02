using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campus02.ProjektLieferkostenberechnung.Models
{
    internal class Lieferkosten : INotifyPropertyChanged
    {
        #region Region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyGUI(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion
        public Lieferkosten()
        {
            Laender = new List<string>()
                {
                    "AT",
                    "DE",
                    "ES"
                };
        }
        #region Properties

        public List<string> Laender { get; set; }

        private string _AusgewLand;

        public string AusgewLand
        {
            get { return _AusgewLand; }
            set { 
                _AusgewLand = value;
                OnLandChange();
            
            }
        }
        private double _PreisProKilo;

        public double PreisProKilo
        {
            get { return _PreisProKilo; }
            set { _PreisProKilo = value; }
        }
        private string _Flagge;

        public string Flagge
        {
            get { return _Flagge; }
            set { _Flagge = value; }
        }
        private string _Ausgabetext;

        public string Ausgabetext
        {
            get { return _Ausgabetext; }
            set { _Ausgabetext = value; }
        }





        private void OnLandChange()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
