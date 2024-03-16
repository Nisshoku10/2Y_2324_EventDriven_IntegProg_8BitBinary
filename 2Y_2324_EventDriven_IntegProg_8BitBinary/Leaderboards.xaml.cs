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

namespace _2Y_2324_EventDriven_IntegProg_8BitBinary
{
    /// <summary>
    /// Interaction logic for Leaderboards.xaml
    /// </summary>
    public partial class Leaderboards : Window
    {
        public Leaderboards()
        {
            InitializeComponent();

            // Define the columns
            //List<GridViewColumn> columns = new List<GridViewColumn>();
            //columns.Add(new GridViewColumn { Header = "Name" });
            //columns.Add(new GridViewColumn { Header = "Age"});
            //columns.Add(new GridViewColumn { Header = "City"});

            //// Add some data
            //Leaderboards.Items.Add(new { Name = "John", Age = 25, City = "New York" });
            //Leaderboards.Items.Add(new { Name = "Jane", Age = 30, City = "Los Angeles" });
            //Leaderboards.Items.Add(new { Name = "Tom", Age = 22, City = "Chicago" });
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
