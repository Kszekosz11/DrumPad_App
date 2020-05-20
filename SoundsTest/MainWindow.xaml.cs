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
        public int index;

        WindowViewModel viewModel = new WindowViewModel();

        ObservableCollection<Visibility> obs1 = new ObservableCollection<Visibility> { Visibility.Collapsed };
        ObservableCollection<Visibility> obs2 = new ObservableCollection<Visibility> { Visibility.Visible };

        public MainWindow()
        {
            InitializeComponent();
            pathFiles = new PathFiles();

            viewModel = new WindowViewModel
            {
                DrumsSamples = new SamplesModel
                {
                    SampleName = pathFiles.drumsSamplesNames,
                    Tag = Tags.drums,
                    ShowVolume = Visibility.Collapsed
                }
                ,
                GuitarSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = pathFiles.guitarSamplesNames,
                        Tag = Tags.guitar,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                FlutesSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fl1", "fl2", "fl3", "fl4" },
                        Tag = Tags.flutes,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                PianoSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "pn1", "pn2", "pn3", "pn4" },
                        Tag = Tags.piano,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                VoxSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "vx1", "vx2", "vx3", "vx4" },
                        Tag = Tags.vox,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                FXSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fx1", "fx2", "fx3", "fx4" },
                        Tag = Tags.fx,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" }
            };

            DataContext = viewModel;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            viewModel = new WindowViewModel
            {
                DrumsSamples = new SamplesModel
                {
                    SampleName = pathFiles.drumsSamplesNames,
                    Tag = Tags.drums,
                    ShowVolume = Visibility.Visible
                }
                ,
                GuitarSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = pathFiles.guitarSamplesNames,
                        Tag = Tags.guitar,
                        ShowVolume = Visibility.Visible
                    }
                },
                FlutesSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fl1", "fl2", "fl3", "fl4" },
                        Tag = Tags.flutes,
                        ShowVolume = Visibility.Visible
                    }
                },
                PianoSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "pn1", "pn2", "pn3", "pn4" },
                        Tag = Tags.piano,
                        ShowVolume = Visibility.Visible
                    }
                },
                VoxSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "vx1", "vx2", "vx3", "vx4" },
                        Tag = Tags.vox,
                        ShowVolume = Visibility.Visible
                    }
                },
                FXSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fx1", "fx2", "fx3", "fx4" },
                        Tag = Tags.fx,
                        ShowVolume = Visibility.Visible
                    }
                },
                LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" }                
            };

            DataContext = viewModel;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel = new WindowViewModel
            {
                DrumsSamples = new SamplesModel
                {
                    SampleName = pathFiles.drumsSamplesNames,
                    Tag = Tags.drums,
                    ShowVolume = Visibility.Collapsed
                }
                ,
                GuitarSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = pathFiles.guitarSamplesNames,
                        Tag = Tags.guitar,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                FlutesSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fl1", "fl2", "fl3", "fl4" },
                        Tag = Tags.flutes,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                PianoSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "pn1", "pn2", "pn3", "pn4" },
                        Tag = Tags.piano,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                VoxSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "vx1", "vx2", "vx3", "vx4" },
                        Tag = Tags.vox,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                FXSamples = new SamplesModel[]
                {
                    new SamplesModel
                    {
                        SampleName = new string[] { "fx1", "fx2", "fx3", "fx4" },
                        Tag = Tags.fx,
                        ShowVolume = Visibility.Collapsed
                    }
                },
                LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" }
            };

            DataContext = viewModel;
        }
    }
}