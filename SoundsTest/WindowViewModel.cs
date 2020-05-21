using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoundsTest
{
    public class WindowViewModel
    {
        public SamplesModel DrumsSamples { get; set; }
        public SamplesModel GuitarSamples { get; set; }
        public SamplesModel FlutesSamples { get; set; }
        public SamplesModel PianoSamples { get; set; }
        public SamplesModel VoxSamples { get; set; }
        public SamplesModel FXSamples { get; set; }
        public string[] LabelNames { get; set; }
        public string[] MusicStyles { get; set; }        
    }
}