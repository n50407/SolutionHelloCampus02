using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Laender = new ObservableCollection<string>()
                {
                    "AT",
                    "DE",
                    "ES"
                };

            ObsListeLaender = new ObservableCollection<Land>()
            {
                new Land(){Bezeichnung="Austria",Flagge="Austria.png",Kosten=7},
                new Land(){Bezeichnung="Germany",Flagge="DE.png",Kosten=7},

            };
        }
        #region Properties

        public ObservableCollection<string> Laender { get; set; }

        private string _AusgewLand;

        public string AusgewLand
        {
            get { return _AusgewLand; }
            set { 
                _AusgewLand = value;
                OnLandChange();
            
            }
        }
        private double _KostenProKilo;

        public double KostenProKilo
        {
            get { return _KostenProKilo; }
            set { _KostenProKilo = value; }
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
        private int _Gesamtgewicht;

        public int Gesamtgewicht
        {
            get { return _Gesamtgewicht; }
            set { 
                _Gesamtgewicht = value;
                OnLandChange();
                NotifyGUI("Gesamtgewicht");
            }
        }

        private bool _IsExpress;

        public bool IsExpress
        {
            get { return _IsExpress; }
            set { 
                _IsExpress = value;
                OnLandChange();
                NotifyGUI("IsExpress");
            }
        }

        public ObservableCollection<Land> ObsListeLaender { get; set; }





        private void OnLandChange()
        {
            switch (AusgewLand)
            {
                case "AT":
                    KostenProKilo = 12;
                    Flagge = "Austria.png";
                    break;
                case "DE":
                    KostenProKilo = 20;
                    Flagge = "DE.png";
                    break;
                case "ES":
                    KostenProKilo = 25;
                    Flagge = "Spain.png";
                    break;
                default:
                    break;
            }
            var gesamtpreis = Gesamtgewicht * KostenProKilo;
            if (IsExpress)
            {
                gesamtpreis *= 1.1;
            }

            Ausgabetext = $"Sie haben {AusgewLand} ausgewählt. Hier kostet ein Kilo {KostenProKilo} Gesamtgewicht {Gesamtgewicht} Express ist {IsExpress} Gesamtpreis {gesamtpreis}";
            NotifyGUI("KostenProKilo");
            NotifyGUI("Flagge");
            NotifyGUI("Ausgabetext");
        }

        public string AusgabeVariante2 { get; set; }


        private Land _AusgewaehltesLandObject;

        public Land AusgewaehltesLandObject
        {
            get { return _AusgewaehltesLandObject; }
            set { 
                _AusgewaehltesLandObject = value;

                AusgabeVariante2 = $"Sie haben gewählt {AusgewaehltesLandObject.Bezeichnung} Kosten: {AusgewaehltesLandObject.Kosten}";
                NotifyGUI("AusgabeVariante2");
            }
        }


        #endregion
    }
}
