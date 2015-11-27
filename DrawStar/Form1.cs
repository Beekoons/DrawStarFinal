using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            
            Pen starPen = new Pen(Color.Black, 1);
            DrawStar(starPen, 1, 1, 200);
        }

        /// <summary>
        /// Star Drawing Method
        /// </summary>
        /// <param name="pen">the pen to be used</param>
        /// <param name="x">the x position of the star</param>
        /// <param name="y">the y position of the star</param>
        /// <param name="size">the overall size of the star</param>
        public void DrawStar(Pen pen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, (size*(0 + x))/205, (size * (75 + y))/195, (size * (79 + x))/205, (size * (75 + y))/195);
            g.DrawLine(pen, (size * (79 + x))/205, (size * (75 + y))/195, (size * (103 + x))/205, (size * (0 + y))/195);
            g.DrawLine(pen, (size * (103 + x))/205, (size * (0 + y))/195, (size * (127 + x))/205, (size * (75 + y))/195);
            g.DrawLine(pen, (size * (127 + x))/205, (size * (75 + y))/195, (size * (205 + x))/205, (size * (75 + y))/195);
            g.DrawLine(pen, (size * (205 + x))/205, (size * (75 + y))/195, (size * (141 + x))/205, (size * (122 + y))/195);
            g.DrawLine(pen, (size * (141 + x))/205, (size * (122 + y))/195, (size * (165 + x)/205), (size * (195 + y))/195);
            g.DrawLine(pen, (size * (165 + x))/205, (size * (195 + y))/195, (size * (103 + x))/205, (size * (149 + y))/195);
            g.DrawLine(pen, (size * (103 + x))/205, (size * (149 + y))/195, (size * (39 + x)/205), (size * (195 + y))/195);
            g.DrawLine(pen, (size * (39 + x))/205, (size * (195 + y))/195, (size * (64 + x))/205, (size * (122 + y))/195);
            g.DrawLine(pen, (size * (64 + x))/205, (size * (122 + y))/195, (size * (0 + x))/205, (size * (75 + y))/195);

        }
    }
}
