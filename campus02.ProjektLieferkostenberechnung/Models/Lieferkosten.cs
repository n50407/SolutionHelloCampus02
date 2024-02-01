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

        #endregion
    }
}
