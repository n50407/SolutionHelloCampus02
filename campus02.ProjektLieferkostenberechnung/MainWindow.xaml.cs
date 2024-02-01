using campus02.ProjektLieferkostenberechnung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace campus02.ProjektLieferkostenberechnung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lieferkosten lieferkostenDataContext = null;
        public MainWindow()
        {
            InitializeComponent();

            lieferkostenDataContext = new Lieferkosten();
            this.DataContext= lieferkostenDataContext;
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            RepeatButton repeatButton = sender as RepeatButton;
            if (repeatButton.Content.ToString() == "+")
            {
                lieferkostenDataContext.Gesamtgewicht++;
                
            }
            else
            {
                lieferkostenDataContext.Gesamtgewicht--;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lieferkostenDataContext.Laender.Add("IT");
        }
    }
}
