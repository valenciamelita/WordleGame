using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_7_takehome
{
    public partial class Form1 : Form
    {
        public int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                button_play_Click(sender, e);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textbox_input.Text))
            {
                MessageBox.Show("Please fill with number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_input.Focus();
                return;
            }
            else
            {
                a = (Convert.ToInt32(textbox_input.Text));


                if (a <= 3)
                {
                    MessageBox.Show("The input must be more than 3!");
                    textbox_input.Clear();
                    textbox_input.Focus();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.size = a;
                    form2.ShowDialog();
                    textbox_input.Clear();
                }
            }

        }
    }
}
