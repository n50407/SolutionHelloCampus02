using HelloCampus02.Models;
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

namespace HelloCampus02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = $"Heute ist der {DateTime.Now.ToString()}";
            this.DataContext = "Hello Freitag";

            this.DataContext=new List<string>() { "Cheda","Victoria"};

            Sitzplan sitzplan = new Sitzplan();
            sitzplan.Reihe1 = new List<string>() { "Sofia","Myla"};
            sitzplan.Reihe2 = new List<string>() { "Ksenija", "Nora","Kata" };
            sitzplan.Reihe3 = new List<string>() { "Jana", "Yasmine" };

            sitzplan.Farbe1 = "Purple";
            sitzplan.Farbe2 = "Yellow";
            sitzplan.Farbe3 = "Blue";

            this.DataContext = sitzplan;




        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            //aktuelle Uhrzeit im Titel anzeigen
            this.Title = DateTime.Now.ToString();
            


        }

        //Eventhandler-Signatur in C#
        //1. Argument ist der Sender
        //2. Argument ist das Event-Argument
        private void onChange(object sender, SelectionChangedEventArgs e)
        {
            //Versuch den sender in eine Listbox zu casten
            ListBox myListbox = sender as ListBox;
            //wenn der Cast erfolgreich war 
            if (myListbox != null)
            {
                //den Titel der Anwendung auf den Inhalt der Listbox setzen
                this.Title = ((ListBoxItem) myListbox.SelectedItem).Content.ToString();

             
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox myComboBox = sender as ComboBox;
            string ausgewaehlteFarbe = ((ComboBoxItem) myComboBox.SelectedItem).
                Content.ToString();
            
            switch (ausgewaehlteFarbe)
            {
                case "Red":
                    this.Background = Brushes.Red;
                    break;
                case "Blue":
                    this.Background = Brushes.Blue;
                    break;
                default:
                    break;
            }            
            SolidColorBrush myBrush = (SolidColorBrush)new BrushConverter().
                ConvertFromString(ausgewaehlteFarbe);
            myBrush = (SolidColorBrush)new BrushConverter().
                ConvertFrom("#FF0011");
            this.Background = myBrush;

       
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {// https://github.com/n50407/SolutionHelloCampus02
            //wenn ToggleButton gedrückt dann soll die Hintergrundfarbe dukelblau sein ansonsten hellblau
          ToggleButton toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {
                if (toggleButton.IsChecked == true)
                {
                    this.Background = Brushes.DarkBlue;
                }
                else
                {
                    this.Background = Brushes.LightBlue;
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sitzplan sitzplan=this.DataContext as Sitzplan;
            var eingegebeneReihe = sitzplan.EingabeReihe;
            switch(eingegebeneReihe)
            {
                case 1:
                    sitzplan.Farbe1 = "Green";
                    break;
                case 2:
                    sitzplan.Farbe2 = "Green";
                    break;
                default:
                    sitzplan.Farbe3 = "Green";
                    break;
            }

        }
    }
}
