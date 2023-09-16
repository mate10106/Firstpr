using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_confirmO_Click(object sender, EventArgs e)
        {
            int amount = 0;

            amount = Convert.ToInt32(Papperoni.Checked) * 2 + Convert.ToInt32(Extra_Cheese.Checked) * 2 + Convert.ToInt32(Mushroom.Checked) * 2
                   + Convert.ToInt32(Ham.Checked) * 2 + Convert.ToInt32(Bacon.Checked) * 2 + Convert.ToInt32(Jalapeno.Checked) * 2
                   + Convert.ToInt32(Pineapple.Checked) * 2 + Convert.ToInt32(Spanich.Checked) * 2 + Convert.ToInt32(Chicken.Checked) * 2
                   + Convert.ToInt32(Shrimps.Checked) * 2 + Convert.ToInt32(Tomatoes.Checked) * 2 + Convert.ToInt32(Beef.Checked) * 2;

            lista.Text = amount.ToString();



            myButton_pay.Enabled = true;
        }
    }
}
