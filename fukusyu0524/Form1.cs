﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0524
{
    public partial class Form1 : Form
    {
        int vx;
        int vy;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -5;
            vy = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -10;
            vy = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 10;
            vy = -5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 5;
            vy = 10;
        }
    }
}
