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

namespace Szamologep
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
        
        private void Szamol(char muvelet)
        {
            double szam1 = Convert.ToDouble(txtSzam1.Text);
            double szam2 = Convert.ToDouble(txtSzam2.Text);

            if (muvelet == '+')
            {
                String eredmeny = $"{szam1} + {szam2} = {szam1 + szam2}";
                MessageBox.Show(eredmeny);
                lbHistory.Items.Insert(0, eredmeny);
                txtSzam1.Text = " ";
                txtSzam2.Text = " ";
            }
            else if (muvelet == '-')
            {
                String eredmeny = $"{szam1} - {szam2} = {szam1 - szam2}";
                MessageBox.Show(eredmeny);
                lbHistory.Items.Insert(0, eredmeny);
                txtSzam1.Text = " ";
                txtSzam2.Text = " ";
            }
            else if (muvelet == '*')
            {
                String eredmeny = $"{szam1} * {szam2} = {szam1 * szam2}";
                MessageBox.Show(eredmeny);
                lbHistory.Items.Insert(0, eredmeny);
                txtSzam1.Text = " ";
                txtSzam2.Text = " ";
            }
            else if (muvelet == '/')
            {
                String eredmeny = $"{szam1} / {szam2} = {szam1 / szam2}";
                MessageBox.Show(eredmeny);
                lbHistory.Items.Insert(0, eredmeny);
                txtSzam1.Text = " ";
                txtSzam2.Text = " ";
            }

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Szamol('+');
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Szamol('-');
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Szamol('*');
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            double szam1 = Convert.ToDouble(txtSzam1.Text);
            double szam2 = Convert.ToDouble(txtSzam2.Text);

            if (szam2 == 0)
            {
                MessageBox.Show("0-val való osztás nem értelmezhető!");
                lbHistory.Items.Insert(0, $"{szam1} / {szam2} = HIBA");
                txtSzam1.Text = " ";
                txtSzam2.Text = " ";
            }
            else
            {
                Szamol('/');
            }
        }

        private void lbHistory_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string full = lbHistory.SelectedItem.ToString();
            double szam1 = Convert.ToDouble(full.Split(" ")[0]);
            double szam2 = Convert.ToDouble(full.Split(" ")[2]);

            txtSzam1.Text = szam1.ToString();
            txtSzam2.Text = szam2.ToString();
        }
    }
}
