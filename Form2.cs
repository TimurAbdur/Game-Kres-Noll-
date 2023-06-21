using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики___Нолики
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.Enabled = false;
            }

        }
        bool FirstPlayer = true;
        byte btn3,
            btn4,
            btn5,
            btn6,
            btn7,
            btn8,
            btn9,
            btn10,
            btn11;

        void Cheked()
        {
           

            //Проверка в линию
            if ((((btn3 == 1 && btn5 == 1 && btn8 == 1) || (btn4 == 1 && btn6 == 1 && btn7 == 1) || (btn9 == 1 && btn10 == 1 && btn11 == 1)) ||
                //В ряд
                ((btn3 == 1 && btn4 == 1 && btn9 == 1) || (btn5 == 1 && btn6 == 1 && btn10 == 1) || (btn8 == 1 && btn7 == 1 && btn11 == 1))) ||
                //под углом
                ((btn3 == 1 && btn6 == 1 && btn11 == 1) || (btn8 == 1 && btn6 == 1 && btn9 == 1)))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Крестики победил!";
                richTextBox1.LoadFile("log5.rtf");
                richTextBox1.Text += $"Дата игры [{DateTime.Now.ToString("dd.MM.yy HH.mm.ss")}]\nПобедили Крестики!\n\n";
                richTextBox1.SaveFile("log5.rtf");
               
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
                btn3 = 0;
                btn4 = 0;
                btn5 = 0;
                btn6 = 0;
                btn7 = 0;
                btn8 = 0;
                btn9 = 0;
                btn10 = 0;
                btn11 = 0;
            }
            else if ((((btn3 == 2 && btn5 == 2 && btn8 == 2) || (btn4 == 2 && btn6 == 2 && btn7 == 2) || (btn9 == 2 && btn10 == 2 && btn11 == 2)) ||
                //В ряд
                ((btn3 == 2 && btn4 == 2 && btn9 == 2) || (btn5 == 2 && btn6 == 2 && btn10 == 2) || (btn8 == 2 && btn7 == 2 && btn11 == 2))) ||
                //под углом
                ((btn3 == 2 && btn6 == 2 && btn11 == 2) || (btn8 == 2 && btn6 == 2 && btn9 == 2)))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Нолики победил!";
                richTextBox1.LoadFile("log5.rtf");
                richTextBox1.Text += $"Дата игры [{DateTime.Now.ToString("dd.MM.yy HH.mm.ss")}]\nПобедили Нолики!\n\n";
                richTextBox1.SaveFile("log5.rtf");
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
                btn3 = 0;
                btn4 = 0;
                btn5 = 0;
                btn6 = 0;
                btn7 = 0;
                btn8 = 0;
                btn9 = 0;
                btn10 = 0;
                btn11 = 0;
            }
            else if (btn3 != 0 && btn4 != 0 && btn5 != 0 && btn6 != 0 && btn7 != 0 && btn8 != 0 && btn9 != 0 && btn10 != 0 && btn11 != 0)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Ничья!";
                richTextBox1.LoadFile("log5.rtf");
                richTextBox1.Text += $"Дата игры [{DateTime.Now.ToString("dd.MM.yy HH.mm.ss")}]\nНичья!\n\n";
                richTextBox1.SaveFile("log5.rtf");
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
                btn3 = 0;
                btn4 = 0;
                btn5 = 0;
                btn6 = 0;
                btn7 = 0;
                btn8 = 0;
                btn9 = 0;
                btn10 = 0;
                btn11 = 0;
            }
            richTextBox1.SaveFile("log.rtf");
        }

        void p(ref Button btn)
        {
            if (FirstPlayer)
            {
                label1.Text = "Ходит игрок 2!";
                label1.ForeColor = Color.Red;
                btn.BackgroundImage = Image.FromFile("X.png");
                FirstPlayer = false;
            }
            else
            {
                label1.Text = "Ходит игрок 1!";
                label1.ForeColor = Color.Green;
                btn.BackgroundImage = Image.FromFile("O.png");
                FirstPlayer = true;
            }
            btn.Enabled = false;
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            p(ref button3);

            btn3 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p(ref button5);
            btn5 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p(ref button8);
            btn8 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void выйтиВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p(ref button4);
            btn4 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3×3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или большой диагонали, выигрывает.", "Справка",
               MessageBoxButtons.OK, MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p(ref button6);
            btn6 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            p(ref button7);
            btn7 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p(ref button9);
            btn9 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p(ref button10);
            btn10 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            p(ref button11);
            btn11 = FirstPlayer ? (byte)2 : (byte)1;
            Cheked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        bool isStart = true;
        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Ходит игрок 1!";
            label1.ForeColor = Color.Green;
            if(isStart)
            {
                menuStrip1.Items[0].Text = "Заново";
                isStart = false;
                FirstPlayer = true;
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.BackgroundImage = null;
                    btn.Enabled = true;
                }

            }
            else
            {
                menuStrip1.Items[0].Text = "Начать";
                isStart = true;
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                    btn.BackgroundImage = null;
                }
                btn3 = 0;
                btn4 = 0;
                btn5 = 0;
                btn6 = 0;
                btn7 = 0;
                btn8 = 0;
                btn9 = 0;
                btn10 = 0;
                btn11 = 0;
                label1.Text = "Жми начать!";
                label1.ForeColor = Color.Black;
            }
           

        }
    }
}
