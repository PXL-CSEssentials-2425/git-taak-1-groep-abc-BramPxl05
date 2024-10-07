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

namespace WpfAppGitTaak
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Yellow;


        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Blue;
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }
    }
}
