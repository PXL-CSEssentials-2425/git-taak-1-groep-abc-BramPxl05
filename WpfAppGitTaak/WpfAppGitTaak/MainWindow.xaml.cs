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

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Black;
        }

        private void Image_MouseLeave_4(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }

       

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodebox.Text = "Rood:#FF0000";
            informatiebox.Text = "Rood is de kleur van warmte";
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            kleurcodebox.Text = "Geel:#FFFF00";
            informatiebox.Text = "Geel is de kleur van levenslust";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            kleurcodebox.Text = "Groen:#008000";
            informatiebox.Text = "Groen is de kleur van genezing";
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            kleurcodebox.Text = "Blauw:#0000FF";
            informatiebox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}
