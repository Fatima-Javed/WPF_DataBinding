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

namespace Database_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee emp = new Employee { FirstName = "Fatima", LastName = "Javed", ContactNo = "03130533183", Address = "APF Colony", WarehouseNo = "1234", WarehouseName = "Kamra" };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = emp;
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string ContactNo { get; set; }
            public string Address { get; set; }

            public string WarehouseNo { get; set; }
            public string WarehouseName { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush mybrush = Brushes.Blue;
            this.Resources["brushes"] = mybrush;
          
        }
    }
}
