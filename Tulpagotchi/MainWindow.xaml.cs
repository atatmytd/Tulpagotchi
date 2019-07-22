using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Tulpagotchi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if(UserSaved())
            {
                try
                {
                    string configVal = Utilities.GetConfigValue("SavedUser");
                    player = Player.LoadPlayer(configVal);
                }
                catch {
                    player = new Player();
                    Utilities.SetConfigValue("SavedUser", "");
                }
            }
            else
            {
                player = new Player();
            }
            
        }
        Player player;

        private bool UserSaved()
        {
            if (Utilities.GetConfigValue("SavedUser") == "") return false;
            else return true;
        }

        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            LoadBattlePage();
        }
        private void LoadBattlePage()
        {
            BattleOptions.Visibility = Visibility.Collapsed;
            FightButton.Visibility = Visibility.Collapsed;

            BattleWords.Visibility = Visibility.Visible;
            BattleImpage.Visibility = Visibility.Visible;
            BattleControls.Visibility = Visibility.Visible;
        }

        private void AbandonBattle_Click(object sender, RoutedEventArgs e)
        {
            LoadDashboard();
        }

        private void EndBattle_Click(object sender, RoutedEventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            BattleOptions.Visibility = Visibility.Visible;
            FightButton.Visibility = Visibility.Visible;

            BattleWords.Visibility = Visibility.Collapsed;
            BattleImpage.Visibility = Visibility.Collapsed;
            BattleControls.Visibility = Visibility.Collapsed;
        }
    }
}
