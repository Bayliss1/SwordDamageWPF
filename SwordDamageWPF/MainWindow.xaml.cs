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
using System.Diagnostics;

namespace SwordDamageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SwordDamage swordDamage = new SwordDamage();
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
        }

        public void ButtonRoll()
        {
            RollDice();
            SetEffects();
            DisplayDamage();
            Reset();
        }

        public void RollDice()
        {
            int i;
            for (i = 1; i < 4; i++)
            {
                swordDamage.Roll = random.Next(1, 7) + swordDamage.Roll;
            }
        }

        public void SetEffects()
        {
            swordDamage.SetMagic(magic.IsChecked.Value);
            swordDamage.SetFlaming(flaming.IsChecked.Value);
        }

        void DisplayDamage()
        {
            damage.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP";
        }

        public void Reset()
        {
            swordDamage.Roll = 0;
            swordDamage.Damage = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonRoll();
        }
    }
}
