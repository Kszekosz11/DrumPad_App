using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundsTest
{
    public class SetTags
    {
        public void SetHipHopTags(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.Tags = Tags.hipHopDrum;
            mainWindow.viewModel.SecondSamples.Tags = Tags.hipHopBass;
            mainWindow.viewModel.ThirdSamples.Tags = Tags.hipHopSynth;
            mainWindow.viewModel.FourSamples.Tags = Tags.hipHopPiano;
            mainWindow.viewModel.FiveSamples.Tags = Tags.hipHopVox;
            mainWindow.viewModel.SixSamples.Tags = Tags.hipHopFx;
        }

        public void SetReggaeTags(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.Tags = Tags.reggaeDrums;
            mainWindow.viewModel.SecondSamples.Tags = Tags.reggaeGuitar;
            mainWindow.viewModel.ThirdSamples.Tags = Tags.reggaeFlutes;
            mainWindow.viewModel.FourSamples.Tags = Tags.reggaePiano;
            mainWindow.viewModel.FiveSamples.Tags = Tags.reggaeVox;
            mainWindow.viewModel.SixSamples.Tags = Tags.reggaeFx;
        }

        public void SetHouseTags(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.Tags = Tags.houseDrum;
            mainWindow.viewModel.SecondSamples.Tags = Tags.houseBass;
            mainWindow.viewModel.ThirdSamples.Tags = Tags.houseSynth;
            mainWindow.viewModel.FourSamples.Tags = Tags.houseBrass;
            mainWindow.viewModel.FiveSamples.Tags = Tags.houseGuitar;
            mainWindow.viewModel.SixSamples.Tags = Tags.houseFx;
        }
    }
}
