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

namespace SoundsTest
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer drumsPlayer;
        SoundPlayer guitarPlayer;
        SoundPlayer hiphopPlayer;
        SoundPlayer hipHopBasePlayer;
        string[] drums;
        string[] guitar;
        string[] hiphop;
        string[] hipHopBase;
        string list;
        public MainWindow()
        {
            InitializeComponent();

            drums = new string[(int)EffectsQuantity.drums];
            guitar = new string[(int)EffectsQuantity.guitar];
            hiphop = new string[(int)EffectsQuantity.hiphop];
            hipHopBase = new string[26];

            drumsPlayer = new SoundPlayer();
            guitarPlayer = new SoundPlayer();
            hiphopPlayer = new SoundPlayer();
            hipHopBasePlayer = new SoundPlayer();

            for (int i = 0; i < drums.Length; i++)
            {
                drums[i] = "Effects/Drums/drums" + i.ToString() + ".wav";
            }

            for (int i = 0; i < guitar.Length; i++)
            {
                guitar[i] = "guitar" + i.ToString() + ".wav";
            }

            for (int i = 0; i < hiphop.Length; i++)
            {
                hiphop[i] = "hiphop" + i.ToString() + ".wav";
            }

            for (int i = 0; i < hipHopBase.Length; i++)
            {
                hipHopBase[i] = "Effects/BaseHipHop/hipHop (" + i.ToString() + ").wav";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());
            drumsPlayer.SoundLocation = "Effects/Drums/drums" + tag.ToString() + ".wav"; //= new SoundPlayer(drums[tag]);
            drumsPlayer.Play();            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());
            guitarPlayer.SoundLocation = "guitar" + tag.ToString() + ".wav"; //= new SoundPlayer(guitar[tag]);
            guitarPlayer.Play();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());
            hiphopPlayer.SoundLocation = "hiphop" + tag.ToString() + ".wav"; //= new SoundPlayer(hiphop[tag]);
            hiphopPlayer.Play();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());
            hipHopBasePlayer.SoundLocation = "Effects/BaseHipHop/hipHop (" + tag.ToString() + ").wav"; //= new SoundPlayer(hiphop[tag]);
            hipHopBasePlayer.Play();
        }
    }
}