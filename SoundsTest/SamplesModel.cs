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
    public class SamplesModel
    {
        public string Header { get; set; }
        public string[] SampleName { get; set; }
        public string[] Tag { get; set; }
        public bool ProgressRing { get; set; }
        public Visibility ShowVolume { get; set; }
    }
}