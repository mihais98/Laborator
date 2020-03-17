using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(@"file.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            lines = list.ToArray();

            if(lines[0]=="mihai")

            {
                if (lines[1] == "123456789")
                {
                    Form2 fr = new Form2(lines[0]);
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Log in error");
                }
            }
            else
            {
                MessageBox.Show("Log in error");
            }
        }
    }
}
