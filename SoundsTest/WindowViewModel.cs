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
        public ICollection<SamplesModel> GuitarSamples { get; set; }
        public ICollection<SamplesModel> FlutesSamples { get; set; }
        public ICollection<SamplesModel> PianoSamples { get; set; }
        public ICollection<SamplesModel> VoxSamples { get; set; }
        public ICollection<SamplesModel> FXSamples { get; set; }
        public string[] LabelNames { get; set; }        
    }
}