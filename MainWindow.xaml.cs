using CarswithSQLDatabase.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarswithSQLDatabase.Models;

namespace CarswithSQLDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CRUD crud = new CRUD();

        private Car selectedCar; 
        public MainWindow()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            dgCars.ItemsSource = null;
            dgCars.ItemsSource = crud.GetAllCars();
        }

        private void Clear()
        {
            txtVIN.IsEnabled = true;

            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();

            dgCars.SelectedItem = null;
            selectedCar = null; 
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Car newCar = new Car 
            { 
                VIN = txtVIN.Text,
                Make = txtMake.Text,
                Model = txtModel.Text, 
                Year = int.Parse(txtYear.Text),
                Price = double.Parse(txtPrice.Text)
            
            };

            crud.AddCar(newCar);
            LoadCars();
            Clear();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if(selectedCar == null)
            {
                MessageBox.Show("Please select a car.");
                return;
            }

            Car car = new Car
            {
                VIN = txtVIN.Text,
                Make = txtMake.Text,
                Model = txtModel.Text,
                Year = int.Parse(txtYear.Text),
                Price = double.Parse(txtPrice.Text)
            };

            crud.UpdateCar(selectedCar.VIN, car);
            LoadCars();
            Clear();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(selectedCar == null)
            {
                MessageBox.Show("Please select a car");
                return;
            }

            MessageBoxResult result = MessageBox.Show(
                $"Delete car: {selectedCar.Make} {selectedCar.Model}?",
                "Confirm Delete",
                MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                crud.DeleteCar(selectedCar.VIN);
                LoadCars();
                Clear();
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void dgCars_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            selectedCar = dgCars.SelectedItem as Car;

            if (selectedCar == null)
                return;

            txtVIN.Text = selectedCar.VIN;
            txtMake.Text = selectedCar.Make;
            txtModel.Text = selectedCar.Model;
            txtYear.Text = selectedCar.Year.ToString();
            txtPrice.Text = selectedCar.Price.ToString();

            txtVIN.IsEnabled = false;
        }

        
    }
}