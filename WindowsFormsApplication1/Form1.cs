using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Character p1 = new Palladin(800, 400, 80);
            Character p2 = new Palladin(800, 400, 80);
            Character r1 = new Rogue(360, 280, 100);
            Character r2 = new Rogue(360, 280, 100);
            Character sh1 = new Shaman(500, 700, 50);
            Character sh2 = new Shaman(500, 700, 50);
            Character pr1 = new Priest(400, 900, 30);
            Character pr2 = new Priest(400, 900, 30);
            label16.Text = p1.Hp.ToString();
            label15.Text = p1.Mp.ToString();
            label14.Text = pr1.Hp.ToString();
            label13.Text = pr1.Mp.ToString();
            label12.Text = sh1.Hp.ToString();
            label11.Text = sh1.Mp.ToString();
            label10.Text = r1.Hp.ToString();
            label9.Text = r1.Mp.ToString();
            label8.Text = p2.Hp.ToString();
            label7.Text = p2.Mp.ToString();
            label6.Text = pr2.Hp.ToString();
            label5.Text = pr2.Mp.ToString();
            label4.Text = sh2.Hp.ToString();
            label3.Text = sh2.Mp.ToString();
            label2.Text = r2.Hp.ToString();
            label1.Text = r2.Mp.ToString();
        }
    }
}
