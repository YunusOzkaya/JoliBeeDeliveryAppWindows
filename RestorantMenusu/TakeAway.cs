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
    public partial class TakeAway : UserControl
    {
        public TakeAway()
        {
            InitializeComponent();
        }

        private void takeAwayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (takeAwayList.SelectedItem.Equals("Chickenjoy Family Saver"))
            {
                var payment = new PaymentInfo();
                payment.itemLabel.Text = "Chickenjoy Family Saver";
                payment.priceLabel.Text = "119.99 TL";
                payment.Show();
            }
            else if (takeAwayList.SelectedItem.Equals("Chickenjoy Family Box"))
            {
                var payment = new PaymentInfo();
                payment.itemLabel.Text = "Chickenjoy Family Box";
                payment.priceLabel.Text = "129.99 TL";
                payment.Show();
            }
            else if (takeAwayList.SelectedItem.Equals("Chickenjoy Family Saver"))
            {
                var payment = new PaymentInfo();
                payment.itemLabel.Text = "Family Super Meal";
                payment.priceLabel.Text = "169.99 TL";
                payment.Show();
            }

        }

        private void takeAwayList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
