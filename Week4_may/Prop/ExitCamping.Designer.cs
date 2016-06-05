namespace Prop
{
    partial class ExitCamping
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
            this.buttonLetOut = new System.Windows.Forms.Button();
            this.labelUserRFID = new System.Windows.Forms.Label();
            this.labelRFIDNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLetOut
            // 
            this.buttonLetOut.Location = new System.Drawing.Point(91, 148);
            this.buttonLetOut.Name = "buttonLetOut";
            this.buttonLetOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLetOut.TabIndex = 1;
            this.buttonLetOut.Text = "Let out";
            this.buttonLetOut.UseVisualStyleBackColor = true;
            this.buttonLetOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUserRFID
            // 
            this.labelUserRFID.AutoSize = true;
            this.labelUserRFID.Location = new System.Drawing.Point(88, 50);
            this.labelUserRFID.Name = "labelUserRFID";
            this.labelUserRFID.Size = new System.Drawing.Size(73, 17);
            this.labelUserRFID.TabIndex = 2;
            this.labelUserRFID.Text = "User RFID";
            // 
            // labelRFIDNumber
            // 
            this.labelRFIDNumber.AutoSize = true;
            this.labelRFIDNumber.Location = new System.Drawing.Point(88, 84);
            this.labelRFIDNumber.Name = "labelRFIDNumber";
            this.labelRFIDNumber.Size = new System.Drawing.Size(95, 17);
            this.labelRFIDNumber.TabIndex = 3;
            this.labelRFIDNumber.Text = "RFID_number";
            // 
            // ExitCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.labelRFIDNumber);
            this.Controls.Add(this.labelUserRFID);
            this.Controls.Add(this.buttonLetOut);
            this.Name = "ExitCamping";
            this.Text = "ExitCamping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLetOut;
        private System.Windows.Forms.Label labelUserRFID;
        private System.Windows.Forms.Label labelRFIDNumber;
    }
}