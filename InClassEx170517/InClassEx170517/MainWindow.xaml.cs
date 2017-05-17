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

namespace InClassEx170517
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

        private void Roller_Click(object sender, RoutedEventArgs e)
        {
            int diceField = 0;
            int sidesField = 0;
            int mod = 0;
            if (int.TryParse(NumOfDiceField.Text, out diceField))
            {
                diceField = (diceField < 0) ? 0 : diceField;
            }
            if (int.TryParse(NumOfSidesField.Text, out sidesField))
            {
                sidesField = (sidesField < 0) ? 0 : sidesField;
            }
            if (int.TryParse(ModField.Text, out mod))
            { 
                mod = (mod < 0) ? 0 : mod;
            }

            TotalLabel.Content = diceRoll(diceField, sidesField) + mod;
        }
        public int diceRoll(int dice, int sides)
        {
            if(dice == 0 || sides == 0)
            {
                return 0;
            }
            else
            {
                Random rando = new Random();
                int result = 0;
                for (int i = 0; i < dice; i++)
                {
                    result += rando.Next(sides) + 1;
                }
                return result;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            NumOfDiceField.Clear();
            NumOfSidesField.Clear();
            ModField.Clear();
            TotalLabel.Content = null;
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Random rando = new Random();
            NumOfDiceField.Text = rando.Next((9) + 1).ToString();
            NumOfSidesField.Text = rando.Next((9) + 1).ToString();
            ModField.Text = rando.Next((9) + 1).ToString();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        /*
* You are building a dice roller. The formula for dice is usually expressed as xDy + z,
* where x is the number of dice being rolled, y is the number of sides per die,
* and z is any modifier. So, 3d6 + 5 means you roll three six-sided dice, add them
* together, then add five for the final total.
* 
* Your Job:
* Add the code necessary to meet the following requirements:
* 1) When "Roll Dice" is clicked, use the Text property in NumOfDiceField and
*      NumOfSidesField to generate a random number.
* 2) Add the mod to the random number.
* 3) Note that if any TextBox is empty or contains invalid data, it counts as a value of 0.
* 4) Display the final total in the Content property of the TotalLabel.
* 5) When Reset is clicked, empty out the Label and all three TextBoxes.
*/
    }
}
