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
            StudentsViewModel studentsViewModel = new StudentsViewModel();  
            this.DataContext = studentsViewModel;
        }

        private void Button_Click_NewStudent(object sender, RoutedEventArgs e)
        {
            
          

            //Campus02DBContext db = new Campus02DBContext();
            //db.Students.Add(std1);
            var vm= (StudentsViewModel)this.DataContext;
            Student std1 = new Student();
            std1.Name = vm.NewStudent.Name;
            vm.AddStudent(std1);
            //db.SaveChanges(); //Daten in die DB schreiben, Insert wird automatisch generiert

            //db.Students.ToList();
            //db.Students.Where(s => s.Name == "Mayla").ToList();
            //db.Students.Remove(std1);
            //db.Students.Find(1);


        }

        private void MenuItem_Click_SearchWindow(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.DataContext = this.DataContext;

            searchWindow.ShowDialog();  

        }
    }
}
