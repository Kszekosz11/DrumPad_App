using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundsTest
{
    public class WindowViewModel
    {
        public ICollection<SamplesModel> DrumsSamples { get; set; }
        public ICollection<SamplesModel> GuitarSamples { get; set; }
        public ICollection<SamplesModel> FlutesSamples { get; set; }
        public ICollection<SamplesModel> PianoSamples { get; set; }
        public ICollection<SamplesModel> VoxSamples { get; set; }
        public ICollection<SamplesModel> FXSamples { get; set; }
    }
}