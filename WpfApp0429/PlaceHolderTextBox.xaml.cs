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

namespace WpfApp0429
{
    /// <summary>
    /// Interaction logic for PlaceHolderTextBox.xaml
    /// </summary>
    public partial class PlaceHolderTextBox : UserControl
    {


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(PlaceHolderTextBox));



        public bool AcceptReturn
        {
            get { return (bool)GetValue(AcceptReturnProperty); }
            set { SetValue(AcceptReturnProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AcceptReturn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AcceptReturnProperty =
            DependencyProperty.Register("AcceptReturn", typeof(bool), typeof(PlaceHolderTextBox));




        public string PlaceHolderText
        {
            get { return (string)GetValue(PlaceHolderTextProperty); }
            set { SetValue(PlaceHolderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderTextProperty =
            DependencyProperty.Register("PlaceHolderText", typeof(string), typeof(PlaceHolderTextBox));




        public PlaceHolderTextBox()
        {
            InitializeComponent();
        }
    }
}
