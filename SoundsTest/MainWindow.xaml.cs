using NAudio.CoreAudioApi;
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
using System.Windows.Threading;
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

        private MMDevice device;
        MMDeviceEnumerator enumerator;

        WindowViewModel viewModel = new WindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            pathFiles = new PathFiles();            

            viewModel = new WindowViewModel
            {
                DrumsSamples = new SamplesModel
                {
                    SampleNames = pathFiles.drumsSamplesNames,
                    Tags = Tags.drums,
                    ShowVolume = Visibility.Collapsed
                }
                ,
                GuitarSamples = new SamplesModel
                {                    
                        SampleNames = pathFiles.guitarSamplesNames,
                        Tags = Tags.guitar,
                        ShowVolume = Visibility.Collapsed                    
                },
                FlutesSamples = new SamplesModel
                {
                        SampleNames = new string[] { "fl1", "fl2", "fl3", "fl4" },
                        Tags = Tags.flutes,
                        ShowVolume = Visibility.Collapsed
                 
                },
                PianoSamples = new SamplesModel
                {                    
                        SampleNames = new string[] { "pn1", "pn2", "pn3", "pn4" },
                        Tags = Tags.piano,
                        ShowVolume = Visibility.Collapsed
                },
                VoxSamples = new SamplesModel
                {
                        SampleNames = new string[] { "vx1", "vx2", "vx3", "vx4" },
                        Tags = Tags.vox,
                        ShowVolume = Visibility.Collapsed
                },
                FXSamples = new SamplesModel
                {                    
                        SampleNames = new string[] { "fx1", "fx2", "fx3", "fx4" },
                        Tags = Tags.fx,
                        ShowVolume = Visibility.Collapsed
                },
                LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" },
                MusicStyles = new string[] {"Hip Hop", "Reggae", "Trap", "House", "Disco", "Rock"}
            };

            DataContext = viewModel;

            enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            ComboBoxChooseDevice.ItemsSource = devices.ToArray();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (ComboBoxChooseDevice.SelectedItem != null)
            {
                device = (MMDevice)ComboBoxChooseDevice.SelectedItem;
                ProgressBarVolume0.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume2.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume3.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume4.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume5.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume6.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume7.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                ProgressBarVolume8.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
            }            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {            
            //viewModel = new WindowViewModel
            //{
            //    DrumsSamples = new SamplesModel
            //    {
            //        SampleName = pathFiles.drumsSamplesNames,
            //        Tag = Tags.drums,
            //        ShowVolume = Visibility.Visible
            //    }
            //    ,
            //    GuitarSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = pathFiles.guitarSamplesNames,
            //            Tag = Tags.guitar,
            //            ShowVolume = Visibility.Visible
            //        }
            //    },
            //    FlutesSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "fl1", "fl2", "fl3", "fl4" },
            //            Tag = Tags.flutes,
            //            ShowVolume = Visibility.Visible
            //        }
            //    },
            //    PianoSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "pn1", "pn2", "pn3", "pn4" },
            //            Tag = Tags.piano,
            //            ShowVolume = Visibility.Visible
            //        }
            //    },
            //    VoxSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "vx1", "vx2", "vx3", "vx4" },
            //            Tag = Tags.vox,
            //            ShowVolume = Visibility.Visible
            //        }
            //    },
            //    FXSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "fx1", "fx2", "fx3", "fx4" },
            //            Tag = Tags.fx,
            //            ShowVolume = Visibility.Visible
            //        }
            //    },
            //    LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" }                
            //};

            //DataContext = viewModel;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //viewModel = new WindowViewModel
            //{
            //    DrumsSamples = new SamplesModel
            //    {
            //        SampleName = pathFiles.drumsSamplesNames,
            //        Tag = Tags.drums,
            //        ShowVolume = Visibility.Collapsed
            //    }
            //    ,
            //    GuitarSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = pathFiles.guitarSamplesNames,
            //            Tag = Tags.guitar,
            //            ShowVolume = Visibility.Collapsed
            //        }
            //    },
            //    FlutesSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "fl1", "fl2", "fl3", "fl4" },
            //            Tag = Tags.flutes,
            //            ShowVolume = Visibility.Collapsed
            //        }
            //    },
            //    PianoSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "pn1", "pn2", "pn3", "pn4" },
            //            Tag = Tags.piano,
            //            ShowVolume = Visibility.Collapsed
            //        }
            //    },
            //    VoxSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "vx1", "vx2", "vx3", "vx4" },
            //            Tag = Tags.vox,
            //            ShowVolume = Visibility.Collapsed
            //        }
            //    },
            //    FXSamples = new SamplesModel[]
            //    {
            //        new SamplesModel
            //        {
            //            SampleName = new string[] { "fx1", "fx2", "fx3", "fx4" },
            //            Tag = Tags.fx,
            //            ShowVolume = Visibility.Collapsed
            //        }
            //    },
            //    LabelNames = new string[] { "Drums", "Guitar", "Flutes", "Piano", "Vox", "FX" }
            //};

            //DataContext = viewModel;
        }
    }
}