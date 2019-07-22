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
        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            LoadNewUser();
        }
        private void LoadNewUser()
        {
            player = Player.MakeNewPlayer(Utilities.ChooseFileLocation("tlpg", "Tulpagotchi", "Player"));
            player.SaveFile();
            Utilities.SetConfigValue("SavedUser", player.fileLocation);
            //TestLabel.Content = "I made a new player & saved it at " + player.fileLocation;
        }
        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenExistingUser();
        }
        private void OpenExistingUser()
        {
            player = Player.LoadPlayer(Utilities.GetFileLocation("tlpg", "Tulpagotchi"));
            Utilities.SetConfigValue("SavedUser", player.fileLocation);
            //TestLabel.Content = "I opened the player at " + player.fileLocation + " and saved it";
        }
        private void MenuItem_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveUser();
        }
        private void SaveUser()
        {

            if (player.fileLocation == "")
            {
                try
                {
                    SaveAs();
                }
                catch { //TestLabel.Content = "The player wasn't saved but I was able to save the player at " + player.fileLocation; 

                }
            }
            else
            {
                player.SaveFile();

                //TestLabel.Content = "Saved the player file at " + player.fileLocation;
            }
        }
        private void MenuItem_SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveAs();
        }
        private void SaveAs()
        {
            string newFile = Utilities.ChooseFileLocation("tlpg", "Tulpagotchi", "Player");
            player.SaveAs(newFile);
            Utilities.SetConfigValue("SavedUser", newFile);

            //TestLabel.Content = "The file was saved at " + newFile;
        }
        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuItem_Preferences_Click(object sender, RoutedEventArgs e) //TO DO
        {
            MessageBox.Show("TO DO - add a window to update file locations, set color schemes, and reset pet progress");
        }
    }
}
