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

namespace SoundsTest
{
    public class SamplesModel : INotifyPropertyChanged
    {
        private int volume;
        private double rate;
        private Visibility showVolume;

        public string[] SampleNames { get; set; }
        public string[] Tags { get; set; }
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