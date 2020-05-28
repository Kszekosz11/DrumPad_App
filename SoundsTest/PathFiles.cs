using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoundsTest
{
    public class PathFiles
    {
        public string[] hipHopDrums = new string[4];
        public string[] hipHopGuitar = new string[4];
        public string[] hipHopFlutes = new string[4];
        public string[] hiphopPiano = new string[4];
        public string[] hiphopVox = new string[4];
        public string[] hiphopFX = new string[4];

        public string[] reggaeDrums = new string[4];
        public string[] reggaeGuitar = new string[4];
        public string[] reggaeFlutes = new string[4];
        public string[] reggaePiano = new string[4];
        public string[] reggaeVox = new string[4];
        public string[] reggaeFX = new string[4];

        public string[] drumsSamplesNames = new string[4];
        public string[] guitarSamplesNames = new string[4];
        public string[] flutesSamplesNames = new string[4];
        public string[] pianoSamplesNames = new string[4];
        public string[] voxSamplesNames = new string[4];
        public string[] fxSamplesNames = new string[4];

        public string[] allHipHopEffects = new string[48];
        //public string[] allReggaeEffects = new string[24];

        public PathFiles()
        {
            SetPathEffects();
            ConcatEffects();
            GetNames();
        }

        private void SetPathEffects()
        {
            for (int i = 0; i < 4; i++)
            {
                hipHopDrums[i] =  "Effects/HipHop/Drums/Drums (" + i.ToString() + ").wav";
                hipHopGuitar[i] = "Effects/HipHop/Guitar/Guitar (" + i.ToString() + ").wav";
                hipHopFlutes[i] = "Effects/HipHop/Flutes/Flutes (" + i.ToString() + ").wav";
                hiphopPiano[i] =  "Effects/HipHop/Piano/Piano (" + i.ToString() + ").wav";
                hiphopVox[i] =  "Effects/HipHop/Vox/Vox (" + i.ToString() + ").wav";
                hiphopFX[i] =  "Effects/HipHop/FX/FX (" + i.ToString() + ").wav";

                reggaeDrums[i] = "Effects/Reggae/Drums/Drums (" + i.ToString() + ").wav";
                reggaeGuitar[i] = "Effects/Reggae/Guitar/Guitar (" + i.ToString() + ").wav";
                reggaeFlutes[i] = "Effects/Reggae/Flutes/Flutes (" + i.ToString() + ").wav";
                reggaePiano[i] = "Effects/Reggae/Piano/Piano (" + i.ToString() + ").wav";
                reggaeVox[i] = "Effects/Reggae/Vox/Vox (" + i.ToString() + ").wav";
                reggaeFX[i] = "Effects/Reggae/FX/FX (" + i.ToString() + ").wav";
            }
        }

        private void ConcatEffects()
        {
            allHipHopEffects = new List<string>()
                .Concat(hipHopDrums)
                .Concat(hipHopGuitar)
                .Concat(hipHopFlutes)
                .Concat(hiphopPiano)
                .Concat(hiphopVox)
                .Concat(hiphopFX)
                .Concat(reggaeDrums)
                .Concat(reggaeGuitar)
                .Concat(reggaeFlutes)
                .Concat(reggaePiano)
                .Concat(reggaeVox)
                .Concat(reggaeFX)
                .ToArray();            
        }

        private void GetNames()
        {
            for (int i = 0; i < 4; i++)
            {
                drumsSamplesNames[i] = Path.GetFileName("Effects/HipHop/Drums (" + i.ToString() + ").wav").Substring(0, 2) + i.ToString();
                guitarSamplesNames[i] = Path.GetFileName("Effects/HipHop/Guitar (" + i.ToString() + ").wav").Substring(0, 2) + i.ToString();
                flutesSamplesNames[i] = Path.GetFileName("Effects/HipHop/Flutes (" + i.ToString() + ").wav").Substring(0, 2) + i.ToString();
                pianoSamplesNames[i] = Path.GetFileName("Effects/HipHop/Piano (" + i.ToString() + ").wav").Substring(0, 2) + i.ToString();
            }
        }
    }
}