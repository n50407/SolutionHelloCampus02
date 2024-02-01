using DatabindingSample.Models;
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

namespace DatabindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProductViewModel viewModel = new ProductViewModel();


            //Datenkontext auf ein Produkt setzen
            Product myProduct = new Product();
            myProduct.ProductId= 1;
            myProduct.Productname = "Bleistift";
            myProduct.Price = 1.99m;

            myProduct =new Product() {
                ProductId = 2,
                Productname = "Radiergummi",
                Price = 0.99m,
            Color="Yellow",
            Expired=true};

            viewModel.MyProduct = myProduct;
            viewModel.MyFirstname = "Johann";

            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product myProduct = this.DataContext as Product;
            var currentPrice = myProduct.Price;

            myProduct.Price = currentPrice + 10;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Title = "";
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "You clicked the butterfly";
            e.Handled= true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var myViewModel = this.DataContext as ProductViewModel;
            myViewModel.MyFirstname = "anonym";

        }

        private void Button_NewWeekday(object sender, RoutedEventArgs e)
        {
            var myViewModel = this.DataContext as ProductViewModel;
            myViewModel.Wochentagen.Add("Samstag");
        }
    }
}
