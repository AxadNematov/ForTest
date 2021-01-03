using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        public MainWindow()
        {
            InitializeComponent();
           
            for(int i=0; i<10; i++)
            {
                //richTextBox.AppendText("Axad Nematov Komilovich sdjnev rekvjnevno rekqjvnenvore\n");
                
            }
        }
        
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void myDatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".doc";
            dlg.Filter = "Word documents (.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                if (dlg.FileName.Length > 0)
                {
                    richTextBox.AppendText(dlg.FileName+"\n");
                    richTextBox.AppendText(File.ReadAllText(dlg.FileName));
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
