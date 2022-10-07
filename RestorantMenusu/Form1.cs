using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantMenusu
{
    public partial class Form1 : Form
    {
        void UseCustomFont(string name, int size, Label label)
        {

            PrivateFontCollection modernFont = new PrivateFontCollection();

            modernFont.AddFontFile(name);

            label.Font = new Font(modernFont.Families[0], size);


        }
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btn_Home.Height;
            firstCustomerControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            firstCustomerControl1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a midterm project created by Nasuhan Yunus Özkaya, student number is 202523011; for ISTE Computer Engineering 2nd Year Class; Visual Programming.");
        }

        private void btn_TakeAway_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_TakeAway.Height;
            SidePanel.Top = btn_TakeAway.Top;
            takeAway1.BringToFront();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Menu.Height;
            SidePanel.Top = btn_Menu.Top;
            menu1.BringToFront();
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Delivery.Height;
            SidePanel.Top = btn_Delivery.Top;
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Contact.Height;
            SidePanel.Top = btn_Contact.Top;
            firstCustomerControl1.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/JollibeePhilippines");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Jollibee");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        System.Diagnostics.Process.Start("https://www.instagram.com/jollibee/?hl=en");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure about quitting the Jollibee Desktop App?", "Always Nice to see You 😊", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Please come again 😊");
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                firstCustomerControl1.BringToFront();
            }
        }

        private void takeAway1_Load(object sender, EventArgs e)
        {

        }
    }
}
