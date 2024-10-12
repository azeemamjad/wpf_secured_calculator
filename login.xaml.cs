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

namespace class_work_wpf
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        Calculator c;
        MainWindow window;
        public login(Calculator c, MainWindow window)
        {
            InitializeComponent();
            this.c = c;
            this.window = window;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                MessageBox.Show("Success!");
                window.mainview.Content = c;
            }
        }
    }
}
