using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AufgabeTicketbestellung.Models
{
    internal class Ticketbestellung: INotifyPropertyChanged
    {
        #region Erklärung Property
        private int maxTicketAnzahl;

        public void setMaxTicketAnzahl(int max)
        {
            this.maxTicketAnzahl = max;
        }
        public int getMaxTicketAnzahl()
        {
            return this.maxTicketAnzahl;
        }


        public int CSharpMaxTicketAnzahlVariante1 { get; set; }

        private int _CSharpMaxTicketAnzahlVariante2;

        public int CSharpMaxTicketAnzahlVariante2
        {
            get { return _CSharpMaxTicketAnzahlVariante2; }
            set { 
                
                _CSharpMaxTicketAnzahlVariante2 = value; 
            
                //zusätzliche Logik
            }
        }


        #endregion

        public Ticketbestellung()
        {
            TicketArten = new List<string>()
            {
                "Konzert",
                "Kino",
                "Museum",
                "Eishockey"

            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void ChangeNotification(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        public List<string> TicketArten { get; set; }

        private double _Price;

        public double Price
        {
            get { return _Price; }
            set { 
                _Price = value;
                CalcGesamtPriceAndFarbe();
            }
        }

        private int _Anzahl;

        public int Anzahl
        {
            get { return _Anzahl; }
            set { 
                _Anzahl = value;
                CalcGesamtPriceAndFarbe();
            }
        }

        private string _Farbe;

        public string Farbe
        {
            get { return _Farbe; }
            set { _Farbe = value; }
        }

        private double _Gesamtpreis;

        public double Gesamtpreis
        {
            get { return _Gesamtpreis; }
            set { _Gesamtpreis = value; }
        }

        private void CalcGesamtPriceAndFarbe()
        {
            CalcGesamtpreis();
            CalcFarbe();
        }

        private void CalcGesamtpreis()
        {
            Gesamtpreis = Anzahl * Price;
            ChangeNotification("Gesamtpreis");
        }

        private void CalcFarbe()
        {
            if (Gesamtpreis < 1000)
            {
                Farbe = "Green";
            }
            else
            {
                Farbe = "Red";
            }

            ChangeNotification("Farbe");

        }

        




    }
}
