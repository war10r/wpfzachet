using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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
using System.Xml.Linq;
using zapis_na_kryzhok.database;

namespace zapis_na_kryzhok
{
    /// <summary>
    /// Логика взаимодействия для AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : Page
    {

        private Database dataBase;
        public AddTeacher()
        {
            InitializeComponent();

            var dbContext = new eremeev_zachet();
            dataBase = new Database(dbContext);
        }

        private async void AddIntoDB(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string surname = surnameBox.Text;
            string email = emailBox.Text;
            string phoneNumber = phoneBox.Text;


            await dataBase.SaveTeacher(name, surname, email, phoneNumber);
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
