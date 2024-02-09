using SampleWPFmitEF.Models;
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

namespace SampleWPFmitEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //1NUGET: EntityFramework -- Tools -- NuGet Package Manager -- Package Manager Console
            //Install-Package EntityFramework
            //2. Model erstellen - class Sutdent { int Id {get;set;} string Name {get;set;} }
            //3. DBContext erstellen
        }

        private void Button_Click_NewStudent(object sender, RoutedEventArgs e)
        {
            Student std1 = new Student();
            std1.Name = "Mayla";

            Campus02DBContext db = new Campus02DBContext();
            db.Students.Add(std1);
            db.SaveChanges(); //Daten in die DB schreiben, Insert wird automatisch generiert

        }
    }
}
