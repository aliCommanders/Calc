using System.IO;
using System;
using System.Windows.Forms;
using Calc;

namespace WinFormsApp6
{

    public partial class Form1 : Form
    {

        private static string str = "";
        public static string strnum = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {

          

            Calculator.Correction_Add(e.KeyChar, ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;

        }





        private void num1_MouseDown(object sender, MouseEventArgs e)
        {
            //KeyPressEventArgs k = new KeyPressEventArgs('1');
            //num_KeyPress(num1, k);
            Calculator.Correction_Add('1', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num2_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('2', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num3_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('3', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num0_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('0', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num4_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('4', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num5_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('5', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num6_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('6', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num7_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('7', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num8_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('8', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void num9_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('9', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signequal_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('=', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signdot_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('.', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signplus_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('+', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signminas_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('-', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signdiv_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('/', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signmulti_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add('*', ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signdelete_MouseDown(object sender, MouseEventArgs e)
        {
            Calculator.Correction_Add((char)8, ref str, ref strnum);
            toplabel.Text = str;
            num.Text = strnum;
        }

        private void signclear_MouseDown(object sender, MouseEventArgs e)
        {
            str = strnum = "";
            toplabel.Text = str;
            num.Text = strnum;

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

            if (num.Text.Length > 10)//public Font(string familyName, float emSize, GraphicsUnit unit);
            {
                num.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else
            {
                num.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {

        }


        private void signdiv_Click(object sender, EventArgs e)
        {

        }
    }
}
