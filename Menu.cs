﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education
{
    public partial class Menu : Form
    {
        private Students students;
        private Subjects subjects;
        private Uspev uspev;
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Form F = new Students();
           F.Show();*/
           students= new Students();
            students.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            subjects = new Subjects ();
            subjects.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uspev = new Uspev();
            uspev.Visible = true;
        }
    }
}
