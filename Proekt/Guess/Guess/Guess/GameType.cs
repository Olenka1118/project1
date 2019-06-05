using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class GameType : UserControl
    {
        string numeral;
        int GameT = 0;
        int k = 0;
        int pg = 0;
        bool lvl2 = false;
        bool lvl1 = true;
        string Num;
        int quantity;
        int digit = 0;
        int n1 = 1;
        int n2 = 0;

        public GameType(string s, int g)
        {
            InitializeComponent();
            Attempt.Text = "Шаг " + n1;
            Think.Text = s;
            GameT = g;

        }
        public GameType()
        {
            InitializeComponent();
        }

        private void GameType_Load(object sender, EventArgs e)
        {
            ChangeSize();
        }

        public void ChangeSize()
        {
            Level1.Font = new Font("Times New Roman", (int)(Height*0.05));

            Level1.Height = (int)(Height * 0.12);
            Level1.Width = (int)(Width * 0.25);

            Level1.Top = (int)(Height / 9.2 - Level1.Height / 2);
            Level1.Left = (int)(Width / 5.8 - Level1.Width / 2);

            Level2.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Level2.Height = (int)(Height * 0.12);
            Level2.Width = (int)(Width * 0.25);

            Level2.Top = (int)(Height / 9.2 - Level2.Height / 2);
            Level2.Left = (int)(Width / 2.15 - Level2.Width / 2);

            InputNumber.Font = new Font("Times New Roman", (int)(Height * 0.05));

            InputNumber.Height = (int)(Height * 0.9);
            InputNumber.Width = (int)(Width * 0.33);

            InputNumber.Top = (int)(Height / 1.99 - InputNumber.Height / 2);
            InputNumber.Left = (int)(Width / 1.24 - InputNumber.Width / 2);

            Think.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Think.Height = (int)(Height * 0.9);
            Think.Width = (int)(Width * 0.33);

            Think.Top = (int)(Height / 2.7 - Think.Height / 2);
            Think.Left = (int)(Width / 3.1 - Think.Width / 2);

            More.Font = new Font("Times New Roman", (int)(Height * 0.05));

            More.Height = (int)(Height * 0.9);
            More.Width = (int)(Width * 0.33);

            More.Top = (int)(Height / 1.9 - More.Height / 2);
            More.Left = (int)(Width / 2.9 - More.Width / 2);

            Choose.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Choose.Height = (int)(Height * 0.12);
            Choose.Width = (int)(Width * 0.08);

            Choose.Top = (int)(Height / 1.4 - Choose.Height / 2);
            Choose.Left = (int)(Width / 1.82 - Choose.Width / 2);

            Number.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Number.Height = (int)(Height * 0.8);
            Number.Width = (int)(Width * 0.11);

            Number.Top = (int)(Height / 1.4 - Number.Height / 2);
            Number.Left = (int)(Width / 2.4 - Number.Width / 2);

            Attempt.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Attempt.Height = (int)(Height * 0.8);
            Attempt.Width = (int)(Width * 0.11);

            Attempt.Top = (int)(Height / 1.4 - Attempt.Height / 2);
            Attempt.Left = (int)(Width / 5.4 - Attempt.Width / 2);
        }

        private void PeopleGuesses()
        {
            if (k == 0)
            {
                Random RG = new Random();
                pg = RG.Next(1, 100);
                k = 1;
            }
            string symbol = Number.Text;
            int character = Convert.ToInt32(symbol);
            n1 += 1;
            Attempt.Text = "Шаг " + n1;
            if (character > 100 || character < 1)
            {
                More.Text = "         Ошибка";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character < pg)
            {
                More.Text = "Мое число больше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character > pg)
            {
                More.Text = "Мое число меньше";
                Num = Number.Text;
                Number.Text = "";
            }          
            else if (character == pg) 
            {
                More.Text = "Вы угадали";
                Num = Number.Text;
                Number.Text = "";
                k = 0;
                if((n1-1) <= 7)
                {
                    Level2.Enabled = true;
                }      
                else
                {
                    More.Text = "Вы не прошли уровень";
                }
            }
        }

        private void GuessesPeople()
        {
            if (k == 0)
            {
                Random RG = new Random();
                pg = RG.Next(1, 1000);
                k = 1;
            }
            string symbol = Number.Text;
            int character = Convert.ToInt32(symbol);
            n1 += 1;
            Attempt.Text = "Шаг " + n1;
            if (character > 1000 || character < 1)
            {
                More.Text = "         Ошибка";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character < pg)
            {
                More.Text = "Мое число больше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character > pg)
            {
                More.Text = "Мое число меньше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character == pg)
            {
                More.Text = "Вы угадали";
                Num = Number.Text;
                Number.Text = "";
                k = 0;
                if ((n1 - 1) > 10)
                {
                    More.Text = "Вы не прошли уровень";
                }
            }
        }

        private void NumberOutput()
        {
            if (Num != "")
            {
                string[] s = Num.Split('\n');
                int a = Convert.ToInt32(s[s.Length - 1]);
                if (InputNumber.Text != "") InputNumber.Text += ",  ";
                InputNumber.Text += Convert.ToString(a);
            }
        }

        public void AndroidGuesses()
        {

            if (k == 0)
            {
                numeral = Number.Text;
                quantity = Convert.ToInt32(numeral);
                k = 1;
            }    
            if (quantity > 100 || quantity < 0)
            {
                More.Text = "         Ошибка";
                if (InputNumber.Text != "") InputNumber.Text += ",  ";
                InputNumber.Text += Convert.ToString(digit);
                n2 += 1;
                Attempt.Text = "Шаг " + n2;
            }
            digit = 100 / 2;
            if (InputNumber.Text != "") InputNumber.Text += ",  ";
            InputNumber.Text += Convert.ToString(digit);
            n2 += 1;
            Attempt.Text = "Шаг " + n2;
            int divisible = 50;
            while(quantity != digit)
            {
                if (quantity > digit)
                {
                    divisible = divisible / 2;
                    digit = digit + divisible;
                    if (InputNumber.Text != "") InputNumber.Text += ",  ";
                    InputNumber.Text += Convert.ToString(digit);
                    n2 += 1;
                    Attempt.Text = "Шаг " + n2;
                }
                else if (quantity < digit)
                {
                    divisible = divisible / 2;
                    digit = digit - divisible;
                    if (InputNumber.Text != "") InputNumber.Text += ",  ";
                    InputNumber.Text += Convert.ToString(digit);
                    n2 += 1;
                    Attempt.Text = "Шаг " + n2;
                }
            }
            if ((quantity = digit) != 0)
            {
                More.Text = "Число угадано";
                k = 0;
                digit = 0;
                Choose.Enabled = false;
                /*if ((n - 1) <= 7)
                {
                    Level2.Enabled = true;
                }
                else
                More.Text = "Вы не прошли уровень";*/
            }
        }

        private void GuessesAndroid()
        {
            if (k == 0)
            {
                numeral = Number.Text;
                quantity = Convert.ToInt32(numeral);
                k = 1;
            }
            if (quantity > 1000 || quantity < 0)
            {
                More.Text = "         Ошибка";
                if (InputNumber.Text != "") InputNumber.Text += ",  ";
                InputNumber.Text += Convert.ToString(digit);
                n2 += 1;
                Attempt.Text = "Шаг" + n2;
            }
            digit = 1000 / 2;
            if (InputNumber.Text != "") InputNumber.Text += ",  ";
            InputNumber.Text += Convert.ToString(digit);
            n2 += 1;
            Attempt.Text = "Шаг " + n2;
            int divisible = 500;
            while (quantity != digit)
            {
                if (quantity > digit)
                {
                    divisible = divisible / 2;
                    digit = digit + divisible;
                    if (InputNumber.Text != "") InputNumber.Text += ",  ";
                    InputNumber.Text += Convert.ToString(digit);
                    n2 += 1;
                    Attempt.Text = "Шаг " + n2;
                }
                else if (quantity < digit)
                {
                    divisible = divisible / 2;
                    digit = digit - divisible;
                    if (InputNumber.Text != "") InputNumber.Text += ",  ";
                    InputNumber.Text += Convert.ToString(digit);
                    n2 += 1;
                    Attempt.Text = "Шаг " + n2;
                }
            }
            if ((quantity = digit) != 0)
            {
                More.Text = "Число угадано";
                k = 0;
                digit = 0;
                Choose.Enabled = false;
                /*if ((n - 1) > 10)
                {
                    More.Text = "Вы не прошли уровень";
                }*/

            }
        }

        private void InputNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Level1_Click(object sender, EventArgs e)
        {
            if (GameT == 1)
            {
                lvl2 = false;
                Level2.BackColor = Color.FromArgb(255, 255, 192);
                More.Text = " ";
                n1 = 1;
                Attempt.Text = "Шаг " + n1;
                lvl1 = true;
                Level1.BackColor = Color.Yellow;
                Think.Text = "Я загадал число от 1 до 100";
                InputNumber.Text = "";
            }
            else if (GameT == 2)
            {
                lvl2 = false;
                Level2.BackColor = Color.FromArgb(255, 255, 192);
                Choose.Enabled = true;
                More.Text = " ";
                Number.Text = "";
                n2 = 1;
                Attempt.Text = "Шаг " + n2;
                lvl1 = true;
                Level1.BackColor = Color.Yellow;
                Think.Text = "Загадайте число от 1 до 100";
                InputNumber.Text = "";
            }

        }

        private void Level2_Click(object sender, EventArgs e)
        {
            if (GameT == 1)
            {
                lvl1 = false;
                Level1.BackColor = Color.FromArgb(255, 255, 192);
                More.Text = " ";
                n1 = 1;
                Attempt.Text = "Шаг " + n1;
                lvl2 = true;
                Level2.BackColor = Color.Yellow;
                Think.Text = "Я загадал число от 1 до 1000";
                InputNumber.Text = "";
            }
            else if (GameT == 2)
            {
                lvl1 = false;
                Level1.BackColor = Color.FromArgb(255, 255, 192);
                Choose.Enabled = true;
                More.Text = " ";
                Number.Text = "";
                n2 = 1;
                Attempt.Text = "Шаг " + n2;
                lvl2 = true;
                Level2.BackColor = Color.Yellow;
                Think.Text = "Загадайте число от 1 до 1000";
                InputNumber.Text = "";
            }
        }

        private void Think_Click(object sender, EventArgs e)
        {

        }

        private void Choose_Click(object sender, EventArgs e)
        {
            if (GameT == 1)
            {
                if (lvl1 == true)
                {
                    PeopleGuesses();
                    NumberOutput();
                }

                if (lvl2 == true)
                {
                    GuessesPeople();
                    NumberOutput();
                }
            }
            else if (GameT == 2)
            {
                if (lvl1 == true)
                {
                   AndroidGuesses();
                }
                if (lvl2 == true)
                {
                    GuessesAndroid();
                }
            }
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void More_Click(object sender, EventArgs e)
        {

        }

        private void Number_KeyPress(object sender, KeyPressEventArgs a)
        {
            char numbers = a.KeyChar;
            if (!Char.IsDigit(numbers))
            {
                a.Handled = true;
            }
        }

        private void Attempt_Click(object sender, EventArgs e)
        {

        }
    }
}