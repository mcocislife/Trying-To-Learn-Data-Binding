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

namespace trial5.Folder1.Folder2
{

    public partial class SecondUserControl : UserControl
    {
        private Variables vars = new Variables();

        public SecondUserControl()
        {
            InitializeComponent();

            LabelText.Content = "Your Text from the First User Control is: " + vars.TextBoxContent + "and the button you clicked is: " + vars.ButtonClickedContent;
        }
    }
}
