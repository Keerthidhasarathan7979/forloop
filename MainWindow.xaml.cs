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

namespace for_loop_project
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string print = "";
            for(int i=0; i<= 30;i= i+3)
            {
                if(print =="")
                {
                    print =  i.ToString();
                }
                else
                {
                    print = print + i.ToString();
                }
               
            }
            MessageBox.Show(print);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int inta = Convert.ToInt32(txtnumber.Text);
            int increment = Convert.ToInt32(txtincrement.Text);
            int final = Convert.ToInt32(txtlast.Text);

            string print = "";
            for (int j = inta; j >increment  ; j = j - final)
            {
                if (print == "")
                {
                    print = j .ToString();
                }
                else
                {
                    print = print + j.ToString();
                }

            }
            MessageBox.Show(print);
        }
    }
    }

