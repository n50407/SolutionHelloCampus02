using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKinofilmverwaltung.Models
{
    internal class KinofilmViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Kinofilm>   Kinofilme { get; set; }


        private Kinofilm _SelectedKinofilm;
        public Kinofilm SelectedKinofilm
        {
            get { return _SelectedKinofilm; }
            set
            {
                _SelectedKinofilm = value;
                OnPropertyChanged("SelectedKinofilm");
            }
        }

        public void AddKinofilm(Kinofilm kinofilm)
        {
            Kinofilme.Add(kinofilm);
            Titel="Es sind "+Kinofilme.Count+" Filme in der Liste";
            OnPropertyChanged("Titel");
        }

        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        public Kinofilm NeuerFilm { get; set; }


        //Aufgabe - neue Genres über eigenes Fenster hinzufügen
        public ObservableCollection<string> Genres { get; set; }
        public string NeuesGenre { get; set; }

        public void AddNewGenre(string genre)
        {
            Genres.Add(genre);
          
        }

        public KinofilmViewModel()
        {
                Genres = new ObservableCollection<string>() { "Science Fiction", "Abenteuer", "Action","Comedy" };
        }

    }
    
    
}
