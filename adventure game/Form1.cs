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
        Random randGen = new Random();
        SoundPlayer dance = new SoundPlayer(Properties.Resources.danceDefault);
        int scene = 0;
        public Form1()
        {  InitializeComponent();
            titleLabel.Text = "Press M or B to Ready Up";
            topButtonLabel.Text = "";
            bottomButtonLabel.Text = "";
            mainPictureBox.BackgroundImage = Properties.Resources.mainLobby;
            mainPictureBox2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int chanceAmount = randGen.Next(1, 11);
            if (e.KeyCode == Keys.M)       //red button press
            {
               
               
                if (scene == 0) { scene = 1; }
                
                else if (scene == 1) { scene = 5; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { scene = 10; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 8) { scene = 12; }
                else if (scene == 9) { scene = 13; }
                else if (scene == 10) { scene = 4; }
                else if (scene == 11) { scene = 4; }
                else if (scene == 12) { scene = 4; }
                else if (scene == 13) { scene = 19; }
                else if (scene == 14) { scene = 4; }
                else if (scene == 15) { scene = 16; }
                else if (scene == 16) { scene = 4; }
                else if (scene == 17) { scene = 18; }
                else if (scene == 18)
                {
                    if (chanceAmount <= 3) { scene = 19; }
                    else
                    {
                        scene = 4;
                    }
                }
                else if (scene == 19) { scene = 0; }
                else if (scene == 20)
                {
                    if (chanceAmount <= 6) { scene = 19; }
                    else
                    {
                        scene = 21;
                    }
                }
                else if (scene == 21) { scene = 0; }

            }
            else
            {

            }


            if (e.KeyCode == Keys.B)  //blue button press
            {

                if (scene == 0) { scene = 1; }

                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { scene = 4; }
                else if (scene == 11) { scene = 4; }
                else if (scene == 12) { scene = 4; }
                else if (scene == 13) { scene = 19; }
                else if (scene == 14) { scene = 4; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 16) { scene = 4; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18)
                {
                    if (chanceAmount <= 3) { scene = 19; }
                    else
                    {
                        scene = 4;
                    }
                }
                else if (scene == 19) { scene = 0; }
                else if (scene == 20)
                {
                    if (chanceAmount <= 6) { scene = 19; }
                    else
                    {
                        scene = 21;
                    }
                }
                else if (scene == 21) { scene = 0; }
            }

            switch (scene)
            {
              
                case 0:  //start scene  
                    imageBox.BackgroundImage = Properties.Resources.greenButton;
                    titleLabel.Text = "Press M or B to Ready Up";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    mainPictureBox.BackgroundImage = Properties.Resources.mainLobby;
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    imageBox.Visible = false;
                    imageBox1.Visible = false;
                    break;
               
                case 1:
                    BackgroundImage = Properties.Resources.defaultImage;
                    imageBox.BackgroundImage = Properties.Resources.greenButton;
                    imageBox1.BackgroundImage = Properties.Resources.redButton;
                    mainPictureBox2.BackgroundImage = Properties.Resources.seasonFiveMap;
                    mainPictureBox.Visible = false;
                    mainPictureBox2.Visible = true;
                    topButtonLabel.Text = "Salty Towers";
                    bottomButtonLabel.Text = "Retail Row";
                    titleLabel.Text = "You are in the bus. Where are you dropping?";
                    imageBox.Visible = true;
                    imageBox1.Visible = true;
                    break;              
                case 2:
                    mainPictureBox.BackgroundImage = Properties.Resources.saltyTowers;
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You land Salty Towers but there are too many people. What do you do?";
                    topButtonLabel.Text = "Land at a house far away";
                    bottomButtonLabel.Text = "Rush in";
                    break;              
                case 3:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "Turns out someone else landed their first and ends up killing you.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 4:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    mainPictureBox.BackgroundImage = Properties.Resources.fortniteDeathImage;
                    titleLabel.Text = "You've died but Great Try!\nPress M or B To Go Back To the Menu";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 5:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    mainPictureBox.BackgroundImage = Properties.Resources.retailRow;
                    titleLabel.Text = "You've decided to land at Retail Row. What house do you land at?";
                    topButtonLabel.Text = "Lebron's house";
                    bottomButtonLabel.Text = "Broken house";
                    break;
                case 6:
                    mainPictureBox.BackgroundImage = Properties.Resources.dogHouse;
                    titleLabel.Text = "You land at lebron's house and find a silenced smg, a tac shotgun, and 3 mini shields. Do you go fight the other player you seen land there or go get materials?";
                    topButtonLabel.Text = "Fight";
                    bottomButtonLabel.Text = "Get materials";
                    break;
                case 7:
                    mainPictureBox.BackgroundImage = Properties.Resources.brokenHouse;
                    titleLabel.Text = "You land at the broken house and find a purple scar, green pump, and bandages. Do you go fight the other player you seen land there or go get materials?";
                    topButtonLabel.Text = "Fight";
                    bottomButtonLabel.Text = "Get materials";
                    break;
                case 8:
                   
                    titleLabel.Text = "You find the guy at close range, you manage to get him low with the tac shotgun and finish him off with the smg.";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    titleLabel.Text = "You end up with a blue AR, tac shot gun, silenced smg, a med kit, and 3 mini shields.\nDo you go and hunt for other people or loot some more?";
                    topButtonLabel.Text = "Go hunt for people";
                    bottomButtonLabel.Text = "Loot some more";
                    break;
                case 9:
                    titleLabel.Text = "You look around the entire map for people but don't run into anyone until late game where there are 3 people left.\nDo you rush in the fight or let them fight it out?";
                    topButtonLabel.Text = "Rush in";
                    bottomButtonLabel.Text = "Let them fight";

                    break;
                case 10:
                    titleLabel.Text = "Someone else finds you getting materials and guns you down with an AR.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 11:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You manage to kill one of them but had no time to heal up after the fight\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 12:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You go looting at colossal coliseum but run into two people there that pinch you from both sides.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 13:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You find yourself in a good position, the one enemy is dead and the other is weak. You build up to get a better view and gun him dead.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 14:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You find him at close range and you end up getting killed because you couldn't follow up your pump shot with the scar.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 15:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You find someone else getting materials and you gun him down quickly with the scar.";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    titleLabel.Text = "Your end up with your scar, pump shotgun, smg, bandages and 2 big pot shields.\nDo you drive around looking for people or get materials?";
                    topButtonLabel.Text = "Drive around";
                    bottomButtonLabel.Text = "Get materials ";
                    break;
                case 16:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "you get caught getting materials and get gunned down before you can fight back.\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 17:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "you find yourself a couple people, and manage to make it to late game with one person left\nDo you look around for him or build a base for high ground";
                    topButtonLabel.Text = "Look around";
                    bottomButtonLabel.Text = "Build a Base";
                    break;
                case 18:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "He finds you while you are building your base, he builds up and shoots you but you manage to protect yourself. Will you win this fight?\nPress M or B to find out";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 19:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    mainPictureBox.BackgroundImage = Properties.Resources.defaultImage;
                    titleLabel.Text = "CONGRATULATIONS you got the VICTORY ROYALE and default dance to show your power over the competition.\nPress M or B to go to the home screen";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    dance.Play();
                    break;
                case 20:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "You manage to find him and sneak up behind him without him knowing and kill him\nPress M or B to continue";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;
                case 21:
                    mainPictureBox.Visible = true;
                    mainPictureBox2.Visible = false;
                    titleLabel.Text = "CONGRATULATIONS you got the VICTORY ROYALE\nPress M or B to go to the home screen";
                    topButtonLabel.Text = "";
                    bottomButtonLabel.Text = "";
                    break;

                default:
                    break;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
