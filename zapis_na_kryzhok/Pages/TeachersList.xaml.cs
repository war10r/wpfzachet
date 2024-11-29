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
using zapis_na_kryzhok.database;

namespace zapis_na_kryzhok.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeachersList.xaml
    /// </summary>
    public partial class TeachersList : Page
    {
        public TeachersList()
        {
            InitializeComponent();
            
            var data = Connect.conn.Teacher.ToList();
            TeachersGrid.ItemsSource = data;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
