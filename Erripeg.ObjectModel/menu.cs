﻿using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erripeg.ObjectModel
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            label4.Text = Usuario.life.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text = random.Next(1, 20).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label2.Text = random.Next(1, 6).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (textBox1.Text.Any())
            {
                label3.Text = random.Next(1, Int32.Parse(textBox1.Text)).ToString();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CriaçãoPersonagem c = new CriaçãoPersonagem();
            c.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Bestiario b = new Bestiario();
            b.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label4.Text = (Int32.Parse(label4.Text) - Int32.Parse(textBox2.Text)).ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label4.Text = (Int32.Parse(label4.Text) + Int32.Parse(textBox3.Text)).ToString();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
