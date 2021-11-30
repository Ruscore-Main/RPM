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

namespace RPM_practice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookList_Click(object sender, RoutedEventArgs e)
        {
            Windows.BookList bookList = new Windows.BookList(this);
            this.Hide();
            bookList.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selection = Convert.ToString(CmbBackgroundColor.SelectedItem);
            SolidColorBrush backgroundColor = this.TryFindResource("BackgroundColor") as SolidColorBrush;
            switch (selection)
            {
                case "Светлый":
                    {
                        backgroundColor.Color = Colors.White;
                        break;
                    }
                case "Темный":
                    {
                        backgroundColor.Color = Colors.DarkGray;
                        break;
                    }
                case "Красочный":
                    {
                        backgroundColor.Color = Colors.OrangeRed;
                        break;
                    }
            }
        }

        private void FeedBack_Click(object sender, RoutedEventArgs e)
        {
            Windows.FeedBack feedBack = new Windows.FeedBack();
            feedBack.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3D моделька логотипа");
        }
    }
}
