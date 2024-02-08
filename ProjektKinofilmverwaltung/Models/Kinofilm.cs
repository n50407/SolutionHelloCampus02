using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKinofilmverwaltung.Models
{
    internal class Kinofilm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int _FilmId;

        public int FilmId
        {
            get { return _FilmId; }
            set { _FilmId = value; }
        }

        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        private string _Genre;
        public string Genre
        {
            get { return _Genre; }
            set { _Genre = value; }
        }

        private string _Bild;

        public string Bild
        {
            get { return _Bild; }
            set { _Bild = value; }
        }



    }
}
