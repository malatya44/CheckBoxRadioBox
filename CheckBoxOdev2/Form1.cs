using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //şehirler
            // deneme Ertuğrul
            foreach (Control rb in groupBox2.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    label1.Text = "Seçiminiz : " + rb.Text;
                }
            }

            //öğrenim durumu
            foreach (Control rb in groupBox4.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    label2.Text = "Seçiminiz : " + rb.Text;
                }
            }
            //Cinsiyet
            foreach (Control rb in groupBox3.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    label3.Text = "Seçiminiz : " + rb.Text;
                }
            }

            //Diller
            foreach (Control cb in groupBox1.Controls)
            {
                
                if (((CheckBox)cb).Checked)
                {
                    listBox1.Items.Add(cb.Text);
                }
            }
        }
    }
}
