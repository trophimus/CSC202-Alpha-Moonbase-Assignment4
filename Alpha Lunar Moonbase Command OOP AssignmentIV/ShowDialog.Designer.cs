namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    partial class ShowDialog
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
            this.TBTusername = new System.Windows.Forms.TextBox();
            this.BTNok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBTusername
            // 
            this.TBTusername.Location = new System.Drawing.Point(150, 110);
            this.TBTusername.Name = "TBTusername";
            this.TBTusername.Size = new System.Drawing.Size(168, 20);
            this.TBTusername.TabIndex = 0;
            this.TBTusername.Text = "username";
            this.TBTusername.TextChanged += new System.EventHandler(this.TBTusername_TextChanged);
            // 
            // BTNok
            // 
            this.BTNok.Location = new System.Drawing.Point(189, 161);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(75, 23);
            this.BTNok.TabIndex = 1;
            this.BTNok.Text = "OK";
            this.BTNok.UseVisualStyleBackColor = true;
            this.BTNok.Click += new System.EventHandler(this.BTNok_Click);
            // 
            // ShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 252);
            this.Controls.Add(this.BTNok);
            this.Controls.Add(this.TBTusername);
            this.Name = "ShowDialog";
            this.Text = "Type Your Name Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTusername;
        private System.Windows.Forms.Button BTNok;
    }
}