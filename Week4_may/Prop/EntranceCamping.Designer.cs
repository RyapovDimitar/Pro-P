namespace Prop
{
    partial class EntranceCamping
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
            this.labeluserRFID = new System.Windows.Forms.Label();
            this.buttonLetIn = new System.Windows.Forms.Button();
            this.labelRFID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeluserRFID
            // 
            this.labeluserRFID.AutoSize = true;
            this.labeluserRFID.Location = new System.Drawing.Point(80, 29);
            this.labeluserRFID.Name = "labeluserRFID";
            this.labeluserRFID.Size = new System.Drawing.Size(75, 17);
            this.labeluserRFID.TabIndex = 4;
            this.labeluserRFID.Text = "user_RFID";
            // 
            // buttonLetIn
            // 
            this.buttonLetIn.Location = new System.Drawing.Point(83, 113);
            this.buttonLetIn.Name = "buttonLetIn";
            this.buttonLetIn.Size = new System.Drawing.Size(99, 23);
            this.buttonLetIn.TabIndex = 10;
            this.buttonLetIn.Text = "Let in";
            this.buttonLetIn.UseVisualStyleBackColor = true;
            this.buttonLetIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelRFID
            // 
            this.labelRFID.AutoSize = true;
            this.labelRFID.Location = new System.Drawing.Point(80, 66);
            this.labelRFID.Name = "labelRFID";
            this.labelRFID.Size = new System.Drawing.Size(95, 17);
            this.labelRFID.TabIndex = 11;
            this.labelRFID.Text = "RFID_number";
            // 
            // EntranceCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 520);
            this.Controls.Add(this.labelRFID);
            this.Controls.Add(this.buttonLetIn);
            this.Controls.Add(this.labeluserRFID);
            this.Name = "EntranceCamping";
            this.Text = "EntranceCamping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeluserRFID;
        private System.Windows.Forms.Button buttonLetIn;
        private System.Windows.Forms.Label labelRFID;
    }
}