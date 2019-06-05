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
    public partial class GuessesMan : UserControl
    {
        public GuessesMan(string s)
        {
            InitializeComponent();
            reference.Text = s;
        }

        public GuessesMan()
        {
            InitializeComponent();
        }

        private void GuessesMan_Load(object sender, EventArgs e)
        {
            SizeChange();
        }

        public void SizeChange()
        {
            reference.Font = new Font("Times New Roman", (int)(Height * 0.033));

            reference.Height = (int)(Height * 0.9);
            reference.Width = (int)(Width * 1.2);

            reference.Top = (int)(Height / 2.05 - reference.Height / 2);
            reference.Left = (int)(Width / 2 - reference.Width / 2);
        }

        private void reference_Click(object sender, EventArgs e)
        {

        }
    }
}
