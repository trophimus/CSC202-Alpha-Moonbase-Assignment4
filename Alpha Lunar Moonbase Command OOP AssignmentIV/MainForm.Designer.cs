namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    partial class MainForm
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
            this.lblRoomName = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.GBnavigation = new System.Windows.Forms.GroupBox();
            this.BTNsouth = new System.Windows.Forms.Button();
            this.BTNeast = new System.Windows.Forms.Button();
            this.BTNwest = new System.Windows.Forms.Button();
            this.BTNnorth = new System.Windows.Forms.Button();
            this.txtRoomDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.GBnavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(45, 25);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(35, 13);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "label1";
            // 
            // picBackground
            // 
            this.picBackground.Location = new System.Drawing.Point(202, 12);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1050, 494);
            this.picBackground.TabIndex = 1;
            this.picBackground.TabStop = false;
            // 
            // GBnavigation
            // 
            this.GBnavigation.BackColor = System.Drawing.Color.IndianRed;
            this.GBnavigation.Controls.Add(this.BTNsouth);
            this.GBnavigation.Controls.Add(this.BTNeast);
            this.GBnavigation.Controls.Add(this.BTNwest);
            this.GBnavigation.Controls.Add(this.BTNnorth);
            this.GBnavigation.Controls.Add(this.lblRoomName);
            this.GBnavigation.Location = new System.Drawing.Point(-4, 348);
            this.GBnavigation.Name = "GBnavigation";
            this.GBnavigation.Size = new System.Drawing.Size(200, 137);
            this.GBnavigation.TabIndex = 2;
            this.GBnavigation.TabStop = false;
            this.GBnavigation.Text = "NAVIGATION";
            // 
            // BTNsouth
            // 
            this.BTNsouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNsouth.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsouth.Location = new System.Drawing.Point(64, 108);
            this.BTNsouth.Name = "BTNsouth";
            this.BTNsouth.Size = new System.Drawing.Size(57, 23);
            this.BTNsouth.TabIndex = 4;
            this.BTNsouth.Text = "South";
            this.BTNsouth.UseVisualStyleBackColor = false;
            // 
            // BTNeast
            // 
            this.BTNeast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNeast.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeast.Location = new System.Drawing.Point(130, 69);
            this.BTNeast.Name = "BTNeast";
            this.BTNeast.Size = new System.Drawing.Size(64, 23);
            this.BTNeast.TabIndex = 3;
            this.BTNeast.Text = "East";
            this.BTNeast.UseVisualStyleBackColor = false;
            this.BTNeast.Click += new System.EventHandler(this.BTNeast_Click);
            // 
            // BTNwest
            // 
            this.BTNwest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNwest.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNwest.Location = new System.Drawing.Point(6, 70);
            this.BTNwest.Name = "BTNwest";
            this.BTNwest.Size = new System.Drawing.Size(63, 23);
            this.BTNwest.TabIndex = 2;
            this.BTNwest.Text = "West";
            this.BTNwest.UseVisualStyleBackColor = false;
            // 
            // BTNnorth
            // 
            this.BTNnorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNnorth.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNnorth.Location = new System.Drawing.Point(64, 41);
            this.BTNnorth.Name = "BTNnorth";
            this.BTNnorth.Size = new System.Drawing.Size(75, 23);
            this.BTNnorth.TabIndex = 1;
            this.BTNnorth.Text = "North";
            this.BTNnorth.UseVisualStyleBackColor = false;
            this.BTNnorth.Click += new System.EventHandler(this.BTNnorth_Click);
            // 
            // txtRoomDescription
            // 
            this.txtRoomDescription.Location = new System.Drawing.Point(12, 195);
            this.txtRoomDescription.Multiline = true;
            this.txtRoomDescription.Name = "txtRoomDescription";
            this.txtRoomDescription.Size = new System.Drawing.Size(178, 134);
            this.txtRoomDescription.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.txtRoomDescription);
            this.Controls.Add(this.GBnavigation);
            this.Controls.Add(this.picBackground);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.GBnavigation.ResumeLayout(false);
            this.GBnavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.GroupBox GBnavigation;
        private System.Windows.Forms.Button BTNwest;
        private System.Windows.Forms.Button BTNnorth;
        private System.Windows.Forms.Button BTNsouth;
        private System.Windows.Forms.Button BTNeast;
        private System.Windows.Forms.TextBox txtRoomDescription;
    }
}

