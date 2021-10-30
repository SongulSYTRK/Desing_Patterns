using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Abstract;
using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2
{
    public partial class CorExample : Form
    {
        public CorExample()
        {
            InitializeComponent();
        }

        private void btnchoeseFile_Click(object sender, EventArgs e)
        {
            openfileplayer.Filter = ".mp3 |.mp4 |.avi";
            if (openfileplayer.ShowDialog() == DialogResult.OK)
                txtplayer.Text = openfileplayer.FileName;
        }

        private void BTNPLAY_Click(object sender, EventArgs e)
        {
            var mp3Player = MP3Player.GetMp3Player();
            var mp4Player = MP4Player.GetMp4Player();
            var aviPlayer = AviPlayer.GetAviPlayer();


            mp3Player.NextPlayer=mp4Player;
            mp4Player.NextPlayer=aviPlayer;



            mp3Player.Handler(txtplayer.Text);


        }
    }
}
