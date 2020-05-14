using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        IWMPMedia media;
        IWMPPlaylist playlist = mediaPlayer.playlistCollection.newPlaylist("myPlayList");

        //SoundPlayer soundPlayer;
        PathFiles pathFiles;

        public int index;

        public MainWindow()
        {
            InitializeComponent();
            pathFiles = new PathFiles();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = TabControlSamples.SelectedIndex;

            switch (index)
            {
                case 0:
                    this.DataContext = new ViewModel
                    {
                        SampleName = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
                    };
                    break;
                case 1:
                    this.DataContext = new ViewModel
                    {
                        SampleName = new string[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" }
                    };
                    break;
                case 2:
                    this.DataContext = new ViewModel
                    {
                        SampleName = new string[] { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29" }
                    };
                    break;
                case 3:
                    this.DataContext = new ViewModel
                    {
                        SampleName = new string[] { "30", "31", "32", "33", "34", "35", "36", "37", "38", "39" }
                    };
                    break;
                default:
                    break;
            }
        }

        class ViewModel
        {
            public string[] SampleName { get; set; }
            public string[] Path { get; set; }
            public int Index { get; set; }
        }        

        public void ButtonSample_Click(object sender, RoutedEventArgs e)
        {
            //int tag = int.Parse((sender as Control).Tag.ToString());
            //test.Text = tag.ToString();
            //soundPlayer.SoundLocation = pathFiles.allEffects[tag];
            //soundPlayer.Play();
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
    }
}