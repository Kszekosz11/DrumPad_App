using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO.Ports;
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
        WindowViewModel viewModel = new WindowViewModel();
        private Analyzer analyzer;

        public MainWindow()
        {
            InitializeComponent();

            pathFiles = new PathFiles();
            analyzer = new Analyzer(PbL, PbR, Spectrum, ComboBoxChooseDevice);
            viewModel = new WindowViewModel
            {
                DrumsSamples = new SamplesModel
                {
                    SampleNames = pathFiles.drumsSamplesNames,
                    Tags = Tags.drums,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                GuitarSamples = new SamplesModel
                {
                    SampleNames = pathFiles.guitarSamplesNames,
                    Tags = Tags.guitar,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                FlutesSamples = new SamplesModel
                {
                    SampleNames = new string[] { "fl1", "fl2", "fl3", "fl4" },
                    Tags = Tags.flutes,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                PianoSamples = new SamplesModel
                {
                    SampleNames = new string[] { "pn1", "pn2", "pn3", "pn4" },
                    Tags = Tags.piano,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                VoxSamples = new SamplesModel
                {
                    SampleNames = new string[] { "vx1", "vx2", "vx3", "vx4" },
                    Tags = Tags.vox,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                FXSamples = new SamplesModel
                {
                    SampleNames = new string[] { "fx1", "fx2", "fx3", "fx4" },
                    Tags = Tags.fx,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                LabelNames = WindowControlsContent.labelHipHopNames,
                MusicStyles = WindowControlsContent.musicStyles
            };

            DataContext = viewModel;
        }

        private void ToggleButtonShowVolume_Click(object sender, RoutedEventArgs e)
        {
            analyzer.Enable = true;
            analyzer.DisplayEnable = (bool)ToggleButtonShowVolume.IsChecked;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Control).Tag.ToString());

            switch (tag)
            {
                case 0:
                    viewModel.DrumsSamples.Tags = Tags.drums;
                    viewModel.GuitarSamples.Tags = Tags.guitar;
                    viewModel.FlutesSamples.Tags = Tags.flutes;
                    viewModel.PianoSamples.Tags = Tags.piano;
                    viewModel.VoxSamples.Tags = Tags.vox;
                    viewModel.FXSamples.Tags = Tags.fx;
                    viewModel.LabelNames = WindowControlsContent.labelHipHopNames;
                    break;
                case 1:
                    viewModel.DrumsSamples.Tags = Tags.drums2;
                    viewModel.GuitarSamples.Tags = Tags.guitar2;
                    viewModel.FlutesSamples.Tags = Tags.flutes2;
                    viewModel.PianoSamples.Tags = Tags.piano2;
                    viewModel.VoxSamples.Tags = Tags.vox2;
                    viewModel.FXSamples.Tags = Tags.fx2;
                    viewModel.LabelNames = WindowControlsContent.labelReggaeNames;
                    break;
                default:
                    break;
            }
        }
    }
}