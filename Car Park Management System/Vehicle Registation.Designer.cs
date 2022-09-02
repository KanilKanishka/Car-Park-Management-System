namespace Car_Park_Management_System
{
    partial class frmvehicleregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvehicleregister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvehiclesubmit = new System.Windows.Forms.Button();
            this.txtvehiclecategory = new System.Windows.Forms.TextBox();
            this.txtcategoryfees = new System.Windows.Forms.TextBox();
            this.txtparkingslots = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paking Slots";
            // 
            // btnvehiclesubmit
            // 
            this.btnvehiclesubmit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvehiclesubmit.Location = new System.Drawing.Point(40, 209);
            this.btnvehiclesubmit.Name = "btnvehiclesubmit";
            this.btnvehiclesubmit.Size = new System.Drawing.Size(116, 38);
            this.btnvehiclesubmit.TabIndex = 3;
            this.btnvehiclesubmit.Text = "Submit";
            this.btnvehiclesubmit.UseVisualStyleBackColor = true;
            this.btnvehiclesubmit.Click += new System.EventHandler(this.btnvehiclesubmit_Click);
            // 
            // txtvehiclecategory
            // 
            this.txtvehiclecategory.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvehiclecategory.Location = new System.Drawing.Point(147, 65);
            this.txtvehiclecategory.Name = "txtvehiclecategory";
            this.txtvehiclecategory.Size = new System.Drawing.Size(131, 23);
            this.txtvehiclecategory.TabIndex = 4;
            // 
            // txtcategoryfees
            // 
            this.txtcategoryfees.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryfees.Location = new System.Drawing.Point(147, 105);
            this.txtcategoryfees.Name = "txtcategoryfees";
            this.txtcategoryfees.Size = new System.Drawing.Size(131, 23);
            this.txtcategoryfees.TabIndex = 5;
            // 
            // txtparkingslots
            // 
            this.txtparkingslots.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparkingslots.Location = new System.Drawing.Point(147, 142);
            this.txtparkingslots.Name = "txtparkingslots";
            this.txtparkingslots.Size = new System.Drawing.Size(131, 23);
            this.txtparkingslots.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmvehicleregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(296, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtparkingslots);
            this.Controls.Add(this.txtcategoryfees);
            this.Controls.Add(this.txtvehiclecategory);
            this.Controls.Add(this.btnvehiclesubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmvehicleregister";
            this.Text = "Vehicle Registation";
            this.Load += new System.EventHandler(this.frmvehicleregister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvehiclesubmit;
        private System.Windows.Forms.TextBox txtvehiclecategory;
        private System.Windows.Forms.TextBox txtcategoryfees;
        private System.Windows.Forms.TextBox txtparkingslots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}