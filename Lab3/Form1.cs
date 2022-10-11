using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form

    {
        public Form1()

        {
            InitializeComponent();
        }
        int price;
        int Totalprice;
        int p1, p2, p3, p4, p5, p6;
        int Total_products;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;

            }
            else
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;

            }
            else
            {
                numericUpDown2.Enabled = false;
                comboBox2.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;

            }
            else
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox4.Checked == true)
            {
                numericUpDown4.Enabled = true;
                comboBox6.Enabled = true;

            }
            else
            {
                numericUpDown4.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            

        }

        private void label39_Click(object sender, EventArgs e)
        {
           
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox5.Checked == true)
            {
                numericUpDown5.Enabled = true;
                comboBox4.Enabled = true;

            }
            else
            {
                numericUpDown5.Enabled = false;
                comboBox4.Enabled = false;
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checKbox = new CheckBox();
            if (checkBox5.Checked == true)
            {
                numericUpDown6.Enabled = true;
                comboBox5.Enabled = true;

            }
            else
            {
                numericUpDown6.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

            {
                label15.Text = " Apple";
                if (comboBox1.Text.ToString() == "200")
                {
                    price = 200;

                    label24.Text = numericUpDown1.Value.ToString();
                    p1 = (int)(numericUpDown1.Value * price);
                    label31.Text = p1.ToString();
                }
                else
                {
                    price = 150;
                    label24.Text = numericUpDown1.Value.ToString();
                    p1 = (int)(numericUpDown1.Value * price);
                    label31.Text = p1.ToString();
                }
                Total_products++;
                label40.Text = Total_products.ToString();



            }

            if (checkBox2.Checked == true)

            {
                label16.Text = " Orange";
                if (comboBox2.Text.ToString() == "300")
                {
                    price = 300;

                    label25.Text = numericUpDown2.Value.ToString();
                    p2 = (int)(numericUpDown2.Value * price);
                    label32.Text = p2.ToString();
                }
                else
                {
                    price = 200;
                    label25.Text = numericUpDown2.Value.ToString();
                    p2 = (int)(numericUpDown2.Value * price);
                    label32.Text = p2.ToString();
                }
                Total_products++;
                label40.Text = Total_products.ToString();
            }
            if (checkBox3.Checked == true)

            {
                label19.Text = " Mango";
                if (comboBox3.Text.ToString() == "150")
                {
                    price = 120;

                    label26.Text = numericUpDown3.Value.ToString();
                    p3 = (int)(numericUpDown3.Value * price);
                    label33.Text =p3.ToString();
                }
                else
                {
                    price = 120;
                    label26.Text = numericUpDown3.Value.ToString();
                    p3 = (int)(numericUpDown3.Value * price);
                    label33.Text = p3.ToString();
                }
                Total_products++;
                label40.Text = Total_products.ToString();

            }
            if (checkBox4.Checked == true)

            {
                label19.Text = " Peach";
                if (comboBox6.Text.ToString() == "250")
                {
                    price = 200;

                    label27.Text = numericUpDown4.Value.ToString();
                    p4 = (int)(numericUpDown4.Value * price);
                    label34.Text = p4.ToString();
                }
                else
                {
                    price = 200;
                    label27.Text = numericUpDown4.Value.ToString();
                    p4 = (int)(numericUpDown4.Value * price);
                    label34.Text =p4.ToString();
                }
                Total_products++;
                label40.Text = Total_products.ToString();
            }
            if (checkBox5.Checked == true)

            {
                label21.Text = " PineApple";
                if (comboBox4.Text.ToString() == "1000")
                {
                    price = 800;

                    label28.Text = numericUpDown5.Value.ToString();
                    p5= (int)(numericUpDown5.Value * price);
                    label35.Text = p5.ToString();
                }
                else
                {
                    price = 800;
                    label28.Text = numericUpDown5.Value.ToString();
                    p5 = (int)(numericUpDown5.Value * price);
                    label35.Text = p5.ToString();
                }
                Total_products++;
                label40.Text = Total_products.ToString();
            }
            if (checkBox6.Checked == true)

            {
                label17.Text = " Strawberry";
                if (comboBox5.Text.ToString() == "90")
                {
                    price = 90;

                    label29.Text = numericUpDown6.Value.ToString();
                    p6= (int)(numericUpDown6.Value * price);
                    label36.Text = p6.ToString();
                }
                else
                {
                    price = 60;
                    label29.Text = numericUpDown6.Value.ToString();
                    p6 = (int)(numericUpDown6.Value * price);
                    label36.Text = p6.ToString();
                }

                Total_products++;
                label40.Text = Total_products.ToString();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {if (radioButton1.Checked == true)
            {
                DateTime now = DateTime.Now;
                label37.Text = (now.ToString());

                Totalprice = (p1 + p2 + p3 + p4 + p5 + p5 + p6+20);
                label38.Text = Totalprice.ToString();
            }
        else
            {
                DateTime now = DateTime.Now;
                label37.Text = (now.ToString());

                Totalprice = (p1 + p2 + p3 + p4 + p5 + p5 + p6);
                label38.Text = Totalprice.ToString();

            }
        }
    }
}
