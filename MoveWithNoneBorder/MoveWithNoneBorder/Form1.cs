using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveWithNoneBorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool tutus;
        int FareX, FareY;


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true) {

                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }
    }
}
