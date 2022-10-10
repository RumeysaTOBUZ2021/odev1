using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_ortalama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final;
            try
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                if (vize < 0 || vize > 100)
                {
                    MessageBox.Show("Vize notu 0-100 arası olmalı");
                }
                if (final < 0 || final > 100)
                {
                    MessageBox.Show("Final notu 0-100 arası olmalı");
                }
                ortalama = vize * 0.4 + final * 0.6;
                label6.Text = ortalama.ToString();
                if(ortalama>=90 && ortalama <=100)
                {
                     label7.Text="GEÇTİNİZ";
                     label7.ForeColor=Color.Green;
                     label8.Text="AA";
                }
                if(ortalama>=80 && ortalama <=89)
                {
                     label7.Text="GEÇTİNİZ";
                     label7.ForeColor=Color.Green;
                     label8.Text="BA";
                }
                if(ortalama>=70 && ortalama<=79)
                {
                     label7.Text="GEÇTİNİZ";
                     label7.ForeColor=Color.Green;
                     label8.Text="BB";
                }
                if(ortalama>=60 && ortalama <=69)
                {
                     label7.Text="GEÇTİNİZ";
                     label7.ForeColor=Color.Green;
                     label8.Text="CB";
                }
                if(ortalama>=51 && ortalama <=59)
                {
                     label7.Text="GEÇTİNİZ";
                     label7.ForeColor=Color.Green;
                     label8.Text="CC";
                }
                if(ortalama>=48 && ortalama<=50)
                {
                     label7.Text="KALDINIZ";
                     label7.ForeColor=Color.Red;
                     label8.Text="DC";
                }
                if(ortalama>=40 && ortalama <=47)
                {    
                     label7.Text="KALDINIZ";
                     label7.ForeColor=Color.Red;
                     label8.Text="DD";
                }
                if(ortalama>=30 && ortalama <=39)
                {
                     label7.Text="KALDINIZ";
                     label7.ForeColor=Color.Red;
                     label8.Text="FD";
                }
                if(ortalama>=0 && ortalama<=29)
                {
                     label7.Text="KALDINIZ";
                     label7.ForeColor=Color.Red;
                     label8.Text="FF";
                }
                label6.Text = ortalama.ToString();

            }
            catch (Exception )
            {

            }
        }
    }
}
