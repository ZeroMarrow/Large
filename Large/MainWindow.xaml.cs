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

namespace Large
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

        private void r1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n = int.Parse(r1.Text);
            if (n >= 1 || n <= 31) ;
            else Console.WriteLine("Не так");
        }

        private void R1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            int y = int.Parse(R1.Text);
            if (y == 1 && y== 2 && y== 3 && y==4 && y == 5 && y == 6 && y == 7 && y == 8 && y == 9 && y == 10 && y == 11 && y == 12);
            else Console.WriteLine("Ошибка");
            }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            int g = int.Parse(Z1.Text);
            switch (g)
            {
                case 1: 
            }
        }
    }
}
