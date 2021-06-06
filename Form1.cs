using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAPAYZEKAPROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Seçiniz");
            comboBox1.Items.Add("Evet");
            comboBox1.Items.Add("Hayır");
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Items.Add("Seçiniz");
            comboBox2.Items.Add("Evet");
            comboBox2.Items.Add("Hayır");
            comboBox2.Text = comboBox1.Items[0].ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int girilen = Convert.ToInt16(textBox1.Text);
                if (comboBox1.SelectedItem == "Evet")
                {

                    label4.Text = ("Alışveriş yapmayı seviyorsunuz");
                    label4.Visible = true;
                
                }

                if (comboBox1.SelectedItem == "Hayır" && girilen <= 1)
                {
                    label4.Text = ("Alışveriş yapmayı sevmiyorsunuz");
                    label4.Visible = true;
                  
                }
                if (comboBox1.SelectedItem == "Hayır" && girilen > 1 && comboBox2.SelectedItem == "Hayır")
                {
                    label4.Text = ("Alışveriş yapmayı seviyorsunuz");
                    label4.Visible = true;
                 
                }
                if (comboBox1.SelectedItem == "Hayır" && girilen > 1 && comboBox2.SelectedItem == "Evet")
                {
                    label4.Text = ("Alışveriş yapmayı sevmiyorsunuz");
                    label4.Visible = true;
                    
                }
           
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        comboBox1.Text = "Seçiniz";
            textBox1.Clear();
            comboBox2.Text = "Seçiniz";
            label4.Text = " ";
            label5.Text = " ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

    }
        

        }
    

