using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BitcoinMiner.Properties;
//m
namespace BitcoinMiner
{
    public partial class Form1 : Form
    {
        Double a;
        public Form1()
        {
            InitializeComponent();
            label6.Text = Properties.Settings.Default.amt;
            a = Convert.ToDouble(label6.Text);

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            panel6_Click(sender, e);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel6_Click(sender, e);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(15, 45, 58);
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(17, 52, 68);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (label7.Text == "Start Mining")
            {

                timer3.Start();
                label7.Text = "Stop Mining";
                
                if(withdraw.Visible==true)
                    pictureBox8.Visible = false;
                else
                    pictureBox8.Visible = true;


                pictureBox8.Enabled = true;
            }
            else
            {
                timer3.Stop();
                label7.Text = "Start Mining";
                pictureBox8.Visible = false;
                pictureBox8.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
                a = a + 0.0000001;
                label6.Text = string.Format("{0:0.0000000}", a); //string.Format("{0:000000}",)
                label6.Update();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            panel6_MouseEnter(sender,e);
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            panel6_MouseEnter(sender, e);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel6_MouseLeave(sender, e);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            panel6_MouseLeave(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            Properties.Settings.Default.amt = label6.Text.ToString();
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(15, 42, 56);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(15, 42, 56);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(15, 42, 56);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(15, 36, 46);
            panel4.BackColor = Color.FromArgb(15, 36, 46);
            panel5.BackColor = Color.FromArgb(15, 36, 46);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(label6.Text.ToString())>=1.0000000 && textBox1.Text!="")
            {
                MessageBox.Show("Visit Telegram at https://t.me/coreston", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Windows.Forms.Clipboard.SetDataObject("https://t.me/coreston");
                System.Diagnostics.Process.Start("https://t.me/coreston");

            }
            else
            {
                MessageBox.Show("Minimum withdrawal amount is 1 BTC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if(label7.Text=="Start Mining")
            {
                pictureBox8.Visible = false;
            }
            else
            {
                pictureBox8.Visible = true;
            }

            withdraw.Visible = false;
            withdraw.Enabled = false;
            panel6.Enabled = true;
            panel6.Visible = true;
            info.Visible = false;
            info.Enabled = false;
            info.Width =0;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = false;
            withdraw.Visible = true;
            withdraw.Enabled = true;
            info.Visible = false;
            info.Enabled = false;
            info.Width = 0;
            textBox1.Text="";
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = false;
            withdraw.Visible = false;
            withdraw.Enabled = false;
            info.Visible = true;
            info.Enabled = true;
            info.Width = 970;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer3.Stop();
            Properties.Settings.Default.amt = label6.Text.ToString();
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }
    }
}
