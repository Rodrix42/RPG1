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
        public void winlose()
        {
            if (p1.Hp + pr1.Hp + sh1.Hp + r1.Hp == 0)
            {
                panel1.Visible = false;
                label19.Text = "Вторая команда победила!";
            }
            if (p2.Hp + pr2.Hp + sh2.Hp + r2.Hp == 0)
            {
                panel2.Visible = false;
                label19.Text = "Первая команда победила!";
            }
        }
        public void update()
        {
            label16.Text = p1.Hp.ToString();
            progressBar5.Value = p1.Hp;
            label14.Text = pr1.Hp.ToString();
            progressBar6.Value = pr1.Hp;
            label12.Text = sh1.Hp.ToString();
            progressBar7.Value = sh1.Hp;
            label10.Text = r1.Hp.ToString();
            progressBar8.Value = r1.Hp;
            label8.Text = p2.Hp.ToString();
            progressBar1.Value = p2.Hp;
            label6.Text = pr2.Hp.ToString();
            progressBar2.Value = pr2.Hp;
            label4.Text = sh2.Hp.ToString();
            progressBar3.Value = sh2.Hp;
            label2.Text = r2.Hp.ToString();
            progressBar4.Value = r2.Hp;
            label15.Text = p1.Mp.ToString();
            progressBar13.Value = p1.Mp;
            label13.Text = pr1.Mp.ToString();
            progressBar14.Value = pr1.Mp;
            label11.Text = sh1.Mp.ToString();
            progressBar15.Value = sh1.Mp;
            label9.Text = r1.Mp.ToString();
            progressBar16.Value = r1.Mp;
            label7.Text = p2.Mp.ToString();
            progressBar9.Value = p2.Hp;
            label5.Text = pr2.Mp.ToString();
            progressBar10.Value = pr2.Mp;
            label3.Text = sh2.Mp.ToString();
            progressBar11.Value = sh2.Mp;
            label1.Text = r2.Mp.ToString();
            progressBar12.Value = r2.Mp;
            label20.Text = p1.Dmg.ToString();
            label21.Text = pr1.Dmg.ToString();
            label22.Text = sh1.Dmg.ToString();
            label23.Text = r1.Dmg.ToString();
            label24.Text = p2.Dmg.ToString();
            label25.Text = pr2.Dmg.ToString();
            label26.Text = sh2.Dmg.ToString();
            label27.Text = r2.Dmg.ToString();
            if (p2.Hp == 0)
            {
                progressBar1.Visible = false;
                progressBar9.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label20.Visible = false;
                label28.Visible = false;
                button9.Visible = false;
                button9.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
            }
            if (pr2.Hp == 0)
            {
                progressBar2.Visible = false;
                progressBar10.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
            }
            if (sh2.Hp == 0)
            {
                progressBar3.Visible = false;
                progressBar11.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                button3.Visible = false;
                button3.Enabled = false;
            }
            if (r2.Hp == 0)
            {
                progressBar4.Visible = false;
                progressBar12.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                button4.Visible = false;
                button4.Enabled = false;
            }
            if (p1.Hp == 0)
            {
                progressBar5.Visible = false;
                progressBar13.Visible = false;
                label16.Visible = false;
                label15.Visible = false;
                button5.Visible = false;
                button5.Enabled = false;
            }
            if (pr1.Hp == 0)
            {
                progressBar6.Visible = false;
                progressBar14.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                button6.Visible = false;
                button6.Enabled = false;
            }
            if (sh1.Hp == 0)
            {
                progressBar7.Visible = false;
                progressBar15.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                button7.Visible = false;
                button7.Enabled = false;
            }
            if (r1.Hp == 0)
            {
                progressBar8.Visible = false;
                progressBar16.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                button8.Visible = false;
                button8.Enabled = false;
            }
           

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
            panel1.Visible = false;
            panel2.Visible = true;
            label19.Text = "Выберите цель.";
        }
        void StageFour()
        {
           
            panel1.Visible = false;
            panel2.Visible = true;
            label19.Text = "Выбери атакующего";

        }
        void StageFive()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            label19.Text = "Выберите цель.";
        }
        int typeOfAttack = 0;
        int skill = 0;
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
            label20.Text = p1.Dmg.ToString();
            label21.Text = pr1.Dmg.ToString();
            label22.Text = sh1.Dmg.ToString();
            label23.Text = r1.Dmg.ToString();
            label24.Text = p2.Dmg.ToString();
            label25.Text = pr2.Dmg.ToString();
            label26.Text = sh2.Dmg.ToString();
            label27.Text = r2.Dmg.ToString();
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
            update();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            button17.Enabled = false;
            stage = 2;
            StageTwo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                agressor = p1;
                winlose();
                stage = 3;
                typeOfAttack = 0;
                StageThree();
            }
            else if (stage == 5)
            {
                agressor.target = p1;
                if(typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if(typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if(typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                agressor = pr1;
                
                winlose();
                stage = 3;
                typeOfAttack = 0;
                StageThree();
            }
            else if (stage == 5)
            {
                agressor.target = pr1;
                if (typeOfAttack == 0)
                {
                    update();
                    agressor.attack();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 11)
                {
                    update();
                    agressor.Skill1();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 12)
                {
                    update();
                    agressor.Skill1();
                    stage = 4;
                    StageFour();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                agressor = sh1;
                winlose();
                stage = 3;
                typeOfAttack = 0;
                StageThree();
            }
            else if (stage == 5)
            {
                agressor.target = sh1;
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                agressor = r1;
                winlose();
                stage = 3;
                typeOfAttack = 0;
                StageThree();
            }
            else if (stage == 5)
            {
                agressor.target = r1;
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                agressor.target = p2;
                
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
            }
            else if(stage == 4)
            {
                agressor = p2;
                typeOfAttack = 0;
                winlose();
                stage = 5;
                StageFive();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                agressor.target = pr2;
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
            }
            else if (stage == 4)
            {
                agressor = pr2;
                winlose();
                stage = 5;
                typeOfAttack = 0;
                StageFive();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                agressor.target =sh2;
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
            }
            else if (stage == 4)
            {
                agressor = sh2;
                stage = 5;
                typeOfAttack = 0;
                StageFive();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                agressor.target = r2;
                if (typeOfAttack == 0)
                {
                    agressor.attack();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 11)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 4;
                    StageFour();
                }
                if (typeOfAttack == 12)
                {
                    agressor.Skill1();
                    update();
                    winlose();
                    stage = 2;
                    StageTwo();
                }
            }
            else if (stage == 4)
            {
                agressor = r2;
                winlose();
                stage = 5;
                typeOfAttack = 0;
                StageFive();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            agressor = p1;
            typeOfAttack = 11;
            stage = 3;
            StageThree();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            agressor = p2;
            typeOfAttack = 11;
            stage = 5;
            StageFive();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agressor = pr1;
            typeOfAttack = 12;
            stage = 5;
            StageFive();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            agressor = pr2;
            typeOfAttack = 12;
            stage = 3;
            StageThree();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agressor = sh1;
            typeOfAttack = 12;
            stage = 5;
            StageFive();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agressor = r1;
            typeOfAttack = 12;
            stage = 5;
            StageFive();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            agressor = sh2;
            typeOfAttack = 12;
            stage = 3;
            StageThree();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            agressor = r2;
            typeOfAttack = 12;
            stage = 3;
            StageThree();
        }
    }
}
