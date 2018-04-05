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

namespace Assignment_pt_2_4
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
        
        private void Bttn_Click(object sender, RoutedEventArgs e)
        {
                string TextBoxText = TxtInput.Text;
                int Time = 0;
                int.TryParse(TextBoxText, out Time);


                int Victory = Time - 300;
                int Edd = Time - 200;
                int Win = Time - 100;
                int H_A_L = Time + 100;
                int ST = Time + 130;

                if (Victory < 0)
                {
                    Victory += 2400;
                }

                if (Edd < 0)
                {
                    Edd += 2400;
                }

                if (Win > 2400)
                {
                    Win += 2400;
                }

                if (H_A_L > 2400)
                {
                    H_A_L -= 2400;
                }

                if (ST > 2400)
                {
                    ST -= 2400;
                }

                lblOutput.Content += Time + " in Ottawa" + "\r" + "\r";
            lblOutput.Content += Time + " in Toronto" + "\r" + "\r";
            lblOutput.Content += Edd + " in Edmonton" + "\r" + "\r";
            lblOutput.Content += H_A_L + " in Halifax" + "\r" + "\r";
            lblOutput.Content += Victory + " in Victoria" + "\r" + "\r";
            lblOutput.Content += Win + " in Winnipeg" + "\r" + "\r";
            lblOutput.Content += ST + "in St John's" + "\r" + "\r";
        }
        }
    }




