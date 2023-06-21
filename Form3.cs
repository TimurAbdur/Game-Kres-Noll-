using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики___Нолики
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3×3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или большой диагонали, выигрывает.", "Справка",
              MessageBoxButtons.OK, MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1);
        }

        private void выйтиВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool isStart = true;
        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Игра началась!";  
            if (isStart)
            {
                menuStrip1.Items[0].Text = "Заново";
                isStart = false;
                foreach (Button btn in Controls.OfType<Button>())
                {
                    btn.BackgroundImage = null;
                    btn.Enabled = true;
                }

            }
            else
            {
                menuStrip1.Items[0].Text = "Начать";
                label1.Text = "Жми начать!";
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
            }
        }

        Button[,] btns = new Button[3,3];
        
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.Enabled = false;
            }
            btns[0,0] = button3; btns[0,1] = button5; btns[0,2] = button8;
            btns[1,0] = button4; btns[1,1] = button6; btns[1,2] = button7;
            btns[2,0] = button9; btns[2,1] = button10; btns[2,2] = button11;
        }


        byte btn3,
          btn4,
          btn5,
          btn6,
          btn7,
          btn8,
          btn9,
          btn10,
          btn11;

        private void button9_Click(object sender, EventArgs e)
        {
            btn9 = 1;
            button9.BackgroundImage = Image.FromFile("X.png");
            button9.Enabled = false;
            Bot();
            Cheked();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn10 = 1;
            button10.BackgroundImage = Image.FromFile("X.png");
            button10.Enabled = false;
            Bot();
            Cheked();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn11 = 1;
            button11.BackgroundImage = Image.FromFile("X.png");
            button11.Enabled = false;
            Bot();
            Cheked();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn7 = 1;
            button7.BackgroundImage = Image.FromFile("X.png");
            button7.Enabled = false;
            Bot();
            Cheked();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn6 = 1;
            button6.BackgroundImage = Image.FromFile("X.png");
            button6.Enabled = false;
            Bot();
            Cheked();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn4 = 1;
            button4.BackgroundImage = Image.FromFile("X.png");
            button4.Enabled = false;
            Bot();
            Cheked();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn8 = 1;
            button8.BackgroundImage = Image.FromFile("X.png");
            button8.Enabled = false;
            Bot();
            Cheked();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn5 = 1;
            button5.BackgroundImage = Image.FromFile("X.png");
            button5.Enabled = false;
            Bot();
            Cheked();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3 = 1;
            button3.BackgroundImage = Image.FromFile("X.png");
            button3.Enabled = false;
            Bot();
            Cheked();
        }

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
                MessageBox.Show("Ха-ха-ха, я умнее тебя! У меня памяти 16 мб!", "Вас победил бот!",
              MessageBoxButtons.OK, MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1);
            }
            else if (btn3 != 0 && btn4 != 0 && btn5 != 0 && btn6 != 0 && btn7 != 0 && btn8 != 0 && btn9 != 0 && btn10 != 0 && btn11 != 0)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Ничья!";
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

        }

        private void Bot()
        {
            Random random = new Random();
            bool isTur = true; int x, y;
            do
            {
                x = random.Next(3);
                y = random.Next(3);
                if (btns[x, y].Enabled != false) { btns[x, y].Enabled = false; btns[x, y].BackgroundImage = Image.FromFile("O.png");  isTur = false; 
                    if(x == 0&& y ==0) btn3 = 2;
                    if (x == 0 && y == 1) btn5 = 2;
                    if (x == 0 && y == 2) btn8 = 2;
                    if (x == 1 && y == 0) btn4 = 2;
                    if (x == 1 && y == 1) btn6 = 2;
                    if (x == 1 && y == 2) btn7 = 2;
                    if (x == 2 && y == 0) btn9 = 2;
                    if (x == 2 && y == 1) btn10 = 2;
                    if (x == 2 && y == 2) btn11 = 2;
                }
                
            } while (isTur);
        }
    }
}
