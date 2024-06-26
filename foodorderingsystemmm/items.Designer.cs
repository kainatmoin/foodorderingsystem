namespace foodorderingsystemmm
{
    partial class frm_items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_biryani = new TextBox();
            txt_fingerfries = new TextBox();
            txt_sandwich = new TextBox();
            txt_pizza = new TextBox();
            txt_burger = new TextBox();
            chk_biryani = new CheckBox();
            chk_fingerfries = new CheckBox();
            chk_sandwich = new CheckBox();
            chk_pizza = new CheckBox();
            chk_burger = new CheckBox();
            lbl_quantity = new Label();
            groupBox2 = new GroupBox();
            txt_pepsi = new TextBox();
            txt_7up = new TextBox();
            txt_fanta = new TextBox();
            txt_cocacola = new TextBox();
            txt_sprite = new TextBox();
            chk_pepsi = new CheckBox();
            chk_7up = new CheckBox();
            chk_fanta = new CheckBox();
            chk_cocacola = new CheckBox();
            chk_sprite = new CheckBox();
            lbl_quanty = new Label();
            lbl_name = new Label();
            lbl_address = new Label();
            lbl_contactnumber = new Label();
            lbl_payment = new Label();
            lbl_total = new Label();
            lbl_totalresult = new Label();
            lbl_change = new Label();
            lbl_changeresult = new Label();
            btn_ok = new Button();
            btn_reset = new Button();
            btn_exit = new Button();
            btn_total = new Button();
            txt_name = new TextBox();
            txt_address = new TextBox();
            txt_contactnumber = new TextBox();
            txt_payment = new TextBox();
            cmb_payment = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_biryani);
            groupBox1.Controls.Add(txt_fingerfries);
            groupBox1.Controls.Add(txt_sandwich);
            groupBox1.Controls.Add(txt_pizza);
            groupBox1.Controls.Add(txt_burger);
            groupBox1.Controls.Add(chk_biryani);
            groupBox1.Controls.Add(chk_fingerfries);
            groupBox1.Controls.Add(chk_sandwich);
            groupBox1.Controls.Add(chk_pizza);
            groupBox1.Controls.Add(chk_burger);
            groupBox1.Controls.Add(lbl_quantity);
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food";
            // 
            // txt_biryani
            // 
            txt_biryani.Location = new Point(407, 236);
            txt_biryani.Name = "txt_biryani";
            txt_biryani.Size = new Size(38, 40);
            txt_biryani.TabIndex = 22;
            // 
            // txt_fingerfries
            // 
            txt_fingerfries.Location = new Point(407, 188);
            txt_fingerfries.Name = "txt_fingerfries";
            txt_fingerfries.Size = new Size(38, 40);
            txt_fingerfries.TabIndex = 21;
            // 
            // txt_sandwich
            // 
            txt_sandwich.Location = new Point(407, 136);
            txt_sandwich.Name = "txt_sandwich";
            txt_sandwich.Size = new Size(38, 40);
            txt_sandwich.TabIndex = 20;
            // 
            // txt_pizza
            // 
            txt_pizza.Location = new Point(407, 89);
            txt_pizza.Name = "txt_pizza";
            txt_pizza.Size = new Size(38, 40);
            txt_pizza.TabIndex = 19;
            // 
            // txt_burger
            // 
            txt_burger.Location = new Point(407, 44);
            txt_burger.Name = "txt_burger";
            txt_burger.Size = new Size(38, 40);
            txt_burger.TabIndex = 18;
            txt_burger.TextChanged += textBox5_TextChanged;
            // 
            // chk_biryani
            // 
            chk_biryani.AutoSize = true;
            chk_biryani.Font = new Font("Times New Roman", 14F);
            chk_biryani.Location = new Point(14, 238);
            chk_biryani.Name = "chk_biryani";
            chk_biryani.Size = new Size(119, 37);
            chk_biryani.TabIndex = 5;
            chk_biryani.Text = "biryani";
            chk_biryani.UseVisualStyleBackColor = true;
            chk_biryani.CheckedChanged += chk_biryani_CheckedChanged;
            // 
            // chk_fingerfries
            // 
            chk_fingerfries.AutoSize = true;
            chk_fingerfries.Font = new Font("Times New Roman", 14F);
            chk_fingerfries.Location = new Point(10, 191);
            chk_fingerfries.Name = "chk_fingerfries";
            chk_fingerfries.Size = new Size(162, 37);
            chk_fingerfries.TabIndex = 4;
            chk_fingerfries.Text = "finger fries";
            chk_fingerfries.UseVisualStyleBackColor = true;
            chk_fingerfries.CheckedChanged += chk_fingerfries_CheckedChanged;
            // 
            // chk_sandwich
            // 
            chk_sandwich.AutoSize = true;
            chk_sandwich.Font = new Font("Times New Roman", 14F);
            chk_sandwich.Location = new Point(11, 138);
            chk_sandwich.Name = "chk_sandwich";
            chk_sandwich.Size = new Size(145, 37);
            chk_sandwich.TabIndex = 3;
            chk_sandwich.Text = "sandwich";
            chk_sandwich.UseVisualStyleBackColor = true;
            chk_sandwich.CheckedChanged += chk_sandwich_CheckedChanged;
            // 
            // chk_pizza
            // 
            chk_pizza.AutoSize = true;
            chk_pizza.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_pizza.Location = new Point(10, 90);
            chk_pizza.Name = "chk_pizza";
            chk_pizza.Size = new Size(99, 37);
            chk_pizza.TabIndex = 2;
            chk_pizza.Text = "pizza";
            chk_pizza.UseVisualStyleBackColor = true;
            chk_pizza.CheckedChanged += chk_pizza_CheckedChanged;
            // 
            // chk_burger
            // 
            chk_burger.AutoSize = true;
            chk_burger.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_burger.Location = new Point(11, 49);
            chk_burger.Name = "chk_burger";
            chk_burger.Size = new Size(111, 37);
            chk_burger.TabIndex = 1;
            chk_burger.Text = "burger";
            chk_burger.UseVisualStyleBackColor = true;
            chk_burger.CheckedChanged += chk_burger_CheckedChanged;
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_quantity.Location = new Point(353, 0);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(106, 33);
            lbl_quantity.TabIndex = 0;
            lbl_quantity.Text = "quantity";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_pepsi);
            groupBox2.Controls.Add(txt_7up);
            groupBox2.Controls.Add(txt_fanta);
            groupBox2.Controls.Add(txt_cocacola);
            groupBox2.Controls.Add(txt_sprite);
            groupBox2.Controls.Add(chk_pepsi);
            groupBox2.Controls.Add(chk_7up);
            groupBox2.Controls.Add(chk_fanta);
            groupBox2.Controls.Add(chk_cocacola);
            groupBox2.Controls.Add(chk_sprite);
            groupBox2.Controls.Add(lbl_quanty);
            groupBox2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(644, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 291);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Drinks";
            // 
            // txt_pepsi
            // 
            txt_pepsi.Location = new Point(401, 238);
            txt_pepsi.Name = "txt_pepsi";
            txt_pepsi.Size = new Size(38, 40);
            txt_pepsi.TabIndex = 23;
            // 
            // txt_7up
            // 
            txt_7up.Location = new Point(401, 191);
            txt_7up.Name = "txt_7up";
            txt_7up.Size = new Size(38, 40);
            txt_7up.TabIndex = 22;
            // 
            // txt_fanta
            // 
            txt_fanta.Location = new Point(401, 139);
            txt_fanta.Name = "txt_fanta";
            txt_fanta.Size = new Size(38, 40);
            txt_fanta.TabIndex = 21;
            // 
            // txt_cocacola
            // 
            txt_cocacola.Location = new Point(401, 88);
            txt_cocacola.Name = "txt_cocacola";
            txt_cocacola.Size = new Size(38, 40);
            txt_cocacola.TabIndex = 20;
            // 
            // txt_sprite
            // 
            txt_sprite.Location = new Point(401, 39);
            txt_sprite.Name = "txt_sprite";
            txt_sprite.Size = new Size(38, 40);
            txt_sprite.TabIndex = 19;
            // 
            // chk_pepsi
            // 
            chk_pepsi.AutoSize = true;
            chk_pepsi.Font = new Font("Times New Roman", 14F);
            chk_pepsi.Location = new Point(22, 236);
            chk_pepsi.Name = "chk_pepsi";
            chk_pepsi.Size = new Size(100, 37);
            chk_pepsi.TabIndex = 6;
            chk_pepsi.Text = "pepsi";
            chk_pepsi.UseVisualStyleBackColor = true;
            chk_pepsi.CheckedChanged += chk_pepsi_CheckedChanged;
            // 
            // chk_7up
            // 
            chk_7up.AutoSize = true;
            chk_7up.Font = new Font("Times New Roman", 14F);
            chk_7up.Location = new Point(22, 191);
            chk_7up.Name = "chk_7up";
            chk_7up.Size = new Size(83, 37);
            chk_7up.TabIndex = 5;
            chk_7up.Text = "7up";
            chk_7up.UseVisualStyleBackColor = true;
            chk_7up.CheckedChanged += chk_7up_CheckedChanged;
            // 
            // chk_fanta
            // 
            chk_fanta.AutoSize = true;
            chk_fanta.Font = new Font("Times New Roman", 14F);
            chk_fanta.Location = new Point(22, 139);
            chk_fanta.Name = "chk_fanta";
            chk_fanta.Size = new Size(96, 37);
            chk_fanta.TabIndex = 4;
            chk_fanta.Text = "fanta";
            chk_fanta.UseVisualStyleBackColor = true;
            chk_fanta.CheckedChanged += chk_fanta_CheckedChanged;
            // 
            // chk_cocacola
            // 
            chk_cocacola.AutoSize = true;
            chk_cocacola.Font = new Font("Times New Roman", 14F);
            chk_cocacola.Location = new Point(22, 93);
            chk_cocacola.Name = "chk_cocacola";
            chk_cocacola.Size = new Size(144, 37);
            chk_cocacola.TabIndex = 3;
            chk_cocacola.Text = "coca cola";
            chk_cocacola.UseVisualStyleBackColor = true;
            chk_cocacola.CheckedChanged += chk_cocacola_CheckedChanged;
            // 
            // chk_sprite
            // 
            chk_sprite.AutoSize = true;
            chk_sprite.Font = new Font("Times New Roman", 14F);
            chk_sprite.Location = new Point(22, 46);
            chk_sprite.Name = "chk_sprite";
            chk_sprite.Size = new Size(103, 37);
            chk_sprite.TabIndex = 2;
            chk_sprite.Text = "sprite";
            chk_sprite.UseVisualStyleBackColor = true;
            chk_sprite.CheckedChanged += chk_sprite_CheckedChanged;
            // 
            // lbl_quanty
            // 
            lbl_quanty.AutoSize = true;
            lbl_quanty.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_quanty.Location = new Point(347, 0);
            lbl_quanty.Name = "lbl_quanty";
            lbl_quanty.Size = new Size(106, 33);
            lbl_quanty.TabIndex = 1;
            lbl_quanty.Text = "quantity";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(55, 361);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(79, 26);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "Name:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(55, 432);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(103, 26);
            lbl_address.TabIndex = 3;
            lbl_address.Text = "Address:";
            // 
            // lbl_contactnumber
            // 
            lbl_contactnumber.AutoSize = true;
            lbl_contactnumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contactnumber.Location = new Point(48, 491);
            lbl_contactnumber.Name = "lbl_contactnumber";
            lbl_contactnumber.Size = new Size(187, 26);
            lbl_contactnumber.TabIndex = 4;
            lbl_contactnumber.Text = "Contact number:";
            // 
            // lbl_payment
            // 
            lbl_payment.AutoSize = true;
            lbl_payment.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_payment.Location = new Point(697, 340);
            lbl_payment.Name = "lbl_payment";
            lbl_payment.Size = new Size(186, 26);
            lbl_payment.TabIndex = 5;
            lbl_payment.Text = "payment Method";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(809, 429);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(72, 26);
            lbl_total.TabIndex = 6;
            lbl_total.Text = "Total:";
            // 
            // lbl_totalresult
            // 
            lbl_totalresult.AutoSize = true;
            lbl_totalresult.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_totalresult.Location = new Point(956, 432);
            lbl_totalresult.Name = "lbl_totalresult";
            lbl_totalresult.Size = new Size(130, 26);
            lbl_totalresult.TabIndex = 7;
            lbl_totalresult.Text = "total Result";
            // 
            // lbl_change
            // 
            lbl_change.AutoSize = true;
            lbl_change.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_change.Location = new Point(809, 488);
            lbl_change.Name = "lbl_change";
            lbl_change.Size = new Size(98, 26);
            lbl_change.TabIndex = 8;
            lbl_change.Text = "Change:";
            // 
            // lbl_changeresult
            // 
            lbl_changeresult.AutoSize = true;
            lbl_changeresult.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_changeresult.Location = new Point(942, 488);
            lbl_changeresult.Name = "lbl_changeresult";
            lbl_changeresult.Size = new Size(155, 26);
            lbl_changeresult.TabIndex = 9;
            lbl_changeresult.Text = "change Result";
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ok.Location = new Point(55, 556);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(112, 34);
            btn_ok.TabIndex = 10;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_reset
            // 
            btn_reset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reset.Location = new Point(233, 556);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(112, 34);
            btn_reset.TabIndex = 11;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(407, 556);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(112, 34);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_total
            // 
            btn_total.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_total.Location = new Point(937, 556);
            btn_total.Name = "btn_total";
            btn_total.Size = new Size(112, 34);
            btn_total.TabIndex = 13;
            btn_total.Text = "Total";
            btn_total.UseVisualStyleBackColor = true;
            btn_total.Click += btn_total_Click_1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(278, 363);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(179, 28);
            txt_name.TabIndex = 14;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(278, 432);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(179, 28);
            txt_address.TabIndex = 15;
            // 
            // txt_contactnumber
            // 
            txt_contactnumber.Location = new Point(278, 491);
            txt_contactnumber.Name = "txt_contactnumber";
            txt_contactnumber.Size = new Size(179, 28);
            txt_contactnumber.TabIndex = 16;
            // 
            // txt_payment
            // 
            txt_payment.Location = new Point(901, 386);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(182, 28);
            txt_payment.TabIndex = 17;
            // 
            // cmb_payment
            // 
            cmb_payment.FormattingEnabled = true;
            cmb_payment.Location = new Point(901, 340);
            cmb_payment.Name = "cmb_payment";
            cmb_payment.Size = new Size(182, 28);
            cmb_payment.TabIndex = 18;
            cmb_payment.SelectedIndexChanged += cmb_payment_SelectedIndexChanged;
            // 
            // frm_items
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1137, 625);
            Controls.Add(cmb_payment);
            Controls.Add(txt_payment);
            Controls.Add(txt_contactnumber);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(btn_total);
            Controls.Add(btn_exit);
            Controls.Add(btn_reset);
            Controls.Add(btn_ok);
            Controls.Add(lbl_changeresult);
            Controls.Add(lbl_change);
            Controls.Add(lbl_totalresult);
            Controls.Add(lbl_total);
            Controls.Add(lbl_payment);
            Controls.Add(lbl_contactnumber);
            Controls.Add(lbl_address);
            Controls.Add(lbl_name);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_items";
            Text = "items";
            Load += frm_items_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_quantity;
        private GroupBox groupBox2;
        private Label lbl_quanty;
        private CheckBox chk_biryani;
        private CheckBox chk_fingerfries;
        private CheckBox chk_sandwich;
        private CheckBox chk_pizza;
        private CheckBox chk_burger;
        private CheckBox chk_pepsi;
        private CheckBox chk_7up;
        private CheckBox chk_fanta;
        private CheckBox chk_cocacola;
        private CheckBox chk_sprite;
        private Label lbl_name;
        private Label lbl_address;
        private Label lbl_contactnumber;
        private Label lbl_payment;
        private Label lbl_total;
        private TextBox txt_pizza;
        private TextBox txt_burger;
        private Label lbl_totalresult;
        private Label lbl_change;
        private Label lbl_changeresult;
        private Button btn_ok;
        private Button btn_reset;
        private Button btn_exit;
        private Button btn_total;
        private TextBox txt_name;
        private TextBox txt_address;
        private TextBox txt_contactnumber;
        private TextBox txt_payment;
        private TextBox txt_sandwich;
        private TextBox txt_biryani;
        private TextBox txt_fingerfries;
        private TextBox txt_pepsi;
        private TextBox txt_7up;
        private TextBox txt_fanta;
        private TextBox txt_cocacola;
        private TextBox txt_sprite;
        private ComboBox cmb_payment;
    }
}