using AufgabeTicketbestellung.Models;
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

namespace AufgabeTicketbestellung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Ticketbestellung bestellung = new Ticketbestellung();
            bestellung.setMaxTicketAnzahl(12); //Java Variante
            bestellung.CSharpMaxTicketAnzahlVariante1 = 12; //Prop-C#

            this.DataContext = bestellung;

        }
    }
}
