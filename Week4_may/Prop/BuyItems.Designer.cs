namespace Prop
{
    partial class BuyItems
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelRFID = new System.Windows.Forms.Label();
            this.RFIDNumber = new System.Windows.Forms.Label();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(379, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(584, 196);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(47, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(44, 174);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(59, 17);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show balance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(379, 263);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(377, 180);
            this.listBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "AddToCart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(44, 21);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 17);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelRFID
            // 
            this.labelRFID.AutoSize = true;
            this.labelRFID.Location = new System.Drawing.Point(44, 73);
            this.labelRFID.Name = "labelRFID";
            this.labelRFID.Size = new System.Drawing.Size(39, 17);
            this.labelRFID.TabIndex = 10;
            this.labelRFID.Text = "RFID";
            // 
            // RFIDNumber
            // 
            this.RFIDNumber.AutoSize = true;
            this.RFIDNumber.Location = new System.Drawing.Point(44, 102);
            this.RFIDNumber.Name = "RFIDNumber";
            this.RFIDNumber.Size = new System.Drawing.Size(32, 17);
            this.RFIDNumber.TabIndex = 11;
            this.RFIDNumber.Text = "111";
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Location = new System.Drawing.Point(44, 210);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(89, 17);
            this.labelUserBalance.TabIndex = 12;
            this.labelUserBalance.Text = "UserBalance";
            // 
            // BuyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 490);
            this.Controls.Add(this.labelUserBalance);
            this.Controls.Add(this.RFIDNumber);
            this.Controls.Add(this.labelRFID);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "BuyItems";
            this.Text = "BuyItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelRFID;
        private System.Windows.Forms.Label RFIDNumber;
        private System.Windows.Forms.Label labelUserBalance;
    }
}