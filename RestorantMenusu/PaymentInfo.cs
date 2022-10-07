using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantMenusu
{
    public partial class PaymentInfo : Form
    {
        public PaymentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.TextLength == 3 && textBox1.TextLength == 4 && textBox2.TextLength == 4 && textBox3.TextLength == 4 && textBox4.TextLength == 4 && dateTimePicker1.Value > DateTime.Now)
            {
                if (textBox1.Text.All(char.IsDigit) && textBox2.Text.All(char.IsDigit) && textBox3.Text.All(char.IsDigit) && textBox4.Text.All(char.IsDigit) && textBox5.Text.All(char.IsDigit)) 
                { 
                    MessageBox.Show("Thank you for choosing us :)");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Please enter only numbers.");
                }
            }
            else
            {
                MessageBox.Show("The card You have entered is not valid.");
            }
            
        }
    }
}
