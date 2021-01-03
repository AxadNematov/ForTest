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

namespace WpfApplication11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        lcdatabaseTestEntities _db = new lcdatabaseTestEntities();
        public static DataGrid datagrid;
        int selectedId = 0;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            myDatagrid.ItemsSource = _db.people.ToList();
            datagrid = myDatagrid;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            person p = new person()
            {
                age = age.Text,
                name = name.Text,
                surname = surname.Text,
                mail = mail.Text,
                phone = phone.Text
            };
            _db.people.Add(p);
            _db.SaveChanges();
            datagrid.ItemsSource = _db.people.ToList();
            name.Text = "";
            surname.Text = "";
            age.Text = "";
            phone.Text = "";
            mail.Text = "";
        }

        private void myDatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myDatagrid.SelectedItem != null)
            {
                selectedId = Convert.ToInt32((myDatagrid.SelectedItem as person).id);
                name.Text = (myDatagrid.SelectedItem as person).name;
                surname.Text = (myDatagrid.SelectedItem as person).surname;
                age.Text = (myDatagrid.SelectedItem as person).age;
                phone.Text = (myDatagrid.SelectedItem as person).phone;
                mail.Text = (myDatagrid.SelectedItem as person).mail;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            person update = (from m in _db.people
                             where m.id == selectedId
                             select m).Single();
            update.name = name.Text;
            update.surname = surname.Text;
            update.age = age.Text;
            update.phone = phone.Text;
            update.mail = mail.Text;
            _db.SaveChanges();
            myDatagrid.ItemsSource = _db.people.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delete = _db.people.Where(m => m.id == selectedId).Single();
            _db.people.Remove(delete);
            _db.SaveChanges();
            myDatagrid.ItemsSource = _db.people.ToList();
            myDatagrid.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            surname.Text = "";
            age.Text = "";
            phone.Text = "";
            mail.Text = "";
        }
    }
}
