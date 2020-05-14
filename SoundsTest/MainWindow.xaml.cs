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
        PathFiles pathFiles;
        Tags tags;

        public int index;

        public MainWindow()
        {
            InitializeComponent();
            pathFiles = new PathFiles();
            tags = new Tags();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = TabControlSamples.SelectedIndex;

            switch (index)
            {
                case 0:
                    this.DataContext = new WindowViewModel
                    {
                        Samples = new SamplesModel[]
                        {
                            new SamplesModel
                            {
                                SampleName = pathFiles.hipHopBaseSamplesNames,
                                Tags = tags.hipHopBaseTags
                            }
                        }
                    };
                    break;
                case 1:
                    this.DataContext = new WindowViewModel
                    {
                        Samples = new SamplesModel[]
                        {
                            new SamplesModel
                            {
                                SampleName = pathFiles.drumsSamplesNames,
                                Tags = tags.drumsTags
                            }
                        }
                    };
                    break;
                case 2:
                    this.DataContext = new WindowViewModel
                    {
                        Samples = new SamplesModel[]
                    {
                            new SamplesModel
                            {
                                SampleName = pathFiles.guitarSamplesNames,
                                Tags = tags.guitarTags
                            }
                    }
                    };
                    break;
                case 3:
                    this.DataContext = new WindowViewModel
                    {
                        Samples = new SamplesModel[]
                        {
                            new SamplesModel
                            {
                                SampleName = pathFiles.hiphopSamplesNames,
                                Tags = tags.hipHopTags
                            }
                        }
                    };
                    break;
                case 4:
                    this.DataContext = new WindowViewModel
                    {
                        Samples = new SamplesModel[]
                            {
                            new SamplesModel
                            {
                                SampleName = pathFiles.hiphopSamplesNames,
                                Tags = tags.hipHopTags
                            }
                            }
                    };
                    break;
                default:
                    break;
            }
        }
    }
}