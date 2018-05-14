using Microsoft.Win32;
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

namespace ResearchForOffice
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
        private void FileOpenButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "ファイルを開く";
            dialog.Filter = "ワードファイル|*.doc;*.docx";
            dialog.Filter = "エクセルファイル|*.xls;*.xlsx";
            dialog.Filter = "全てのファイル(*.*)|*.*";
            if (dialog.ShowDialog().Value)
            {
                this.textBlockFileName.Text = dialog.FileName;
            }
            else
            {
                this.textBlockFileName.Text = "キャンセルされました";
            }
        }
    }
}
