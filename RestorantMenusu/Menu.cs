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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void addCart(String foodName,double price)
        {
            int count = 0;
            count++;
            price = price * count;
            var payment = new PaymentInfo();
            payment.itemLabel.Text = foodName;
            payment.priceLabel.Text = price.ToString();
            payment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCart("Burger Steak", 39.99); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCart("Chickenjoy w/ Spaghetti", 49.99);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addCart("Super Meal", 59.99);
        }
    }
}
