﻿using System;
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

namespace onlyCAPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsLetter(e.Text,0) && e.Text[0].ToString() == e.Text[0].ToString().ToUpper())
            {
                return;
            }
            e.Handled = true;
        }
    }
}