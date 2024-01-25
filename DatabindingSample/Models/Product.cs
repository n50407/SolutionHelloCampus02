﻿using System;
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

        private void NotifyGui(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Color { get; set; }
        public bool Expired { get; set; }

       
    }
}