using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoundsTest
{
    /// <summary>
    /// Logika interakcji dla klasy ButtonLayout.xaml
    /// </summary>
    public partial class ButtonLayout : UserControl
    {        
        SoundPlayer soundPlayer;
        PathFiles pathFiles;
        int tag;

        public ButtonLayout()
        {
            InitializeComponent();
            
            soundPlayer = new SoundPlayer();
            pathFiles = new PathFiles();
        }        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tag = int.Parse((sender as Control).Tag.ToString());                        
            soundPlayer.SoundLocation = pathFiles.allEffects[tag];
            soundPlayer.Play();
        }
    }    
}