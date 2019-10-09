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

/// <summary>
/// Erik Smith
/// Greeting Card Summative
/// September 24, 2019
/// </summary>
namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font frontFont = new Font("Harrington", 90, FontStyle.Bold);
            SolidBrush frontBrush = new SolidBrush(Color.DarkSeaGreen);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush greenBrush = new SolidBrush(Color.ForestGreen);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.AliceBlue);

            g.Clear(Color.IndianRed);

            //Front of Card
            g.DrawString("   Merry \nChristmas", frontFont, frontBrush, 100, 150);
            g.FillRectangle(whiteBrush, 0, 500, 2000, 500);
            //Tree
            g.FillPie(greenBrush, 800, 70, 100, 100, 55, 70);
            g.FillPie(greenBrush, 775, 70, 150, 150, 55, 70);
            g.FillPie(greenBrush, 760, 80, 180, 180, 55, 70);
            g.FillPie(greenBrush, 740, 90, 220, 220, 55, 70);
            g.FillPie(greenBrush, 725, 110, 250, 250, 55, 70);
            g.FillPie(greenBrush, 705, 120, 290, 290, 55, 70);
            g.FillRectangle(brownBrush, 825, 450, 50, 50);
            g.FillPie(greenBrush, 680, 120, 340, 340, 55, 70);
            //Ornaments
            g.FillEllipse(redBrush, 825, 300, 10, 10);
            g.FillEllipse(redBrush, 850, 250, 10, 10);
            g.FillEllipse(redBrush, 845, 360, 10, 10);
            g.FillEllipse(redBrush, 870, 200, 10, 10);
            g.FillEllipse(redBrush, 900, 400, 10, 10);
            g.FillEllipse(redBrush, 810, 380, 10, 10);
            g.FillEllipse(redBrush, 790, 410, 10, 10);
            g.FillEllipse(redBrush, 840, 150, 10, 10);
            g.FillEllipse(redBrush, 830, 190, 10, 10);
            g.FillEllipse(redBrush, 860, 310, 10, 10);
            g.FillEllipse(redBrush, 870, 390, 10, 10);
            g.FillEllipse(redBrush, 820, 410, 10, 10);
            g.FillEllipse(redBrush, 820, 250, 10, 10);
            g.FillEllipse(blueBrush, 850, 410, 10, 10);
            g.FillEllipse(blueBrush, 850, 210, 10, 10);
            g.FillEllipse(blueBrush, 815, 280, 10, 10);
            g.FillEllipse(blueBrush, 830, 340, 10, 10);
            g.FillEllipse(blueBrush, 890, 370, 10, 10);
            g.FillEllipse(blueBrush, 880, 290, 10, 10);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font frontFont = new Font("Harrington", 90, FontStyle.Bold);
            Font normalFont = new Font("Ariel", 90, FontStyle.Bold);
            SolidBrush frontBrush = new SolidBrush(Color.DarkSeaGreen);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush greenBrush = new SolidBrush(Color.ForestGreen);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush cadetBrush = new SolidBrush(Color.CadetBlue);
            SoundPlayer hohoho = new SoundPlayer(Properties.Resources.HOHOHO1);
            SoundPlayer bells = new SoundPlayer(Properties.Resources.Bells);

            //Frame 1 (Start Frame After Click)
            bells.Play();
            Thread.Sleep(2480);
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 270, 350, 40);
            g.FillRectangle(yellowBrush, 450, 270, 20, 40);
            Thread.Sleep(1000);

            //Frame 2 (Animation Start)
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 260, 350, 40);
            g.FillRectangle(yellowBrush, 450, 260, 20, 40);
            Thread.Sleep(200);

            //Frame 3
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 250, 350, 40);
            g.FillRectangle(yellowBrush, 450, 250, 20, 40);
            Thread.Sleep(200);

            //Frame 4
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 240, 350, 40);
            g.FillRectangle(yellowBrush, 450, 240, 20, 40);
            Thread.Sleep(200);

            //Frame 5
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 230, 350, 40);
            g.FillRectangle(yellowBrush, 450, 230, 20, 40);
            Thread.Sleep(200);

            //Frame 6
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 220, 350, 40);
            g.FillRectangle(yellowBrush, 450, 220, 20, 40);
            Thread.Sleep(200);

            //Frame 7
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 210, 350, 40);
            g.FillRectangle(yellowBrush, 450, 210, 20, 40);
            Thread.Sleep(200);

            //Frame 8
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 200, 350, 40);
            g.FillRectangle(yellowBrush, 450, 200, 20, 40);
            Thread.Sleep(200);

            //Frame 9
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 190, 350, 40);
            g.FillRectangle(yellowBrush, 450, 190, 20, 40);
            Thread.Sleep(200);

            //Frame 10
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 180, 350, 40);
            g.FillRectangle(yellowBrush, 450, 180, 20, 40);
            Thread.Sleep(200);

            //Frame 11
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 170, 350, 40);
            g.FillRectangle(yellowBrush, 450, 170, 20, 40);
            Thread.Sleep(200);

            //Frame 12
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 160, 350, 40);
            g.FillRectangle(yellowBrush, 450, 160, 20, 40);
            Thread.Sleep(200);

            //Frame 13
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 140, 350, 40);
            g.FillRectangle(yellowBrush, 450, 140, 20, 40);
            Thread.Sleep(200);

            //Frame 14
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 120, 350, 40);
            g.FillRectangle(yellowBrush, 450, 120, 20, 40);
            Thread.Sleep(200);

            //Frame 15
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 100, 350, 40);
            g.FillRectangle(yellowBrush, 450, 100, 20, 40);
            Thread.Sleep(200);

            //Frame 16
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 80, 350, 40);
            g.FillRectangle(yellowBrush, 450, 80, 20, 40);
            Thread.Sleep(200);

            //Frame 17
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 60, 350, 40);
            g.FillRectangle(yellowBrush, 450, 60, 20, 40);
            Thread.Sleep(200);

            //Frame 18
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 40, 350, 40);
            g.FillRectangle(yellowBrush, 450, 40, 20, 40);
            Thread.Sleep(200);

            //Frame 19
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 20, 350, 40);
            g.FillRectangle(yellowBrush, 450, 20, 20, 40);
            Thread.Sleep(200);

            //Frame 20
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 20, 350, 40);
            g.FillRectangle(yellowBrush, 450, 20, 20, 40);
            Thread.Sleep(200);

            //Frame 21 (Ball Starts to come out of present)
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillEllipse(redBrush, 450, 260, 30, 30);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, 0, 350, 40);
            g.FillRectangle(yellowBrush, 450, 0, 20, 40);
            Thread.Sleep(200);

            //Frame 22 
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillEllipse(redBrush, 450, 250, 40, 40);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillRectangle(cadetBrush, 275, -30, 350, 40);
            g.FillRectangle(yellowBrush, 450, -30, 20, 40);
            Thread.Sleep(200);

            //Frame 23
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillEllipse(redBrush, 450, 230, 50, 50);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            Thread.Sleep(200);

            //Frame 24
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillEllipse(redBrush, 450, 210, 60, 60);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            Thread.Sleep(200);

            //Frame 25
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillEllipse(redBrush, 450, 200, 60, 60);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            Thread.Sleep(200);

            //Frame 26
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 450, 190, 70, 70);
            Thread.Sleep(200);

            //Frame 27
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 470, 200, 80, 80);
            Thread.Sleep(200);

            //Frame 28
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 480, 200, 90, 90);
            Thread.Sleep(200);

            //Frame 29
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 480, 210, 100, 100);
            Thread.Sleep(200);

            //Frame 30
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 480, 210, 110, 110);
            Thread.Sleep(200);

            //Frame 31
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 480, 210, 130, 130);
            Thread.Sleep(200);

            //Frame 32
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 480, 210, 150, 150);
            Thread.Sleep(200);

            //Frame 33
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 500, 230, 170, 170);
            Thread.Sleep(200);

            //Frame 34
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 500, 230, 190, 190);
            Thread.Sleep(200);

            //Frame 35
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 500, 230, 240, 240);
            Thread.Sleep(200);

            //Frame 36
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 500, 230, 270, 270);
            Thread.Sleep(200);

            //Frame 37
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 470, 200, 310, 310);
            Thread.Sleep(200);

            //Frame 38
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 440, 180, 360, 360);
            Thread.Sleep(200);

            //Frame 39
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 420, 160, 400, 400);
            Thread.Sleep(200);

            //Frame 40
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 410, 150, 460, 460);
            Thread.Sleep(200);

            //Frame 41
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 390, 130, 500, 500);
            Thread.Sleep(200);

            //Frame 42
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 390, 130, 560, 560);
            Thread.Sleep(200);

            //Frame 43
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 350, 100, 630, 630);
            Thread.Sleep(200);

            //Frame 44
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 300, 50, 700, 700);
            Thread.Sleep(200);

            //Frame 45
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 300, 50, 700, 700);
            Thread.Sleep(200);

            //Frame 46
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 270, 30, 800, 800);
            Thread.Sleep(200);

            //Frame 47
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, 200, 30, 1000, 1000);
            Thread.Sleep(200);

            //Frame 48
            g.Clear(Color.IndianRed);
            g.FillRectangle(whiteBrush, 0, 400, 2000, 500);
            g.FillRectangle(brownBrush, 800, 50, 200, 400);
            g.FillPie(greenBrush, -110, -1750, 2000, 2000, 55, 70);
            g.FillRectangle(cadetBrush, 300, 270, 300, 300);
            g.FillRectangle(yellowBrush, 450, 310, 20, 260);
            g.FillRectangle(yellowBrush, 300, 415, 300, 20);
            g.FillEllipse(redBrush, -200, -100, 2000, 2000);
            Thread.Sleep(200);

            //Frame 49 
            g.Clear(Color.Red);
            Thread.Sleep(500);

            //Frame 50
            g.Clear(Color.Red);
            g.DrawString("    Have a Very \nMerry Christmas!", frontFont, frontBrush, 60, 150);
            Thread.Sleep(700);

            //Frame 51 (Flashing words)
            g.Clear(Color.DarkSeaGreen);
            g.DrawString("    Have a Very \nMerry Christmas!", normalFont, redBrush, 50, 150);
            Thread.Sleep(700);

            //Frame 52
            g.Clear(Color.Red);
            g.DrawString("    Have a Very \nMerry Christmas!", frontFont, frontBrush, 60, 150);
            Thread.Sleep(700);

            //Frame 53
            g.Clear(Color.DarkSeaGreen);
            g.DrawString("    Have a Very \nMerry Christmas!", normalFont, redBrush, 50, 150);
            Thread.Sleep(700);

            //Frame 54
            g.Clear(Color.Red);
            g.DrawString("    Have a Very \nMerry Christmas!", frontFont, frontBrush, 60, 150);
            Thread.Sleep(700);

            //Frame 55
            g.Clear(Color.DarkSeaGreen);
            g.DrawString("    Have a Very \nMerry Christmas!", normalFont, redBrush, 50, 150);
            Thread.Sleep(700);

            //Frame 56
            g.Clear(Color.Red);
            g.DrawString("    Have a Very \nMerry Christmas!", frontFont, frontBrush, 60, 150);
            Thread.Sleep(700);

            //Frame 57
            g.Clear(Color.DarkSeaGreen);
            g.DrawString("    Have a Very \nMerry Christmas!", normalFont, redBrush, 50, 150);
            Thread.Sleep(700);

            //Frame 58
            g.Clear(Color.Red);
            g.DrawString("    Have a Very \nMerry Christmas!", frontFont, frontBrush, 60, 150);
            Thread.Sleep(700);

            //Frame 59 (Santa claus ho ho ho)
            g.Clear(Color.Red);
            g.DrawString("HO! HO! HO!", frontFont, frontBrush, 170, 270);
            hohoho.Play();
        }
    }
}
