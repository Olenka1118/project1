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

namespace Guess
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //string s = "fdgGdfg";

           // s = s.ToUpper();

           // MessageBox.Show(s2);
        }

        private void CheckingLineFile()
        {
            if (User.Text != "" && User.Text != " ")
            {
                if (File.Exists("User.txt"))
                {
                    StreamReader fail = new StreamReader("User.txt");
                    string s = File.ReadAllText("User.txt");
                    fail.Close();
                    string f = User.Text;
                    if (s.Contains(f))
                    {
                        //Слово содержится в тексте, удаляем вводимые симвалы логина
                        User.Text = "";
                        fail.Close();
                    }
                    else
                    {
                        // Слова нет в тексте, добавляем его в файл
                        var text = User.Text;
                        using (var writer = new StreamWriter("User.txt", true))
                        {
                            //Добавляем к старому содержимому файла
                            writer.WriteLine(text);
                            fail.Close();
                        }
                    }
                }
                else
                {
                    StreamWriter fail = new StreamWriter("User.txt");
                    var text = User.Text;
                    using (var writer = new StreamWriter("User.txt", true))
                    {
                        //Добавляем к старому содержимому файла
                        writer.WriteLine(text);
                        fail.Close();
                    }
                }
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {                 
            CheckingLineFile();
            this.Close();
        }

        private void Name1_Click(object sender, EventArgs e)
        {

        }
    }
}
