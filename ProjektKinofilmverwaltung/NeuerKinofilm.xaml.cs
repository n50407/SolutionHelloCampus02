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
using System.Windows.Shapes;

namespace ProjektKinofilmverwaltung
{
    /// <summary>
    /// Interaction logic for NeuerKinofilm.xaml
    /// </summary>
    public partial class NeuerKinofilm : Window
    {
        public NeuerKinofilm()
        {
            InitializeComponent();
        }

        private void AddNewFilm(object sender, RoutedEventArgs e)
        {
            KinofilmViewModel kinofilmViewModel = (KinofilmViewModel)this.DataContext;


            Kinofilm neuerFilm = new Kinofilm();

            neuerFilm.Titel = kinofilmViewModel.NeuerFilm.Titel;
            neuerFilm.Genre = kinofilmViewModel.NeuerFilm.Genre;


            kinofilmViewModel.AddKinofilm(neuerFilm);

            
            this.Close();

        }
    }
}
