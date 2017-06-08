﻿using System;
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
using trial3.View;

namespace trial3.View.Misc
{
    /// <summary>
    /// Interaction logic for Quantity.xaml
    /// </summary>
    public partial class Quantity : UserControl
    {
        private ObservableCollection<ListViewItems> QuantityEntry;
        private TempVariable ChoiceFinal;
        public Quantity()
        {
            InitializeComponent();
            SpinEditQuantity.Focus();
            QuantityEntry = new ObservableCollection<ListViewItems>();
            ChoiceFinal = new TempVariable();
        }

        private void QuantityButtonClick(object sender, RoutedEventArgs e)
        {
            QuantityEntry.Add(new ListViewItems { choice = "Choice " + ChoiceFinal, quantity = SpinEditQuantity.Text });
            Window.GetWindow(this).Close();
        }
    }
}