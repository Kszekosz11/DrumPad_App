using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoundsTest
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        public SamplesModel DrumsSamples { get; set; }
        public SamplesModel GuitarSamples { get; set; }
        public SamplesModel FlutesSamples { get; set; }
        public SamplesModel PianoSamples { get; set; }
        public SamplesModel VoxSamples { get; set; }
        public SamplesModel FXSamples { get; set; }
        private string[] labelNames;
        public string[] LabelNames
        {
            get
            {
                return labelNames;
            }
            set
            {
                if (labelNames == value)
                {
                    return;
                }
                labelNames = value;
                OnPropertyChanged(nameof(LabelNames));
            }
        }
        public string[] MusicStyles { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}