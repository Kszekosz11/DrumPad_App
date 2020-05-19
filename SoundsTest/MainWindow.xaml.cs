using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
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
        PathFiles pathFiles;
        Tags tags;

        public int index;

        SoundPlayer soundPlayer;

        public MainWindow()
        {
            InitializeComponent();
            pathFiles = new PathFiles();
            tags = new Tags();

            soundPlayer = new SoundPlayer();

            DataContext = new WindowViewModel
            {
                DrumsSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] {"dr1", "dr2", "dr3", "dr4"}
                    }
                },
                GuitarSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "gt1", "gt2", "gt3", "gt4" }
                    }
                },
                FlutesSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] {"fl1", "fl2", "fl3", "fl4"}
                    }
                },
                PianoSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] {"pn1", "pn2", "pn3", "pn4"}
                    }
                },
                VoxSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] {"vx1", "vx2", "vx3", "vx4"}
                    }
                },
                FXSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] {"fx1", "fx2", "fx3", "fx4"}
                    }
                }
            };
        }
    }
}