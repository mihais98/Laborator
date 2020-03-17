using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                double number1 = Int32.Parse(textBox1.Text);
                double number2 = Int32.Parse(textBox2.Text);
                double result = 0;

                Object selectedItem = toolStripComboBox1.SelectedItem;

                if(selectedItem.ToString()=="+")
                {
                    result = number1 + number2;
                }
                if (selectedItem.ToString() == "-")
                {
                    result = number1 - number2;
                }
                if (selectedItem.ToString() == "*")
                {
                    result = number1 * number2;
                }
                if (selectedItem.ToString() == "/")
                {
                    result = number1 / number2;
                }

                textBox3.Text = result.ToString();

            }
        }
    }
}
