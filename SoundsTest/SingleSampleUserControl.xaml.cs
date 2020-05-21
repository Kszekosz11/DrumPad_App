using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        WindowsMediaPlayer samplePlayer = new WindowsMediaPlayer();
        PathFiles pathFiles;
        private int SampleTag;

        public UserControlSamples()
        {
            InitializeComponent();
            pathFiles = new PathFiles();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            samplePlayer.enabled = true;
            SampleTag = int.Parse((sender as Control).Tag.ToString());
            samplePlayer.URL = pathFiles.allEffects[SampleTag];
            samplePlayer.settings.setMode("loop", true);
            samplePlayer.controls.play();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            samplePlayer.settings.volume = (int)SliderVolume.Value;
        }
    }
}