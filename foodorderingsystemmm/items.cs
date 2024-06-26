namespace foodorderingsystemmm
{
    public partial class frm_items : Form
    {
        const double Price_burger = 130;
        const double price_pizza = 280;
        const double price_sandwich = 180;
        const double price_fingerfries = 50;
        const double price_biryani = 200;
        const double price_sprite = 80;
        const double price_cocacola = 80;
        const double price_fanta = 80;
        const double price_7up = 80;
        const double price_pepsi = 80;

        public frm_items()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("confirm you want to exit this system",
                "ordering system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add("cash");
            cmb_payment.Items.Add(" cash on Delivery");

        }
        private void EnableTextBoxes()
        {
            void func(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        ((TextBox)control).Enabled = false;
                    else
                        func(control.Controls);
                }
            }
            func(this.Controls);
        }

        private void chk_burger_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger.Checked)
            {
                txt_burger.Enabled = true;
                txt_burger.Text = "1";
                txt_burger.Focus();
            }
            else
            {
                txt_burger.Enabled = false;
                txt_burger.Text = "0";
            }
        }

        private void chk_pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza.Checked)
            {
                txt_pizza.Enabled = true;
                txt_pizza.Text = "1";
                txt_pizza.Focus();
            }
            else
            {
                txt_pizza.Enabled = false;
                txt_pizza.Text = "0";
            }
        }

        private void chk_sandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sandwich.Checked)
            {
                txt_sandwich.Enabled = true;
                txt_sandwich.Text = "1";
                txt_sandwich.Focus();
            }
            else
            {
                txt_sandwich.Enabled = false;
                txt_sandwich.Text = "1";
            }
        }

        private void chk_fingerfries_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fingerfries.Checked)
            {
                txt_fingerfries.Enabled = true;
                txt_fingerfries.Text = "1";
                txt_fingerfries.Focus();
            }
            else
            {
                txt_fingerfries.Enabled = false;
                txt_fingerfries.Text = "0";
            }
        }

        private void chk_biryani_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_biryani.Checked)
            {
                txt_biryani.Enabled = true;
                txt_biryani.Text = "1";
                txt_biryani.Focus();
            }
            else
            {
                txt_biryani.Enabled = false;
                txt_biryani.Text = "0";
            }
        }

        private void chk_sprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sprite.Checked)
            {
                txt_sprite.Enabled = true;
                txt_sprite.Text = "1";
                txt_sprite.Focus();
            }
            else
            {
                txt_sprite.Enabled = false;
                txt_sprite.Text = "0";
            }
        }

        private void chk_cocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cocacola.Checked)
            {
                txt_cocacola.Enabled = true;
                txt_cocacola.Text = "1";
                txt_cocacola.Focus();
            }
            else
            {
                txt_cocacola.Enabled = false;
                txt_cocacola.Text = "0";
            }
        }

        private void chk_fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fanta.Checked)
            {
                txt_fanta.Enabled = true;
                txt_fanta.Text = "1";
                txt_fanta.Focus();
            }
            else
            {
                txt_fanta.Enabled = false;
                txt_fanta.Text = "0";
            }
        }

        private void chk_7up_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_7up.Checked)
            {
                txt_7up.Enabled = true;
                txt_7up.Text = "1";
                txt_7up.Focus();
            }
            else
            {
                txt_7up.Enabled = false;
                txt_7up.Text = "0";
            }
        }

        private void chk_pepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pepsi.Checked)
            {
                txt_pepsi.Enabled = true;
                txt_pepsi.Text = "1";
                txt_pepsi.Focus();
            }
            else
            {
                txt_pepsi.Enabled = false;
                txt_pepsi.Text = "0";
            }
        }

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == " cash")
            {
                txt_payment.Enabled = true;
                txt_payment.Text = "  ";
                txt_payment.Focus();
            }
            else if (cmb_payment.Text == " cash on Delivery")
            {
                txt_name.Enabled = true;
                txt_address.Enabled = true;
                txt_contactnumber.Enabled = true;
                txt_name.Text = "";
                txt_address.Text = "";
                txt_contactnumber.Text = "";
                txt_name.Focus();
                txt_address.Focus();
                txt_contactnumber.Focus();
            }
            else
            {
                txt_payment.Enabled = false;
                txt_payment.Text = "0";
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double[] itemcoast = new double[100];
            itemcoast[0] = Convert.ToDouble(txt_burger.Text) * Price_burger;
            itemcoast[1] = Convert.ToDouble(txt_pizza.Text) * price_pizza;
            itemcoast[2] = Convert.ToDouble(txt_sandwich.Text) * price_sandwich;
            itemcoast[3] = Convert.ToDouble(txt_fingerfries.Text) * price_fingerfries;
            itemcoast[4] = Convert.ToDouble(txt_biryani.Text) * price_biryani;
            itemcoast[5] = Convert.ToDouble(txt_sprite.Text) * price_sprite;
            itemcoast[6] = Convert.ToDouble(txt_cocacola.Text) * price_cocacola;
            itemcoast[7] = Convert.ToDouble(txt_fanta.Text) * price_fanta;
            itemcoast[8] = Convert.ToDouble(txt_7up.Text) * price_7up;
            itemcoast[9] = Convert.ToDouble(txt_pepsi.Text) * price_pepsi;


            double total, payment, coast;
            if (cmb_payment.Text == " cash")
            {
                total = itemcoast[0] + itemcoast[1] + itemcoast[2] + itemcoast[3] + itemcoast[4] + itemcoast[5] + itemcoast[6] + itemcoast[7] + itemcoast[8] + itemcoast[9];

                lbl_totalresult.Text = Convert.ToString(total);
                payment = Convert.ToInt32(txt_payment.Text);
                coast = payment - total;
                lbl_changeresult.Text = Convert.ToString(coast);

            }
            else
            {
                total = itemcoast[0] + itemcoast[1] + itemcoast[2] + itemcoast[3] + itemcoast[4] + itemcoast[5] + itemcoast[6] + itemcoast[7] + itemcoast[8] + itemcoast[9];

                lbl_totalresult.Text = Convert.ToString(total);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBox();
            lbl_totalresult.Text = "0";
            lbl_changeresult.Text = "0";
        }
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = " 0";
            };
            func(Controls);
        }
        private void ResetCheckBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = " 0";
            };
            func(Controls);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Thank you for choosing our Resturant" + txt_name + " we will Deliver your Order at " + txt_address + " we will just inform you at " + txt_contactnumber);
        }

        private void btn_total_Click_1(object sender, EventArgs e)
        {

        }
    }



}
