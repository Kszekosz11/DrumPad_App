using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using WMPLib;

namespace SoundsTest
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        IWMPMedia media;
        IWMPPlaylist playlist = mediaPlayer.playlistCollection.newPlaylist("myPlayList");

        SoundPlayer soundPlayer;

        public static string[] drumsLocation;
        public static string[] guitarLocation;
        public static string[] hiphopLocation;
        public static string[] hipHopBaseLocation;

        string[] allEffects;

        public MainWindow()
        {
            InitializeComponent();

            hipHopBaseLocation = new string[(int)EffectsQuantity.hipHopBeats];
            drumsLocation = new string[(int)EffectsQuantity.drums];
            guitarLocation = new string[(int)EffectsQuantity.guitar];
            hiphopLocation = new string[(int)EffectsQuantity.hipHop];

            SetPathEffects();
            
            allEffects = new List<string>()
                .Concat(hipHopBaseLocation)
                .Concat(drumsLocation)
                .Concat(guitarLocation)
                .Concat(hiphopLocation)
                .ToArray();

            soundPlayer = new SoundPlayer();                        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());
            test.Text = tag.ToString();
            soundPlayer.SoundLocation = allEffects[tag];
            soundPlayer.Play();            
        }

        private void Button_PlayMusic(object sender, RoutedEventArgs e)
        {                       
            mediaPlayer.controls.play();
        }

        private void Badged_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());            

            media = mediaPlayer.newMedia("Effects/BaseHipHop/hipHop (" + tag.ToString() + ").wav");
            playlist.appendItem(media);
            mediaPlayer.currentPlaylist = playlist;
        }

        private void SetPathEffects()
        {
            for (int i = 0; i < hipHopBaseLocation.Length; i++)
            {
                hipHopBaseLocation[i] = "Effects/BaseHipHop/hipHop (" + i.ToString() + ").wav";
            }

            for (int i = 0; i < drumsLocation.Length; i++)
            {
                drumsLocation[i] = "Effects/Drums/drums (" + i.ToString() + ").wav";
            }

            for (int i = 0; i < guitarLocation.Length; i++)
            {
                guitarLocation[i] = "Effects/Guitar/guitar (" + i.ToString() + ").wav";
            }

            for (int i = 0; i < hiphopLocation.Length; i++)
            {
                hiphopLocation[i] = "Effects/HipHop/hipHop (" + i.ToString() + ").wav";
            }
        }
    }
}