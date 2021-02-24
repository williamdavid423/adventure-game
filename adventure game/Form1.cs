using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace adventure_game
{
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {  InitializeComponent();
            imageBox.BackgroundImage = Properties.Resources.greenButton;
            topButtonLabel.Text = "Press M or B Button To Ready Up";
            mainPictureBox.BackgroundImage = Properties.Resources.mainLobby;
            mainPictureBox2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 5; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) {  }
                else if (scene == 6) {  }
                else if (scene == 7) { }
                else if (scene == 8) {  }
                else if (scene == 9) { }
                else if (scene == 10) {  }
                else if (scene == 11) {  }
                else if (scene == 12) {  }
                else if (scene == 13) {  }
                else if (scene == 14) {  }
                else if (scene == 15) {  }
                else if (scene == 16) {  }
                else if (scene == 17) {  }
                else if (scene == 18) {  }
                else if (scene == 19) {  }
                else if (scene == 20) { }
                else if (scene == 21) {  }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 1; }
            }
            else if (scene == 1) { scene = 2; }
            else if (scene == 2) { scene = 3; }
            else if (scene == 3) { scene = 4; }
            else if (scene == 4) { scene = 0; }
            else if (scene == 5) {  }
            else if (scene == 6) {  }
            else if (scene == 7) {  }
            else if (scene == 8) {  }
            else if (scene == 9) {  }
            else if (scene == 10) {  }
            else if (scene == 11) {  }
            else if (scene == 12) { }
            else if (scene == 13) {  }
            else if (scene == 14) { }
            else if (scene == 15) {  }
            else if (scene == 16) {  }
            else if (scene == 17) {  }
            else if (scene == 18) {  }
            else if (scene == 19) { }
            else if (scene == 20) {  }
            else if (scene == 21) { }

            switch (scene)
            {
                case 0:  //start scene  
                    titleLabel.Text = "noob";
                    break;
                case 1:
                    imageBox.BackgroundImage = Properties.Resources.greenButton;
                    imageBox1.BackgroundImage = Properties.Resources.redButton;
                    mainPictureBox2.BackgroundImage = Properties.Resources.seasonFiveMap;
                    mainPictureBox.Visible = false;
                    mainPictureBox2.Visible = true;
                    topButtonLabel.Text = "Salty Towers";
                    bottomButtonLabel.Text = "Retail Row";
                    titleLabel.Text = "You are in the bus. Where are you dropping?";
                    break;
                case 2:
                    imageBox.BackgroundImage = Properties.Resources.greenButton;
                    imageBox1.BackgroundImage = Properties.Resources.redButton;
                    mainPictureBox2.BackgroundImage = Properties.Resources.seasonFiveMap;
                    mainPictureBox.Visible = false;
                    mainPictureBox2.Visible = true;
                    titleLabel.Text = "You decided to Drop Salty Towers where a lot of other people have landed at. What do you do?";
                    topButtonLabel.Text = "Land at house far away";
                    bottomButtonLabel.Text = "Rush in";
                    break;
                case 3:
                    titleLabel.Text = "Turns out someone else landed their first and ends up killing you";
                    break;
                case 4:
                    titleLabel.Text = "You've died but Great Try!\nPress M or B To Go Back To the Menu";
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                case 99:

                    Refresh();

                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
