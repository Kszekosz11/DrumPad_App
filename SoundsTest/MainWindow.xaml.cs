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
        public WindowViewModel viewModel = new WindowViewModel();
        SetTags setTags;
        SetSampleNames setSampleNames;
        private Analyzer analyzer;

        public MainWindow()
        {
            InitializeComponent();

            pathFiles = new PathFiles();
            setTags = new SetTags();
            setSampleNames = new SetSampleNames();
            analyzer = new Analyzer(PbL, PbR, Spectrum, ComboBoxChooseDevice);

            viewModel = new WindowViewModel
            {
                FirstSamples = new SamplesModel
                {
                    Tags = Tags.hipHopDrum,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                SecondSamples = new SamplesModel
                {
                    Tags = Tags.hipHopBass,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                ThirdSamples = new SamplesModel
                {                 
                    Tags = Tags.hipHopSynth,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                FourSamples = new SamplesModel
                {                 
                    Tags = Tags.hipHopPiano,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                FiveSamples = new SamplesModel
                {                 
                    Tags = Tags.hipHopVox,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
                SixSamples = new SamplesModel
                {                 
                    Tags = Tags.hipHopFx,
                    Volume = DefaultValues.volume,
                    Rate = DefaultValues.rate
                },
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
                    setTags.SetHipHopTags(this);
                    setSampleNames.SetHipHopSamplesName(this);
                    viewModel.LabelNames = WindowControlsContent.labelHipHopNames;
                    break;
                case 1:
                    setTags.SetReggaeTags(this);
                    setSampleNames.SetReggaeSamplesName(this);
                    viewModel.LabelNames = WindowControlsContent.labelReggaeNames;
                    break;
                case 2:
                    setTags.SetHouseTags(this);
                    setSampleNames.SetHouseSamplesName(this);
                    viewModel.LabelNames = WindowControlsContent.labelHouseNames;
                    break;
                default:
                    break;
            }
        }
    }
}