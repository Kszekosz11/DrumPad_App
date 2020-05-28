using System.Collections.Generic;
using System.Linq;

namespace SoundsTest
{
    public class PathFiles
    {
        public string[] hipHopDrums = new string[4];
        public string[] hipHopBasses = new string[4];
        public string[] hipHopSynths = new string[4];
        public string[] hiphopPianos = new string[4];
        public string[] hiphopVoxes = new string[4];
        public string[] hiphopFXs = new string[4];

        public string[] reggaeDrums = new string[4];
        public string[] reggaeBasses = new string[4];
        public string[] reggaeSynths = new string[4];
        public string[] reggaePianos = new string[4];
        public string[] reggaePercussions = new string[4];
        public string[] reggaeGuitars = new string[4];

        public string[] houseDrums = new string[4];
        public string[] houseBasses = new string[4];
        public string[] houseSynths = new string[4];
        public string[] houseBrasses = new string[4];
        public string[] houseGuitars = new string[4];
        public string[] houseFXs = new string[4];

        public string[] allEffects = new string[72];        

        public PathFiles()
        {
            SetPathEffects();
            ConcatEffects();
        }

        private void SetPathEffects()
        {
            for (int i = 0; i < 4; i++)
            {
                hipHopDrums[i] = "Effects/HipHop/Drum/Drum (" + (i + 1).ToString() + ").wav";
                hipHopBasses[i] = "Effects/HipHop/Bass/Bass (" + (i + 1).ToString() + ").wav";
                hipHopSynths[i] = "Effects/HipHop/Synth/Synth (" + (i + 1).ToString() + ").wav";
                hiphopPianos[i] = "Effects/HipHop/Piano/Piano (" + (i + 1).ToString() + ").wav";
                hiphopVoxes[i] = "Effects/HipHop/Vox/Vox (" + (i + 1).ToString() + ").wav";
                hiphopFXs[i] = "Effects/HipHop/FX/FX (" + (i + 1).ToString() + ").wav";

                reggaeDrums[i] = "Effects/Reggae/Drum/Drum (" + (i + 1).ToString() + ").wav";
                reggaeBasses[i] = "Effects/Reggae/Bass/Bass (" + (i + 1).ToString() + ").wav";
                reggaeSynths[i] = "Effects/Reggae/Synth/Synth (" + (i + 1).ToString() + ").wav";
                reggaePianos[i] = "Effects/Reggae/Piano/Piano (" + (i + 1).ToString() + ").wav";
                reggaePercussions[i] = "Effects/Reggae/Percussion/Percussion (" + (i + 1).ToString() + ").wav";
                reggaeGuitars[i] = "Effects/Reggae/Guitar/Guitar (" + (i + 1).ToString() + ").wav";

                houseDrums[i] = "Effects/House/Drums/Drums (" + (i + 1).ToString() + ").wav";
                houseBasses[i] = "Effects/House/Bass/Bass (" + (i + 1).ToString() + ").wav";
                houseSynths[i] = "Effects/House/Synth/Synth (" + (i + 1).ToString() + ").wav";
                houseBrasses[i] = "Effects/House/Brass/Brass (" + (i + 1).ToString() + ").wav";
                houseGuitars[i] = "Effects/House/Guitar/Guitar (" + (i + 1).ToString() + ").wav";
                houseFXs[i] = "Effects/House/FX/FX (" + (i + 1).ToString() + ").wav";
            }
        }

        private void ConcatEffects()
        {
            allEffects = new List<string>()
                .Concat(hipHopDrums)
                .Concat(hipHopBasses)
                .Concat(hipHopSynths)
                .Concat(hiphopPianos)
                .Concat(hiphopVoxes)
                .Concat(hiphopFXs)
                .Concat(reggaeDrums)
                .Concat(reggaeBasses)
                .Concat(reggaeSynths)
                .Concat(reggaePianos)
                .Concat(reggaePercussions)
                .Concat(reggaeGuitars)
                .Concat(houseDrums)
                .Concat(houseBasses)
                .Concat(houseSynths)
                .Concat(houseBrasses)
                .Concat(houseGuitars)
                .Concat(houseFXs)
                .ToArray();
        }
    }
}