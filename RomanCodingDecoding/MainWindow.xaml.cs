using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace RomanCodingDecoding
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
        // global

        private string GetChoice()
        {
            string choice = "";
            if (RomanToNumRB.IsChecked == true)
            {
                choice = "Romans";
            }
            if (NumToRomanRB.IsChecked == true)
            {
                choice = "Numbers";
            }
            return choice;
        }

        private int Encode(String Roman)
        {
            return 0;
        }
        private string Decode(int num)
        {
            string roman = "";
            string[] thousand = { "", "M", "MM", "MMM", "MV","V","VM","VMM","VMMM" };
            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            roman += thousand[(num / 1000) % 10];
            roman += hundred[(num / 100) % 10];
            roman += ten[(num / 10) % 10];
            roman += one[num % 10];

            return roman;
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            string gottenChoice = GetChoice();
            string value = EneteredLabel.Text;

            switch (gottenChoice)
            {
                case "Romans":
                    break;
                case "Numbers":
                    int NumToDec = int.Parse(value);
                    ResultBox.Text = Decode(NumToDec);
                    break;
                default:
                    break;
            }

        }

        private void RomanToNumRB_Click(object sender, RoutedEventArgs e)
        {
            InfoLabel.Content = "Введите римские цифры";
            EneteredLabel.IsEnabled = true;
        }

        private void NumToRomanRB_Click(object sender, RoutedEventArgs e)
        {
            InfoLabel.Content = "Введите обычные цифры";
            EneteredLabel.IsEnabled = true;
        }
    }
}
