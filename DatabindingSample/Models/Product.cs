using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingSample.Models
{
    internal class Product: INotifyPropertyChanged //Observer Pattern
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        private decimal _Brutto;

        public decimal Brutto
        {
            get { return _Brutto; }
            set { _Brutto = value; }
        }


        public int ProductId { get; set; }
        public string Productname { get; set; }
        //public decimal Price { get; set; } //Auto-Property

        private decimal _Price;
        public decimal Price
        {
            get { return _Price; }
            set {
                _Price = value;

                /*
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Price"));
                */
                NotifyGui("Price");
            }
        }
        private decimal _Ust;
        public decimal Ust
        {
            get { return _Ust; }
            set
            {
                _Ust = value;
                //Calc Brutto
                Brutto = Price * (1 + Ust / 100);
                NotifyGui("Brutto");
            }
        }
        private void NotifyGui(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Color { get; set; }
        public bool Expired { get; set; }

       
    }
}
