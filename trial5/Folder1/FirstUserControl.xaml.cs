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
using trial5.Folder1.Folder2;

namespace trial5.Folder1
{

    public partial class FirstUserControl : UserControl
    {
        private Variables vars;

        public FirstUserControl()
        {
            InitializeComponent();
        }

        private void FirstButtonClick(object sender, RoutedEventArgs e)
        {
            vars = new Variables { TextBoxContent = TextBoxName.Text , ButtonClickedContent = "1" };

            Window window = new Window
            {
                Title = "Quantity",
                Content = new SecondUserControl(),
                Width = 600,
                Height = 250,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize
            };
            window.ShowDialog();
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e)
        {
            vars = new Variables { TextBoxContent = TextBoxName.Text, ButtonClickedContent = "2" };

            Window window = new Window
            {
                Title = "Quantity",
                Content = new SecondUserControl(),
                Width = 600,
                Height = 250,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize
            };
            window.ShowDialog();
        }
    }
}
