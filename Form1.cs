using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FrmPizzaOrder : Form
    {
        public FrmPizzaOrder()
        {
            InitializeComponent();
            
            
            

        }
        private void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbLargeSize.Checked)
            {
                tbSize.Text = rbLargeSize.Text;
                return;
            }
            else if (rbMediumSize.Checked)
            {
                tbSize.Text = rbMediumSize.Text;
                return;
            }
            else if(rbSmallSize.Checked)
            {
                
                tbSize.Text = rbSmallSize.Text;
                return;
            }
            


        }
        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
           
            UpdateSize();
        }
        private void rbLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }

        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }
        private void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThickCrust.Checked)
            { tbCrust.Text = rbThickCrust.Text;
                return;
            }
            else if(rbThinCrust.Checked )
            {
               
                tbCrust.Text = rbThinCrust.Text;
                return;
            }
        }
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();


        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();


        }
        private void OrderPizzabtEnabled(object sender, EventArgs e)
        {
            btOrderPizza.Enabled = ((rbLargeSize.Checked || rbMediumSize.Checked || rbSmallSize.Checked)
               && (rbThickCrust.Checked || rbThinCrust.Checked)
               && (rbDineIn.Checked || rbTakeOut.Checked));
                
        }
        private float SelectedSizePrice()
        {
            if (rbLargeSize.Checked)
                return Convert.ToSingle(rbLargeSize.Tag);
            else if (rbMediumSize.Checked)
                return Convert.ToSingle (rbMediumSize.Tag);
            else
                return Convert.ToSingle(rbSmallSize.Tag);
        }
        private float SelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);
            
            else
                return Convert.ToSingle(rbThinCrust.Tag);
        }
        private float ToppingsPrice()
        {
            float price = 0;
            
            if (chbExtraChees.Checked)
                price += Convert.ToSingle(chbExtraChees.Tag);
            if (chbMushroom.Checked)
                price += Convert.ToSingle(chbMushroom.Tag);
            if (chbOlives.Checked)
                price += Convert.ToSingle(chbOlives.Tag);
            if (chbOnions.Checked)
                price += Convert.ToSingle(chbOnions.Tag);
            if (chbPeppers.Checked)
                price += Convert.ToSingle(chbPeppers.Tag);
            if (chbTomato.Checked)
                price += Convert.ToSingle(chbTomato.Tag);
            return price;
        }
        private float CalculateTotalPrice()
        {
           return SelectedSizePrice() + SelectedCrustPrice() + ToppingsPrice();

        }
        private void UpdateTotalPrice()
        {
            lblPrice.Text="$" +CalculateTotalPrice().ToString();
        }
        private void UpdateToppings()
        {
            tbToppings.Text = "";
            if (chbExtraChees.Checked)
                tbToppings.Text += chbExtraChees.Text+",";
            if (chbMushroom.Checked)
                tbToppings.Text += chbMushroom.Text + ",";
            if (chbOlives.Checked)
                tbToppings.Text += chbOlives.Text + ",";
            if (chbOnions.Checked)
                tbToppings.Text += chbOnions.Text + ",";
            if (chbPeppers.Checked)
                tbToppings.Text += chbPeppers.Text + ",";
            if (chbTomato.Checked)
                tbToppings.Text += chbTomato.Text + ",";
            tbToppings.Text.TrimEnd(',');
        }

        private void UpdateWhereToEat()
        {
            if (rbDineIn.Checked)
            {
                tbWhereToEat.Text = rbDineIn.Text;
                return;
            }
            else if (rbTakeOut.Checked)
            {
                
                tbWhereToEat.Text = rbTakeOut.Text;
                return;
            }

        }

        private void rbDineIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed");
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbToppings.Enabled = false;
              
            }
         
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            rbLargeSize.Checked = false;
            rbMediumSize.Checked = false;
            rbSmallSize.Checked = false;
            rbThickCrust.Checked = false;
            rbThinCrust.Checked = false;
            rbDineIn.Checked = false;
            rbTakeOut.Checked = false;
            chbExtraChees.Checked = false;
            chbMushroom.Checked = false;
            chbOlives.Checked = false;
            chbOnions.Checked = false;
            chbPeppers.Checked = false;
            chbTomato.Checked = false;
            tbSize.Text = "";
            tbCrust.Text = "";
            tbToppings.Text = "";
            tbWhereToEat.Text = "";
            lblPrice.Text = "$0";
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chbOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chbPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chbTomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }
        

        //private void FrmPizzaOrder_Load(object sender, EventArgs e)
        //{
            
        //    UpdateSize();
        //    UpdateCrust();
        //    UpdateWhereToEat();
        //    UpdateToppings();
        //    UpdateTotalPrice();
        //}
    }
}
