namespace Car_Park_Management_System
{
    partial class frmmainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmainmenu));
            this.btnsystem = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsystem
            // 
            this.btnsystem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsystem.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystem.Location = new System.Drawing.Point(12, 69);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Size = new System.Drawing.Size(210, 139);
            this.btnsystem.TabIndex = 0;
            this.btnsystem.Text = "System";
            this.btnsystem.UseVisualStyleBackColor = false;
            this.btnsystem.Click += new System.EventHandler(this.btnsystem_click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreport.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(228, 69);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 141);
            this.btnreport.TabIndex = 1;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnadmin.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.Location = new System.Drawing.Point(12, 228);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(416, 46);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Admin Panel";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // frmmainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnsystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmainmenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsystem;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Label label1;
    }
}