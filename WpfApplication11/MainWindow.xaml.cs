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
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

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
                //richTextBox.AppendText("gafdhgajvhbkjwn kjcnwenlkcwe;k ewjhbcjwlecw sjvhechwbiuj");
                
            }
        }
        
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".doc";
            dlg.Filter = "Word documents (.doc)|*.docx";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                if (dlg.FileName.Length > 0)
                {
                    richTextBox.Document.Blocks.Clear();
                    //richTextBox.AppendText(dlg.FileName+"\n");
                    Document document = new Document();
                    document.LoadFromFile(dlg.FileName);
                    richTextBox.AppendText(document.GetText());
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
