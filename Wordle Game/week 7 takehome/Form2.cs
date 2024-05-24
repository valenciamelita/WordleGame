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

namespace week_7_takehome
{
    public partial class Form2 : Form
    {
        public int size;
        public bool menang = false;
        List<Button> buttons = new List<Button>();
        List<string> wordList = new List<string>();
        string tebak = "";
        Random rnd = new Random();
        string path = @"Wordle Word List.txt";
        int baris = 0;
        int kolom = -1;
        string katabenar = "";
        int hurufbenar = 0;
        int kali = 0;
        Dictionary<char, Button> keyboardButtons = new Dictionary<char, Button>();

        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Focus();
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();

            string[] words = content.Split(',');
            wordList = words.ToList();

            katabenar = wordList[rnd.Next(wordList.Count)];
            //MessageBox.Show(katabenar);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(50 * j + 50, 50 * i + 40);
                    button.Tag = i.ToString() + "," + j.ToString();
                    button.Font = new Font("Montserrat", 8);
                    buttons.Add(button);
                    Controls.Add(buttons[buttons.Count - 1]);
                    button.Click += new EventHandler(buttonkey_Click);
                    button.TabStop = false;
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                string buttonName = "button_" + c.ToString().ToLower();
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    keyboardButtons[c] = button;
                }
            }
        }


        private void buttonkey_Click(object sender, EventArgs e)
        {
            if (!menang)
            {
                Button btn = sender as Button;
                if (btn != null && tebak.Length < 5)
                {
                    string key = btn.Text;
                    tebak += key;
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        if (buttons[i].Text == "")
                        {
                            buttons[i].Text = key;
                            kolom = i % 5;
                            break;
                        }
                    }
                    label1.Focus();
                }
            }

        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (!menang)
            {
                if (tebak.Length < 5)
                {
                    MessageBox.Show("The word is too short.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (wordList.Contains(tebak.ToLower()))
                    {
                        cekkata();
                        kali++;
                        tebak = "";
                        menangkalah();
                        kolom++;
                        baris++;
                    }
                    else
                    {
                        MessageBox.Show(tebak + " is not in the word list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kolom = -1;

                    }

                }
            }
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            for (int j = 4; j >= 0; j--)
            {
                int index = baris * 5 + j;
                if (buttons[index].Text != "")
                {
                    tebak = tebak.Substring(0, tebak.Length-1);
                  buttons[index].Text = "";
                    kolom = j;
                    break;
                }
            }
        }

        private void cekkata()
        {
            hurufbenar = 0;
            for (int i = 0; i < 5; i++)
            {
                char letter = tebak.ToUpper()[i];
                if (katabenar[i] == tebak.ToLower()[i])
                {
                    buttons[baris * 5 + i].BackColor = Color.MediumSpringGreen;
                    keyboardButtons[letter].BackColor = Color.MediumSpringGreen;
                    hurufbenar++;
                }
                else if (katabenar.Contains(tebak.ToLower()[i]))
                {
                    buttons[baris * 5 + i].BackColor = Color.Moccasin;
                    keyboardButtons[letter].BackColor = Color.Moccasin;
                }
                else
                {
                    buttons[baris * 5 + i].BackColor = Color.White;
                    keyboardButtons[letter].BackColor = Color.Gray; 
                }
            }
            if (hurufbenar == 5)
            {
                menang = true;
            }
        }


        private void menangkalah()
        {
            if (menang)
            {
                MessageBox.Show("You win!");
                return;
            }

            if (kali == size)
            {
                DialogResult result = MessageBox.Show($"The word is: {katabenar.ToUpper()}. Try again?", "You Lose!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();

                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char keyPencet = e.KeyChar;

            if (char.IsLetter(keyPencet) && tebak.Length < 5)
            {
                tebak += keyPencet;
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].Text == "")
                    {
                        buttons[i].Text = keyPencet.ToString().ToUpper();
                        kolom = i % 5;
                        break;
                    }
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_enter_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back && tebak.Length > 0)
            {
                button_delete_Click(sender, e);
            }
        }

    }
}

