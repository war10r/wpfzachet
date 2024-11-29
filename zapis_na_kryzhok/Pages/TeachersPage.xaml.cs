using System;
using zapis_na_kryzhok.Pages;
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
    /// Логика взаимодействия для Teachers.xaml
    /// </summary>
    public partial class Teachers : Page
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddTeacher(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTeacher());
        }

        private void TeacherList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeachersList());
        }
    }
}
