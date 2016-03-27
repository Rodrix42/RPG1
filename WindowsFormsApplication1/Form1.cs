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
        void StageOne ()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            button17.Visible = true;
            label19.Text = "Нажмите кнопку начать";
            
        }
        void StageTwo()
        {

            panel2.Visible = false;
            panel1.Visible = true;
            label19.Text = "Выберите атакующего.";
        }
        void StageThree()
        {
            if (agressor == p1)
            {
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                panel1.Visible = false;
                panel2.Visible = true;
                label19.Text = "Выбери цель";
            }
            if (agressor == pr1)
            {
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                panel1.Visible = false;
                panel2.Visible = true;
                label19.Text = "Выбери цель";
            }
            if (agressor == sh1)
            {
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                panel1.Visible = false;
                panel2.Visible = true;
                label19.Text = "Выбери цель";
            }
            if (agressor == r1)
            {
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                panel1.Visible = false;
                panel2.Visible = true;
                label19.Text = "Выбери цель";
            }

        }
        void StageFour()
        {
           
            panel1.Visible = false;
            panel2.Visible = true;
            

        }
        void StageFive()
        {

        }
        int stage = 1;
        Character agressor;
        Character p1 = new Palladin(800, 400, 80);
        Character p2 = new Palladin(800, 400, 80);
        Character r1 = new Rogue(360, 280, 100);
        Character r2 = new Rogue(360, 280, 100);
        Character sh1 = new Shaman(500, 700, 50);
        Character sh2 = new Shaman(500, 700, 50);
        Character pr1 = new Priest(400, 900, 30);
        Character pr2 = new Priest(400, 900, 30);
        private void Form1_Load(object sender, EventArgs e)
        {
            
            StageOne();
            stage = 2;
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
            progressBar1.Maximum = p2.Hp;
            progressBar2.Maximum = pr2.Hp;
            progressBar3.Maximum = sh2.Hp;
            progressBar4.Maximum = r2.Hp;
            progressBar5.Maximum = p1.Hp;
            progressBar6.Maximum = pr1.Hp;
            progressBar7.Maximum = sh1.Hp;
            progressBar8.Maximum = r1.Hp;
            progressBar9.Maximum = p2.Mp;
            progressBar10.Maximum = pr2.Mp;
            progressBar11.Maximum = sh2.Mp;
            progressBar12.Maximum = r2.Mp;
            progressBar13.Maximum = p1.Mp;
            progressBar14.Maximum = pr1.Mp;
            progressBar15.Maximum = sh1.Mp;
            progressBar16.Maximum = r1.Mp;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            button17.Enabled = false;
            StageTwo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                agressor = p1;
                stage = 3;
                StageThree();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agressor = pr1;
            stage = 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agressor = sh1;
            stage = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agressor = r1;
            stage = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (agressor == p1)
            {
                p1.target = p2;    
            }
            StageFour();
            if (agressor == pr1)
            {
                pr1.target = p2;
            }
            StageFour();
            if (agressor == sh1)
            {
                sh1.target = p2;
            }
            StageFour();
            if (agressor == r1)
            {
                r1.target = p2;
            }
            StageFour();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (agressor == p1)
            {
                p1.target = pr2;
            }
            StageFour();
            if (agressor == pr1)
            {
                pr1.target = pr2;
            }
            StageFour();
            if (agressor == sh1)
            {
                sh1.target = pr2;
            }
            StageFour();
            if (agressor == r1)
            {
                r1.target = pr2;
            }
            StageFour();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (agressor == p1)
            {
                p1.target = sh2;
            }
            StageFour();
            if (agressor == pr1)
            {
                pr1.target = sh2;
            }
            StageFour();
            if (agressor == sh1)
            {
                sh1.target = sh2;
            }
            StageFour();
            if (agressor == r1)
            {
                r1.target = sh2;
            }
            StageFour();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (agressor == p1)
            {
                p1.target = r2;
            }
            StageFour();
            if (agressor == pr1)
            {
                pr1.target = r2;
            }
            StageFour();
            if (agressor == sh1)
            {
                sh1.target = r2;
            }
            StageFour();
            if (agressor == r1)
            {
                r1.target = r2;
            }
            StageFour();
        }


    }
}
