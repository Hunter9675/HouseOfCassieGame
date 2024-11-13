using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace HouseOfCassieGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer sp = new SoundPlayer(Properties.Resources.gamelose);
        

        public Form1()
        {

            InitializeComponent();

            SoundPlayer sp = new SoundPlayer(Properties.Resources.funnywin);
            
            rightButton.Visible = false;

            pictureDisplay.Image = Properties.Resources.page1;

            leftButton.Text = "Continue?";

            storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            rightButton.Visible = true;

            if (page == 1)
            {
                storyLabel.Text = "Should Tyler go up the stairs of into the dark basement?";
                leftButton.Text = "He should go up the stairs.";
                rightButton.Text = "He should go into the dark basement.";
                pictureDisplay.Image = Properties.Resources.page2;
                page = 2;
                
            }
            else if (page == 2)
            {
                Random ranGen = new Random();
                int randomNumber;

                randomNumber = ranGen.Next(1, 101);

                if (randomNumber > 20)
                {
                    storyLabel.Text = "OH NO! Tyler accidentilly trips an axe trap and dies. Game over.";
                    leftButton.Text = "Try again.";
                    rightButton.Visible = false;
                    pictureDisplay.Image = Properties.Resources.page4and12;
                    page = 4;
                    sp = new SoundPlayer(Properties.Resources.gamelose);
                    sp.Play();
                }
                if (randomNumber < 20)
                {
                    storyLabel.Text = "Tyler makes it up the stairs and he meets Cassie. They talk and Cassie tells Tyler how she mysteriously dissapeared! The end.";
                    leftButton.Text = "Play again.";
                    rightButton.Visible = false;
                    pictureDisplay.Image = Properties.Resources.page5;
                    page = 5;
                    sp = new SoundPlayer(Properties.Resources.funnywin);
                    sp.Play();
                }
            }
            else if (page == 3)
            {
                storyLabel.Text = "OH NO! Tyler reads the diary and is killed by Cassie! Game over.";
                leftButton.Text = "Try again.";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page6and10;
                page = 6;
                sp = new SoundPlayer(Properties.Resources.gamelose);
                sp.Play();
            }
            else if (page == 4)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
            else if (page == 5)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
            else if (page == 6)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
            else if (page == 7)
            {
                storyLabel.Text = "OH NO! Tyler gets bit by a poisonous spider and dies! Game over.";
                leftButton.Text = "Try again.";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page8;
                page = 8;
                sp = new SoundPlayer(Properties.Resources.gamelose);
                sp.Play();
            }
            else if (page == 8)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
            else if (page == 9)
            {
                storyLabel.Text = "Uh oh! The front door is locked! Should Tyler look into the dark kitchen for a key or sould he look upstairs?";
                leftButton.Text = "He should look in the dark kitchen.";
                rightButton.Text = "He should look upstairs.";
                pictureDisplay.Image = Properties.Resources.page11;
                page = 11;
            }
            else if (page == 10)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;

            }
            else if (page == 13)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
            else if (page == 11)
            {
                storyLabel.Text = "Woohoo! Tyler found the key and escaped with his life and the answer to the mystery of Cassie! The end.";
                leftButton.Text = "Play again.";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page13;
                page = 13;
                sp = new SoundPlayer(Properties.Resources.gamewin);
                sp.Play();
            }
            else if (page == 12)
            {
                storyLabel.Text = "Tyler walks into a haunted house to find out the mystery of Cassie's disappearance in the 1920's";
                leftButton.Text = "Continue?";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page1;
                page = 1;
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                storyLabel.Text = "Uh oh! Tyler gets lost in the basement but he finds Cassie's diary! Should Tyler read it now or should he try to find a way out first?";
                leftButton.Text = "He should read the diary now.";
                rightButton.Text = "He should try to find a way out before reading the diary.";
                pictureDisplay.Image = Properties.Resources.page3;
                page = 3;
                sp = new SoundPlayer(Properties.Resources.diaryfound);
                sp.Play();
            }
            else if (page == 3)
            {
                storyLabel.Text = "Tyler starts walking and theres a fork in the road! Should Tyler go left of right?";
                leftButton.Text = "Left.";
                rightButton.Text = "Right.";
                pictureDisplay.Image = Properties.Resources.page7;
                page = 7;
            }
            else if (page == 7)
            {
                storyLabel.Text = "Tyler sees Cassie and she looks angry! Should Tyler try to make her feel better or should he keep hiding until she leaves?";
                leftButton.Text = "He should hide until she leaves.";
                rightButton.Text = "He should try to calm her down.";
                pictureDisplay.Image = Properties.Resources.page9;
                page = 9;
            }
            else if (page == 9)
            {
                storyLabel.Text = "OH NO! Cassie kills Tyler and takes her diary back! Game over.";
                leftButton.Text = "Try again.";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page6and10;
                page = 10;
                sp = new SoundPlayer(Properties.Resources.gamelose);
                sp.Play();
            }
            else if (page == 11)
            {
                storyLabel.Text = "OH NO! Tyler accidentilly trips an axe trap and dies. Game over.";
                leftButton.Text = "Try again.";
                rightButton.Visible = false;
                pictureDisplay.Image = Properties.Resources.page4and12;
                page = 12;
                sp = new SoundPlayer(Properties.Resources.gamelose);
                sp.Play();

            }
            

        }
    }
}
