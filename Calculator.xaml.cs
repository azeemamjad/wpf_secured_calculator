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

namespace class_work_wpf
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = (Convert.ToDouble(number1.Text) + Convert.ToDouble(number2.Text)).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            answer.Text = (Convert.ToDouble(number1.Text) - Convert.ToDouble(number2.Text)).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            answer.Text = (Convert.ToDouble(number1.Text) * Convert.ToDouble(number2.Text)).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            answer.Text = (Convert.ToDouble(number1.Text) / Convert.ToDouble(number2.Text)).ToString();
        }
    }
}
