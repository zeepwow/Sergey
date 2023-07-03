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

namespace Голов
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

        private void start_Click(object sender, RoutedEventArgs e)
        {
            int q = Convert.ToInt32(Number.Text);
            if (q > 12 || q < 0)
            {
                MessageBox.Show("В году 12 месяцев!");
            }
            else {
            if (q > 11 || q < 3)
                        {
                            MessageBox.Show("Зима");
                        }
                        else
                        {
                            if (q > 2 && q < 6)
                            {
                                MessageBox.Show("Весна");
                            }
                            else
                            {
                                if (q > 5 && q < 9)
                                {
                                    MessageBox.Show("Лето");
                                }
                                else
                                {
                                    MessageBox.Show("Осень");
                                }
                            }
            }
            
            }
        }
    }
}
