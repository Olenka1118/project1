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
using System.Collections;

namespace Guess
{
    public partial class TheInitialWindow : Form
    {
        //bool islogged = false;
        GameType TypeGame = new GameType();
        GuessesMan PlayRules = new GuessesMan();
        string MakeNumber;
        //public bool Man = false;
        //bool Computer = false;

        public TheInitialWindow() 
        {
            InitializeComponent();
        } 

        private void TheInitialWindow_Activated(object sender, EventArgs e)
        {
            if (File.Exists("User.txt"))
            {
                
            }
            else
            {
                Form form = new Login();
                form.ShowDialog();
            }
        }

        private void DeleteItems()
        {
            if (TypeGame != null)
            {
                main_window.Controls.Remove(TypeGame);
            }

            if (PlayRules != null)
            {
                main_window.Controls.Remove(PlayRules);
            }
        }

        private void Customers ()
        {
            StreamReader fail = new StreamReader("User.txt");
            string principle = File.ReadAllText("User.txt");
            fail.Close();
            subscriber.Text = principle;
        }

        private void Guess_Load(object sender, EventArgs e)
        {

        }

        private void ManGuessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();

            MakeNumber = " Я загадал число от 1 до 100";    

            TypeGame = new GameType(MakeNumber, 1);
            main_window.Controls.Add(TypeGame);
            if (TypeGame != null)
            {
                TypeGame.Width = main_window.Width;
                TypeGame.Height = main_window.Height;
                TypeGame.ChangeSize();
             //   TypeGame.PeopleGuesses();
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
            Form form = new Login();
            form.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
            Application.Exit();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Main_window_SizeChanged(object sender, EventArgs e)
        {
            if (TypeGame != null)
            {
                TypeGame.Width = main_window.Width;
                TypeGame.Height = main_window.Height;
            }

            if (PlayRules != null)
            {
                PlayRules.Width = main_window.Width;
                PlayRules.Height = main_window.Height;
            }
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComputerGuessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();

            MakeNumber = "Загадайте число от 1 до 100";  

            TypeGame = new GameType(MakeNumber, 2);
            main_window.Controls.Add(TypeGame);
            if (TypeGame != null)
            {
                TypeGame.Width = main_window.Width;
                TypeGame.Height = main_window.Height;
                TypeGame.ChangeSize();
                //TypeGame.AndroidGuesses();
            }
        }

        private void RuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
             // удаляем формун
             DeleteItems();

             StreamReader fail = new StreamReader("Regulation.txt");
             string principle = File.ReadAllText("Regulation.txt");   
             fail.Close();

             //открываем форму
             PlayRules = new GuessesMan(principle);
             main_window.Controls.Add(PlayRules);
             if (PlayRules != null)
             {
                 PlayRules.Width = main_window.Width;
                 PlayRules.Height = main_window.Height;
                 PlayRules.SizeChange();
             }
        }

        private void CreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();

            StreamReader fail = new StreamReader("Maker.txt");
            string creator = File.ReadAllText("Maker.txt");
            fail.Close();

            PlayRules = new GuessesMan(creator);
            main_window.Controls.Add(PlayRules);
            if (PlayRules != null)
            {
                PlayRules.Width = main_window.Width;
                PlayRules.Height = main_window.Height;
                PlayRules.SizeChange();
            }
        }

        private void Main_window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TheInitialWindow_Resize(object sender, EventArgs e)
        {
            TypeGame.ChangeSize();
            PlayRules.SizeChange();
        }

        private void ChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
            Customers();
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
            Customers();
        }

        private void BeginСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void TopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void Subscriber_Click(object sender, EventArgs e)
        {
            subscriber.Font = new Font("Times New Roman", (int)(Height * 0.05));

            subscriber.Height = main_window.Height;
            subscriber.Width = main_window.Width;
        }
    }
}     