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

namespace zapis_na_kryzhok
{
    /// <summary>
    /// Логика взаимодействия для Mainpage.xaml
    /// </summary>
    public partial class Mainpage : Page
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void Teachers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Teachers());
        }
        private void Signs(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Signs());
        }
        private void Tariffs(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tariffs());
        }
    }
}
