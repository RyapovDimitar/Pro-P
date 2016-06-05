namespace Prop
{
    partial class EntranceForm
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
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.UserIDlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.RFID_label = new System.Windows.Forms.Label();
            this.FindUser = new System.Windows.Forms.Button();
            this.FindUserByName = new System.Windows.Forms.Button();
            this.AssignRFID = new System.Windows.Forms.Button();
            this.RFID_label_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(86, 134);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(162, 22);
            this.textBoxUserID.TabIndex = 0;
            // 
            // UserIDlabel
            // 
            this.UserIDlabel.AutoSize = true;
            this.UserIDlabel.Location = new System.Drawing.Point(83, 97);
            this.UserIDlabel.Name = "UserIDlabel";
            this.UserIDlabel.Size = new System.Drawing.Size(67, 17);
            this.UserIDlabel.TabIndex = 2;
            this.UserIDlabel.Text = "USER_ID";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(281, 97);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(284, 134);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(485, 22);
            this.textBoxFullName.TabIndex = 4;
            // 
            // RFID_label
            // 
            this.RFID_label.AutoSize = true;
            this.RFID_label.Location = new System.Drawing.Point(83, 216);
            this.RFID_label.Name = "RFID_label";
            this.RFID_label.Size = new System.Drawing.Size(39, 17);
            this.RFID_label.TabIndex = 5;
            this.RFID_label.Text = "RFID";
            // 
            // FindUser
            // 
            this.FindUser.Location = new System.Drawing.Point(86, 162);
            this.FindUser.Name = "FindUser";
            this.FindUser.Size = new System.Drawing.Size(75, 23);
            this.FindUser.TabIndex = 6;
            this.FindUser.Text = "Find";
            this.FindUser.UseVisualStyleBackColor = true;
            this.FindUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindUserByName
            // 
            this.FindUserByName.Location = new System.Drawing.Point(284, 162);
            this.FindUserByName.Name = "FindUserByName";
            this.FindUserByName.Size = new System.Drawing.Size(75, 23);
            this.FindUserByName.TabIndex = 7;
            this.FindUserByName.Text = "Find";
            this.FindUserByName.UseVisualStyleBackColor = true;
            this.FindUserByName.Click += new System.EventHandler(this.button2_Click);
            // 
            // AssignRFID
            // 
            this.AssignRFID.Location = new System.Drawing.Point(86, 274);
            this.AssignRFID.Name = "AssignRFID";
            this.AssignRFID.Size = new System.Drawing.Size(75, 23);
            this.AssignRFID.TabIndex = 8;
            this.AssignRFID.Text = "Assign";
            this.AssignRFID.UseVisualStyleBackColor = true;
            this.AssignRFID.Click += new System.EventHandler(this.button3_Click);
            // 
            // RFID_label_number
            // 
            this.RFID_label_number.AutoSize = true;
            this.RFID_label_number.Location = new System.Drawing.Point(83, 243);
            this.RFID_label_number.Name = "RFID_label_number";
            this.RFID_label_number.Size = new System.Drawing.Size(91, 17);
            this.RFID_label_number.TabIndex = 9;
            this.RFID_label_number.Text = "RFID number";
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 518);
            this.Controls.Add(this.RFID_label_number);
            this.Controls.Add(this.AssignRFID);
            this.Controls.Add(this.FindUserByName);
            this.Controls.Add(this.FindUser);
            this.Controls.Add(this.RFID_label);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.UserIDlabel);
            this.Controls.Add(this.textBoxUserID);
            this.Name = "EntranceForm";
            this.Text = "EntranceForm";
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label UserIDlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label RFID_label;
        private System.Windows.Forms.Button FindUser;
        private System.Windows.Forms.Button FindUserByName;
        private System.Windows.Forms.Button AssignRFID;
        private System.Windows.Forms.Label RFID_label_number;
    }
}