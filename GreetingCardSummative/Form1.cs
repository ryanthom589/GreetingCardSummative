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
/// canvas is 600 length by 370 width
/// </summary>
namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
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


            //Introduction to card
            g.DrawString("Tigtag\nConstellation", titleFont, titleBrush, 60, 80);
            Thread.Sleep(1000);

            //first point
            g.Clear(Color.Black);
            g.FillEllipse(dotBrush, 132, 67, 10, 10);
            Thread.Sleep(1000);

            g.FillEllipse(dotBrush, 114, 145, 10, 10);
            Thread.Sleep(1000);
            //114,145

            g.FillEllipse(dotBrush, 68, 164, 10, 10);
            Thread.Sleep(1000);
            //68,164

            g.FillEllipse(dotBrush, 154, 107, 10, 10);
            Thread.Sleep(1000);
            //154,107

            g.FillEllipse(dotBrush, 203, 75, 10, 10);
            Thread.Sleep(1000);
            //203,75

            //212,39

            //212,40

            //220,28

            //235,13

            //second constellation

            //259,90

            //303,121

            //357,143

            //420,135

            //439,167

            //502,133

            //474,102

        }
    
        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Blue);
            Font titleFont = new Font("Mongolian Baiti", 36);
            SolidBrush titleBrush = new SolidBrush(Color.White);
        }
    }
}
