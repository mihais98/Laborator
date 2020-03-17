using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


           
       

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Image image = Image.FromFile("1.jpg");
                        pictureBox1.Image = image;
                        break;
                    }
                case 1:
                    {
                        Image image = Image.FromFile("2.jpg");
                        pictureBox1.Image = image;
                        break;
                    }
                case 2:
                    {
                        Image image = Image.FromFile("3.jpg");
                        pictureBox1.Image = image;
                        break;
                    }
                case 3:
                    {
                        Image image = Image.FromFile("4.jpg");
                        pictureBox1.Image = image;
                        break;
                    }


                default: break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textOne = null;
            String textTwo = null;
           

            List<CheckBox> CheckLeft = new List<CheckBox>();
            List<CheckBox> CheckRight = new List<CheckBox>();

            CheckLeft.Add(checkBox1);
            CheckLeft.Add(checkBox2);
            CheckLeft.Add(checkBox3);
            CheckLeft.Add(checkBox4);

            CheckRight.Add(checkBox5);
            CheckRight.Add(checkBox6);
            CheckRight.Add(checkBox7);
            CheckRight.Add(checkBox8);



            foreach (CheckBox element in CheckLeft)
            {
                if(element.Checked==true)
                {
                    textOne = element.Text;
                }
            }
            foreach (CheckBox element in CheckRight)
            {
                if (element.Checked == true)
                {
                    textTwo = element.Text;
                }
            }

            MessageBox.Show(textOne + " " + textTwo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
