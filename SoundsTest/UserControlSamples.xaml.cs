using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;

namespace SoundsTest
{
    /// <summary>
    /// Logika interakcji dla klasy ButtonLayout.xaml
    /// </summary>
    public partial class UserControlSamples : UserControl
    {
        SoundPlayer soundPlayer;        
        PathFiles pathFiles;
        int tag;

        //static WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        //IWMPMedia media;
        //IWMPPlaylist playlist = mediaPlayer.playlistCollection.newPlaylist("myPlayList");


        public UserControlSamples()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer();            
            pathFiles = new PathFiles();

            DataContext = "ef1";
        }

        private void ButtonAddSampleToMedia_Click(object sender, RoutedEventArgs e)
        {
            soundPlayer.Stop();

            SoundPlayer soundPlayer1 = new SoundPlayer();

            tag = int.Parse((sender as Control).Tag.ToString());
            soundPlayer1.SoundLocation = pathFiles.allEffects[tag];
            soundPlayer1.PlayLooping();            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());

            soundPlayer.SoundLocation = pathFiles.allEffects[tag].ToString();
            soundPlayer.PlayLooping();
        }
    }
}