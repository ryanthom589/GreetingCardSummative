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
/// Created by Ryan
/// September 24th 2019
/// Greeting Card Summative
/// </summary>
namespace GreetingCardSummative
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Font titleFont = new Font("Courier New", 16);
            SolidBrush titleBrush = new SolidBrush(Color.White);
            SolidBrush dotBrush = new SolidBrush(Color.White);
            SolidBrush titleBrush2 = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.White, 2);
            SoundPlayer success = new SoundPlayer(Properties.Resources.starSound);
            SoundPlayer finish = new SoundPlayer(Properties.Resources.finish);




            //Introduction to card
            g.DrawString("Tigtag\nConstellation", titleFont, titleBrush, 60, 80);
            Thread.Sleep(300);

            //first point
            g.Clear(Color.Black);
            success.Play();
            g.FillEllipse(dotBrush, 132, 67, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 137, 71, 160, 115);
            Thread.Sleep(600);
            success.Play();

            g.FillEllipse(dotBrush, 154, 107, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 160, 112, 120, 150);
            Thread.Sleep(600);
            success.Play();
            //dot/line 2

            g.FillEllipse(dotBrush, 114, 145, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 120, 150, 57, 170);
            Thread.Sleep(600);
            success.Play();
            //dot/line 3

            g.FillEllipse(dotBrush, 53, 164, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 154, 117, 210, 90);
            Thread.Sleep(600);
            success.Play();
            //dot/line 4

            g.FillEllipse(dotBrush, 205, 85, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 210, 90, 217, 45);
            Thread.Sleep(600);
            success.Play();

            //dot/line 5

            g.FillEllipse(dotBrush, 212, 39, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 212, 45, 255, 13);
            Thread.Sleep(600);
            success.Play();
            //dot 5/line 5/6

            g.FillEllipse(dotBrush, 235, 20, 10, 10);
            Thread.Sleep(600);
            success.Play();
            //dot 6

            g.FillEllipse(dotBrush, 250, 7, 10, 10);
            Thread.Sleep(600);
            success.Play();
            //dot/line 7

            g.FillEllipse(dotBrush, 185, 150, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 154, 107, 230, 205);
            Thread.Sleep(600);
            success.Play();
            //dot 8/line 8-10

            g.FillEllipse(dotBrush, 205, 175, 10, 10);
            Thread.Sleep(600);
            success.Play();
            //dot 9

            g.FillEllipse(dotBrush, 225, 200, 10, 10);
            Thread.Sleep(600);
            //dot 10

            //second constellation
            success.Play();
            g.FillEllipse(dotBrush, 259, 90, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 263, 92, 307, 125);
            Thread.Sleep(600);
            success.Play();
            //dot/line 1

            g.FillEllipse(dotBrush, 303, 121, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 307, 125, 362, 148);
            Thread.Sleep(600);
            success.Play();
            //dot/line 2

            g.FillEllipse(dotBrush, 357, 143, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 362, 148, 425, 140);
            Thread.Sleep(600);
            success.Play();
            //dot/line 3

            g.FillEllipse(dotBrush, 420, 135, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 425, 140, 444, 172);
            Thread.Sleep(600);
            success.Play();
            //dot/line 4

            g.FillEllipse(dotBrush, 439, 167, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 444, 172, 507, 138);
            Thread.Sleep(600);
            success.Play();
            //dot/line 5

            g.FillEllipse(dotBrush, 502, 133, 10, 10);
            Thread.Sleep(600);
            success.Play();
            g.DrawLine(drawPen, 507, 138, 479, 107);
            Thread.Sleep(600);
            success.Play();
            //dot/line 6

            g.FillEllipse(dotBrush, 474, 102, 10, 10);
            Thread.Sleep(600);
            //dot 7
            finish.Play();
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush2, 350, 250);
            Thread.Sleep(1000);
            

            //474,102

            //

        }
    
        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Font titleFont = new Font("Mongolian Baiti", 36);
            Font titleFont2 = new Font("Arabic", 16);
            SolidBrush titleBrush = new SolidBrush(Color.White);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 9, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 19, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 29, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 39, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 49, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 59, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 69, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 79, 90);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            g.DrawString("The\nTigtag\nConstellation", titleFont, titleBrush, 90, 90);
            Thread.Sleep(100);
            g.DrawString("Made of\n18 Stars", titleFont2, titleBrush, 400, 190);
            g.DrawString("Click to play", titleFont2, titleBrush, 150, 300);
        }
    }
}
