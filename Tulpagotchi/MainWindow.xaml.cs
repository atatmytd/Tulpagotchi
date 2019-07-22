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
                    //TestLabel.Content = "I loaded the saved player from " + player.fileLocation;
                }
                catch {
                    player = new Player();
                    Utilities.SetConfigValue("SavedUser", "");
                    //TestLabel.Content = "There was an error so I loaded a new player";
                }
            }
            else
            {
                player = new Player();
                //TestLabel.Content = "There was no new player to load";
            }
            
        }
        Player player;

        private bool UserSaved()
        {
            if (Utilities.GetConfigValue("SavedUser") == "") return false;
            else return true;
        }

    }
}
