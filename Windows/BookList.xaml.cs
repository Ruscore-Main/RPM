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
using System.Windows.Shapes;

namespace RPM_practice.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookList.xaml
    /// </summary>
    public partial class BookList : Window
    {
        private MainWindow _mainWindow;
        private BoolBDEntities _context = new BoolBDEntities();
        public BookList(MainWindow mainWindow)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
            DataListBooks.ItemsSource = _context.BookSet.ToList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                this.Close();
            }
        }
    }
}
