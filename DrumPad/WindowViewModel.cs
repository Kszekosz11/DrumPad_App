using System.ComponentModel;

namespace DrumPad
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        public SamplesModel FirstSamples { get; set; }
        public SamplesModel SecondSamples { get; set; }
        public SamplesModel ThirdSamples { get; set; }
        public SamplesModel FourSamples { get; set; }
        public SamplesModel FiveSamples { get; set; }
        public SamplesModel SixSamples { get; set; }
        public string[] MusicStyles { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}