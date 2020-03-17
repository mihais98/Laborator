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

namespace Ex2
{
    public partial class Form1 : Form
    {
        string[] lines;
        public Form1()
        {
            InitializeComponent();

            
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

          
            listBox1.DataSource = lines;

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    
                    listBox2.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }
    }
}
