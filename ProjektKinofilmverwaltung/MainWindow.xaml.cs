using ProjektKinofilmverwaltung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektKinofilmverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KinofilmViewModel kinofilmViewModel = new KinofilmViewModel();
            

            kinofilmViewModel.Kinofilme = new System.Collections.ObjectModel.ObservableCollection<Kinofilm>()
            {
                new Kinofilm() { FilmId = 1, Titel = "Star Wars", Genre = "Science Fiction", Bild = "starwars.jpg" },
                new Kinofilm() { FilmId = 2, Titel = "Indiana Jones", Genre = "Abenteuer", Bild = "indianajones.jpg" },
                new Kinofilm() { FilmId = 3, Titel = "James Bond", Genre = "Action", Bild = "jamesbond.jpg" }
            };
            kinofilmViewModel.NeuerFilm = new Kinofilm();

            kinofilmViewModel.Titel = "Es sind 3 Filme in der Liste";

            this.DataContext = kinofilmViewModel;
        }


        private void AddNewFilm(object sender, RoutedEventArgs e)
        {
            KinofilmViewModel kinofilmViewModel = (KinofilmViewModel)this.DataContext;


            Kinofilm neuerFilm = new Kinofilm();

            neuerFilm.Titel = kinofilmViewModel.NeuerFilm.Titel;
            neuerFilm.Genre = kinofilmViewModel.NeuerFilm.Genre;

            
            kinofilmViewModel.AddKinofilm(neuerFilm);

        }
    }
}
