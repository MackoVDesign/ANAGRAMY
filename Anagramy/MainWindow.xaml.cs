using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Anagramy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent(); 
            DataContext= this;  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string slowo1 = pierwsze_slowo.Text;

            string slowo2 = drugie_slowo.Text;

            Anagram anagram = new Anagram(slowo1, slowo2);
            if (anagram.Check_click())
            {
                MessageBox.Show("Tak są Anagramami");
            }
            else
            {
                MessageBox.Show("Nie są Anagramami");
            }

        }
    }
}
