using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumPad
{
    public class SetSampleNames
    {
        public void SetHipHopSamplesName(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.SampleNames = Names.hpFirst;
            mainWindow.viewModel.SecondSamples.SampleNames = Names.hpSecond;
            mainWindow.viewModel.ThirdSamples.SampleNames = Names.hpThird;
            mainWindow.viewModel.FourSamples.SampleNames = Names.hpFour;
            mainWindow.viewModel.FiveSamples.SampleNames = Names.hpFive;
            mainWindow.viewModel.SixSamples.SampleNames = Names.hpSix;
        }

        public void SetReggaeSamplesName(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.SampleNames = Names.rgFirst;
            mainWindow.viewModel.SecondSamples.SampleNames = Names.rgSecond;
            mainWindow.viewModel.ThirdSamples.SampleNames = Names.rgThird;
            mainWindow.viewModel.FourSamples.SampleNames = Names.rgFour;
            mainWindow.viewModel.FiveSamples.SampleNames = Names.rgFive;
            mainWindow.viewModel.SixSamples.SampleNames = Names.rgSix;
        }

        public void SetHouseSamplesName(MainWindow mainWindow)
        {
            mainWindow.viewModel.FirstSamples.SampleNames = Names.hoFirst;
            mainWindow.viewModel.SecondSamples.SampleNames = Names.hoSecond;
            mainWindow.viewModel.ThirdSamples.SampleNames = Names.hoThird;
            mainWindow.viewModel.FourSamples.SampleNames = Names.hoFour;
            mainWindow.viewModel.FiveSamples.SampleNames = Names.hoFive;
            mainWindow.viewModel.SixSamples.SampleNames = Names.hoSix;
        }
    }
}
