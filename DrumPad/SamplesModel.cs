using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DrumPad
{
    public class SamplesModel : INotifyPropertyChanged
    {
        private string[] sampleNames;
        public string[] SampleNames
        {
            get
            {
                return sampleNames;
            }
            set
            {
                if (sampleNames == value)
                {
                    return;
                }
                sampleNames = value;
                OnPropertyChanged(nameof(SampleNames));
            }
        }

        private string[] tags;
        public string[] Tags
        {
            get
            {
                return tags;
            }
            set
            {
                if (tags == value)
                {
                    return;
                }
                tags = value;
                OnPropertyChanged(nameof(Tags));
            }
        }
        
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (volume == value)
                {
                    return;
                }
                volume = value;
                OnPropertyChanged(nameof(Volume));
            }
        }
        
        private double rate;
        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (rate == value)
                {
                    return;
                }
                rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }
        
        private Visibility showVolume;
        public Visibility ShowVolume
        {
            get
            {
                return showVolume;
            }
            set
            {
                if (showVolume == value)
                {
                    return;
                }
                showVolume = value;
                OnPropertyChanged(nameof(ShowVolume));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}