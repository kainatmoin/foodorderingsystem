namespace foodorderingsystemmm
{
    partial class frm_front
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_ordernow = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 63);
            label1.Name = "label1";
            label1.Size = new Size(1064, 161);
            label1.TabIndex = 0;
            label1.Text = "Ordering System";
            // 
            // btn_ordernow
            // 
            btn_ordernow.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ordernow.Location = new Point(516, 419);
            btn_ordernow.Name = "btn_ordernow";
            btn_ordernow.Size = new Size(175, 46);
            btn_ordernow.TabIndex = 1;
            btn_ordernow.Text = "Order now";
            btn_ordernow.UseVisualStyleBackColor = true;
            btn_ordernow.Click += btn_ordernow_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(516, 499);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(175, 47);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // frm_front
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1155, 623);
            Controls.Add(btn_exit);
            Controls.Add(btn_ordernow);
            Controls.Add(label1);
            Name = "frm_front";
            Text = "Front";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ordernow;
        private Button btn_exit;
    }
}
