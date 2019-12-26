using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt";
            char[] separators = { ' ', '.', '?', '!' };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                textBox1.Text = File.ReadAllText(ofd.FileName);
                string[] StrArr = textBox1.Text.Split(separators);
                foreach (string strTemp in StrArr)
                {
                    string s = strTemp.Trim();
                    if (!list.Contains(s.ToUpper())) list.Add(s);
                }
                t.Stop();
                this.textBox2.Text = t.Elapsed.ToString();
            }
        }

        private void WordSearch_Click(object sender, EventArgs e)
        {
            string word = this.textBox3.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.textBox4.Text = t.Elapsed.ToString();
                this.listBox1.BeginUpdate();
                this.listBox1.Items.Clear();

                foreach (string str in tempList)
                {
                    this.listBox1.Items.Add(str);
                }
                this.listBox1.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
    }
}
