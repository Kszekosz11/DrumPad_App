using System;
using System.Collections.Generic;
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

        //public string[,] effects = new string[4,10];        

        public string[] allEffects = new string[40];

        public PathFiles()
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i == 0)
            //        {
            //            effects[i, j] = hipHopBaseLocation[j] = "Effects/BaseHipHop/hipHop (" + j.ToString() + ").wav";
            //        }
            //        else if (i == 1)
            //        {
            //            effects[i, j] = drumsLocation[j] = "Effects/BaseHipHop/hipHop (" + j.ToString() + ").wav";
            //        }
            //        else if (i == 2)
            //        {
            //            effects[i, j] = guitarLocation[j] = "Effects/BaseHipHop/hipHop (" + j.ToString() + ").wav";
            //        }
            //        else
            //        {
            //            effects[i, j] = hiphopLocation[j] = "Effects/BaseHipHop/hipHop (" + j.ToString() + ").wav";
            //        }
            //    }
                
            //}

            SetPathEffects();
            ConcatEffects();           
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
    }
}