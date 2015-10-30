using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace WindowsFormGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tb_user.Text))
            {
                Game game = new Game();
                game.answer = game.CreateNumbers();
                List<int> userAnswer = game.ConvertStringToNumbers(this.tb_user.Text);
                this.label_npc.Text = game.ConvertNumbersToString(game.answer);
                game.GetResult(userAnswer);
                this.label_ans.Text = game.show_ans;
            }
            else
            {
                MessageBox.Show("Please Enter Number first!");
                this.tb_user.Focus();
            }


        }


        private void tb_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}
