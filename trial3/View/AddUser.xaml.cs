using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using trial3.Model;


namespace trial3.View
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        private TempVariable ChoiceHere;
        public AddUser()
        {
            InitializeComponent();
        }

        private void ChoiceOneClick(object sender, RoutedEventArgs e)
        {
            ChoiceHere = new TempVariable { TempChoice = "1" };
            Window window = new Window
            {
                Title = "Quantity",
                Content = new Misc.Quantity(ChoiceHere),
                Height = 300,
                Width = 500,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize
            };
            window.ShowDialog();
        }

        private void ChoiceTwoClick(object sender, RoutedEventArgs e)
        {
            ChoiceHere = new TempVariable { TempChoice = "2" };
            Window window = new Window
            {
                Title = "Quantity",
                Content = new Misc.Quantity(ChoiceHere),
                Height = 300,
                Width = 500,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize
            };
            window.ShowDialog();
        }
    }
}
