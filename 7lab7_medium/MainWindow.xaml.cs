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

namespace _7lab7_medium
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<double> list;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(100);
            list = new List<double>();
            string str = "";
            for (int i = 0; i < n; i++)
            {
                list.Add(random.NextDouble() * 100);
                str += $"{list[i]:F2} ";
            }
            Result.Text = str;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -2 && i != 0)
                {
                    i -= 1;
                    list.Remove(i);
                    i += 1;
                }
            }
            list.Add(33);
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str += $"{list[i]:F2} ";
            }
            Result.Text = str;
        }
    }
}
