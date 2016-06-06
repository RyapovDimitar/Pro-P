namespace Prop
{
    partial class ExitForm
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
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.labelRFID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonShowName = new System.Windows.Forms.Button();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Location = new System.Drawing.Point(91, 104);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.Size = new System.Drawing.Size(233, 22);
            this.textBoxRFID.TabIndex = 0;
            this.textBoxRFID.Text = "1111";
            // 
            // labelRFID
            // 
            this.labelRFID.AutoSize = true;
            this.labelRFID.Location = new System.Drawing.Point(88, 61);
            this.labelRFID.Name = "labelRFID";
            this.labelRFID.Size = new System.Drawing.Size(39, 17);
            this.labelRFID.TabIndex = 1;
            this.labelRFID.Text = "RFID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 176);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // buttonShowName
            // 
            this.buttonShowName.Location = new System.Drawing.Point(91, 150);
            this.buttonShowName.Name = "buttonShowName";
            this.buttonShowName.Size = new System.Drawing.Size(133, 23);
            this.buttonShowName.TabIndex = 4;
            this.buttonShowName.Text = "Show Name";
            this.buttonShowName.UseVisualStyleBackColor = true;
            this.buttonShowName.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.Location = new System.Drawing.Point(91, 304);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(133, 23);
            this.buttonExitUser.TabIndex = 5;
            this.buttonExitUser.Text = "Exit user";
            this.buttonExitUser.UseVisualStyleBackColor = true;
            this.buttonExitUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(91, 262);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(133, 23);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "Check For Loaned";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(88, 211);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 17);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "UserName";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonExitUser);
            this.Controls.Add(this.buttonShowName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRFID);
            this.Controls.Add(this.textBoxRFID);
            this.Name = "ExitForm";
            this.Text = "ExitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRFID;
        private System.Windows.Forms.Label labelRFID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonShowName;
        private System.Windows.Forms.Button buttonExitUser;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelUserName;
    }
}