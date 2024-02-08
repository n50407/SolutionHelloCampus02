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
    /// Interaction logic for WindowNewGenre.xaml
    /// </summary>
    public partial class WindowNewGenre : Window
    {
        public WindowNewGenre()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KinofilmViewModel vm=this.DataContext as KinofilmViewModel;
            if (vm != null)
            {
                vm.AddNewGenre(vm.NeuesGenre);
                this.Close();
            }
        }
    }
}
