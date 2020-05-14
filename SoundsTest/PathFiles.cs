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
        public string[] hipHopBaseLocation = new string[(int)EffectsQuantity.hipHopBeats];
        public string[] drumsLocation = new string[(int)EffectsQuantity.drums];
        public string[] guitarLocation = new string[(int)EffectsQuantity.guitar];
        public string[] hiphopLocation = new string[(int)EffectsQuantity.hipHop];

        public string[] hipHopBaseSamplesNames = new string[(int)EffectsQuantity.hipHopBeats];
        public string[] drumsSamplesNames = new string[(int)EffectsQuantity.drums];
        public string[] guitarSamplesNames = new string[(int)EffectsQuantity.guitar];
        public string[] hiphopSamplesNames = new string[(int)EffectsQuantity.hipHop];

        public string[] allEffects = new string[40];

        public PathFiles()
        {            
            SetPathEffects();
            ConcatEffects();
            GetNames();
        }

        private void SetPathEffects()
        {
            for (int i = 0; i < (int)EffectsQuantity.drums; i++)
            {
                hipHopBaseLocation[i] = "Effects/BaseHipHop/hipHop (" + i.ToString() + ").wav";
                drumsLocation[i] = "Effects/Drums/drums (" + i.ToString() + ").wav";
                guitarLocation[i] = "Effects/Guitar/guitar (" + i.ToString() + ").wav";
                hiphopLocation[i] = "Effects/HipHop/hipHop (" + i.ToString() + ").wav";
            }
        }

        private void ConcatEffects()
        {
            allEffects = new List<string>()
                .Concat(hipHopBaseLocation)
                .Concat(drumsLocation)
                .Concat(guitarLocation)
                .Concat(hiphopLocation)
                .ToArray();
        }

        private void GetNames()
        {
            for (int i = 0; i < (int)EffectsQuantity.hipHopBeats; i++)
            {
                hipHopBaseSamplesNames[i] = (Path.GetFileName("Effects/BaseHipHop/hipHop (" + i.ToString() + ").wav")).Substring(0, 2) + i.ToString();
                drumsSamplesNames[i] = (Path.GetFileName("Effects/Drums/drums (" + i.ToString() + ").wav")).Substring(0, 2) + i.ToString();
                guitarSamplesNames[i] = (Path.GetFileName("Effects/Guitar/guitar (" + i.ToString() + ").wav")).Substring(0, 2) + i.ToString();
                hiphopSamplesNames[i] = (Path.GetFileName("Effects/HipHop/hipHop (" + i.ToString() + ").wav")).Substring(0, 2) + i.ToString();
            }
        }
    }
}