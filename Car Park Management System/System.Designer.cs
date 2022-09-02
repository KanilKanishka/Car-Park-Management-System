namespace Car_Park_Management_System
{
    partial class frmsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsystem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntimein = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtvehicle_number = new System.Windows.Forms.TextBox();
            this.vehicletype = new System.Windows.Forms.ListBox();
            this.lblvehiclenumber = new System.Windows.Forms.Label();
            this.lblvehiclecategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbloccupied = new System.Windows.Forms.Label();
            this.lblavailble = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.lorryavailble = new System.Windows.Forms.Label();
            this.lorryoccupied = new System.Windows.Forms.Label();
            this.busavailble = new System.Windows.Forms.Label();
            this.busoccupied = new System.Windows.Forms.Label();
            this.vanavailble = new System.Windows.Forms.Label();
            this.vanoccupied = new System.Windows.Forms.Label();
            this.caravailble = new System.Windows.Forms.Label();
            this.caroccupied = new System.Windows.Forms.Label();
            this.bikeavailble = new System.Windows.Forms.Label();
            this.bikeoccupied = new System.Windows.Forms.Label();
            this.lbllorry = new System.Windows.Forms.Label();
            this.lblbus = new System.Windows.Forms.Label();
            this.lblvan = new System.Windows.Forms.Label();
            this.lblcar = new System.Windows.Forms.Label();
            this.lblbike = new System.Windows.Forms.Label();
            this.lblduration1 = new System.Windows.Forms.Label();
            this.lblfees1 = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.btnprintbill = new System.Windows.Forms.Button();
            this.btnmainmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btntimeout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnldashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btntimein
            // 
            this.btntimein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btntimein.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntimein.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimein.Location = new System.Drawing.Point(170, 287);
            this.btntimein.Name = "btntimein";
            this.btntimein.Size = new System.Drawing.Size(113, 32);
            this.btntimein.TabIndex = 1;
            this.btntimein.Text = "Vehicle IN";
            this.btntimein.UseVisualStyleBackColor = false;
            this.btntimein.Click += new System.EventHandler(this.btntimein_Click);
            // 
            // btnedit
            // 
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnedit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(313, 461);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 34);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndelete.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(432, 460);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 35);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtvehicle_number
            // 
            this.txtvehicle_number.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvehicle_number.Location = new System.Drawing.Point(165, 221);
            this.txtvehicle_number.Name = "txtvehicle_number";
            this.txtvehicle_number.Size = new System.Drawing.Size(131, 23);
            this.txtvehicle_number.TabIndex = 6;
            // 
            // vehicletype
            // 
            this.vehicletype.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicletype.FormattingEnabled = true;
            this.vehicletype.ItemHeight = 15;
            this.vehicletype.Items.AddRange(new object[] {
            "Bike",
            "Car",
            "Van",
            "Bus",
            "Lorry"});
            this.vehicletype.Location = new System.Drawing.Point(165, 255);
            this.vehicletype.Name = "vehicletype";
            this.vehicletype.Size = new System.Drawing.Size(131, 19);
            this.vehicletype.TabIndex = 9;
            // 
            // lblvehiclenumber
            // 
            this.lblvehiclenumber.AutoSize = true;
            this.lblvehiclenumber.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehiclenumber.Location = new System.Drawing.Point(17, 224);
            this.lblvehiclenumber.Name = "lblvehiclenumber";
            this.lblvehiclenumber.Size = new System.Drawing.Size(114, 15);
            this.lblvehiclenumber.TabIndex = 10;
            this.lblvehiclenumber.Text = "Vehicle Number";
            // 
            // lblvehiclecategory
            // 
            this.lblvehiclecategory.AutoSize = true;
            this.lblvehiclecategory.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehiclecategory.Location = new System.Drawing.Point(17, 259);
            this.lblvehiclecategory.Name = "lblvehiclecategory";
            this.lblvehiclecategory.Size = new System.Drawing.Size(125, 15);
            this.lblvehiclecategory.TabIndex = 11;
            this.lblvehiclecategory.Text = "Vehicle Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 12;
            // 
            // lbloccupied
            // 
            this.lbloccupied.AutoSize = true;
            this.lbloccupied.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloccupied.Location = new System.Drawing.Point(69, 73);
            this.lbloccupied.Name = "lbloccupied";
            this.lbloccupied.Size = new System.Drawing.Size(59, 14);
            this.lbloccupied.TabIndex = 15;
            this.lbloccupied.Text = "Occupied";
            // 
            // lblavailble
            // 
            this.lblavailble.AutoSize = true;
            this.lblavailble.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailble.Location = new System.Drawing.Point(134, 73);
            this.lblavailble.Name = "lblavailble";
            this.lblavailble.Size = new System.Drawing.Size(49, 14);
            this.lblavailble.TabIndex = 16;
            this.lblavailble.Text = "Avaible";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(632, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 20);
            this.button5.TabIndex = 21;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnldashboard
            // 
            this.pnldashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnldashboard.Controls.Add(this.lorryavailble);
            this.pnldashboard.Controls.Add(this.lorryoccupied);
            this.pnldashboard.Controls.Add(this.busavailble);
            this.pnldashboard.Controls.Add(this.busoccupied);
            this.pnldashboard.Controls.Add(this.vanavailble);
            this.pnldashboard.Controls.Add(this.vanoccupied);
            this.pnldashboard.Controls.Add(this.caravailble);
            this.pnldashboard.Controls.Add(this.caroccupied);
            this.pnldashboard.Controls.Add(this.bikeavailble);
            this.pnldashboard.Controls.Add(this.bikeoccupied);
            this.pnldashboard.Controls.Add(this.lbllorry);
            this.pnldashboard.Controls.Add(this.lblbus);
            this.pnldashboard.Controls.Add(this.lblvan);
            this.pnldashboard.Controls.Add(this.lblcar);
            this.pnldashboard.Controls.Add(this.lblbike);
            this.pnldashboard.Controls.Add(this.lbloccupied);
            this.pnldashboard.Controls.Add(this.lblavailble);
            this.pnldashboard.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldashboard.Location = new System.Drawing.Point(804, 3);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(196, 509);
            this.pnldashboard.TabIndex = 22;
            // 
            // lorryavailble
            // 
            this.lorryavailble.AutoSize = true;
            this.lorryavailble.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lorryavailble.Location = new System.Drawing.Point(146, 287);
            this.lorryavailble.Name = "lorryavailble";
            this.lorryavailble.Size = new System.Drawing.Size(46, 22);
            this.lorryavailble.TabIndex = 32;
            this.lorryavailble.Text = "100";
            // 
            // lorryoccupied
            // 
            this.lorryoccupied.AutoSize = true;
            this.lorryoccupied.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lorryoccupied.Location = new System.Drawing.Point(92, 287);
            this.lorryoccupied.Name = "lorryoccupied";
            this.lorryoccupied.Size = new System.Drawing.Size(22, 22);
            this.lorryoccupied.TabIndex = 31;
            this.lorryoccupied.Text = "0";
            // 
            // busavailble
            // 
            this.busavailble.AutoSize = true;
            this.busavailble.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busavailble.Location = new System.Drawing.Point(146, 242);
            this.busavailble.Name = "busavailble";
            this.busavailble.Size = new System.Drawing.Size(46, 22);
            this.busavailble.TabIndex = 30;
            this.busavailble.Text = "100";
            // 
            // busoccupied
            // 
            this.busoccupied.AutoSize = true;
            this.busoccupied.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busoccupied.Location = new System.Drawing.Point(92, 242);
            this.busoccupied.Name = "busoccupied";
            this.busoccupied.Size = new System.Drawing.Size(22, 22);
            this.busoccupied.TabIndex = 29;
            this.busoccupied.Text = "0";
            // 
            // vanavailble
            // 
            this.vanavailble.AutoSize = true;
            this.vanavailble.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanavailble.Location = new System.Drawing.Point(146, 201);
            this.vanavailble.Name = "vanavailble";
            this.vanavailble.Size = new System.Drawing.Size(46, 22);
            this.vanavailble.TabIndex = 28;
            this.vanavailble.Text = "100";
            // 
            // vanoccupied
            // 
            this.vanoccupied.AutoSize = true;
            this.vanoccupied.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanoccupied.Location = new System.Drawing.Point(92, 201);
            this.vanoccupied.Name = "vanoccupied";
            this.vanoccupied.Size = new System.Drawing.Size(22, 22);
            this.vanoccupied.TabIndex = 27;
            this.vanoccupied.Text = "0";
            // 
            // caravailble
            // 
            this.caravailble.AutoSize = true;
            this.caravailble.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caravailble.Location = new System.Drawing.Point(146, 152);
            this.caravailble.Name = "caravailble";
            this.caravailble.Size = new System.Drawing.Size(46, 22);
            this.caravailble.TabIndex = 26;
            this.caravailble.Text = "100";
            // 
            // caroccupied
            // 
            this.caroccupied.AutoSize = true;
            this.caroccupied.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caroccupied.Location = new System.Drawing.Point(92, 152);
            this.caroccupied.Name = "caroccupied";
            this.caroccupied.Size = new System.Drawing.Size(22, 22);
            this.caroccupied.TabIndex = 25;
            this.caroccupied.Text = "0";
            // 
            // bikeavailble
            // 
            this.bikeavailble.AutoSize = true;
            this.bikeavailble.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeavailble.Location = new System.Drawing.Point(146, 105);
            this.bikeavailble.Name = "bikeavailble";
            this.bikeavailble.Size = new System.Drawing.Size(46, 22);
            this.bikeavailble.TabIndex = 24;
            this.bikeavailble.Text = "100";
            // 
            // bikeoccupied
            // 
            this.bikeoccupied.AutoSize = true;
            this.bikeoccupied.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeoccupied.Location = new System.Drawing.Point(92, 105);
            this.bikeoccupied.Name = "bikeoccupied";
            this.bikeoccupied.Size = new System.Drawing.Size(22, 22);
            this.bikeoccupied.TabIndex = 23;
            this.bikeoccupied.Text = "0";
            // 
            // lbllorry
            // 
            this.lbllorry.AutoSize = true;
            this.lbllorry.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllorry.Location = new System.Drawing.Point(19, 287);
            this.lbllorry.Name = "lbllorry";
            this.lbllorry.Size = new System.Drawing.Size(64, 22);
            this.lbllorry.TabIndex = 4;
            this.lbllorry.Text = "Lorry";
            // 
            // lblbus
            // 
            this.lblbus.AutoSize = true;
            this.lblbus.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbus.Location = new System.Drawing.Point(19, 242);
            this.lblbus.Name = "lblbus";
            this.lblbus.Size = new System.Drawing.Size(44, 22);
            this.lblbus.TabIndex = 3;
            this.lblbus.Text = "Bus";
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvan.Location = new System.Drawing.Point(19, 201);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(48, 22);
            this.lblvan.TabIndex = 2;
            this.lblvan.Text = "Van";
            // 
            // lblcar
            // 
            this.lblcar.AutoSize = true;
            this.lblcar.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcar.Location = new System.Drawing.Point(19, 152);
            this.lblcar.Name = "lblcar";
            this.lblcar.Size = new System.Drawing.Size(44, 22);
            this.lblcar.TabIndex = 1;
            this.lblcar.Text = "Car";
            // 
            // lblbike
            // 
            this.lblbike.AutoSize = true;
            this.lblbike.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbike.Location = new System.Drawing.Point(19, 105);
            this.lblbike.Name = "lblbike";
            this.lblbike.Size = new System.Drawing.Size(51, 22);
            this.lblbike.TabIndex = 0;
            this.lblbike.Text = "Bike";
            // 
            // lblduration1
            // 
            this.lblduration1.AutoSize = true;
            this.lblduration1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration1.Location = new System.Drawing.Point(175, 387);
            this.lblduration1.Name = "lblduration1";
            this.lblduration1.Size = new System.Drawing.Size(15, 15);
            this.lblduration1.TabIndex = 23;
            this.lblduration1.Text = "0";
            // 
            // lblfees1
            // 
            this.lblfees1.AutoSize = true;
            this.lblfees1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees1.Location = new System.Drawing.Point(176, 427);
            this.lblfees1.Name = "lblfees1";
            this.lblfees1.Size = new System.Drawing.Size(15, 15);
            this.lblfees1.TabIndex = 24;
            this.lblfees1.Text = "0";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.Location = new System.Drawing.Point(50, 387);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(66, 15);
            this.lblduration.TabIndex = 25;
            this.lblduration.Text = "Duration";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees.Location = new System.Drawing.Point(50, 427);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(39, 15);
            this.lblfees.TabIndex = 26;
            this.lblfees.Text = "Fees";
            // 
            // btnprintbill
            // 
            this.btnprintbill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnprintbill.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintbill.Location = new System.Drawing.Point(33, 462);
            this.btnprintbill.Name = "btnprintbill";
            this.btnprintbill.Size = new System.Drawing.Size(239, 35);
            this.btnprintbill.TabIndex = 27;
            this.btnprintbill.Text = "Print Bill";
            this.btnprintbill.UseVisualStyleBackColor = true;
            this.btnprintbill.Click += new System.EventHandler(this.btnprintbill_Click);
            // 
            // btnmainmenu
            // 
            this.btnmainmenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmainmenu.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainmenu.Location = new System.Drawing.Point(710, 462);
            this.btnmainmenu.Name = "btnmainmenu";
            this.btnmainmenu.Size = new System.Drawing.Size(88, 33);
            this.btnmainmenu.TabIndex = 28;
            this.btnmainmenu.Text = "Main Menu";
            this.btnmainmenu.UseVisualStyleBackColor = true;
            this.btnmainmenu.Click += new System.EventHandler(this.btnmainmenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Enter += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // btntimeout
            // 
            this.btntimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntimeout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntimeout.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimeout.Location = new System.Drawing.Point(170, 328);
            this.btntimeout.Name = "btntimeout";
            this.btntimeout.Size = new System.Drawing.Size(113, 32);
            this.btntimeout.TabIndex = 2;
            this.btntimeout.Text = "Vehicle OUT";
            this.btntimeout.UseVisualStyleBackColor = false;
            this.btntimeout.Click += new System.EventHandler(this.btntimeout_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "dd-mm-yy-hh:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 23);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 29, 10, 19, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmainmenu);
            this.Controls.Add(this.btnprintbill);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblfees1);
            this.Controls.Add(this.lblduration1);
            this.Controls.Add(this.pnldashboard);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblvehiclecategory);
            this.Controls.Add(this.lblvehiclenumber);
            this.Controls.Add(this.vehicletype);
            this.Controls.Add(this.txtvehicle_number);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntimeout);
            this.Controls.Add(this.btntimein);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsystem";
            this.Text = "Car Park Management System";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnldashboard.ResumeLayout(false);
            this.pnldashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntimein;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtvehicle_number;
        private System.Windows.Forms.ListBox vehicletype;
        private System.Windows.Forms.Label lblvehiclenumber;
        private System.Windows.Forms.Label lblvehiclecategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbloccupied;
        private System.Windows.Forms.Label lblavailble;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Label lorryavailble;
        private System.Windows.Forms.Label lorryoccupied;
        private System.Windows.Forms.Label busavailble;
        private System.Windows.Forms.Label busoccupied;
        private System.Windows.Forms.Label vanavailble;
        private System.Windows.Forms.Label vanoccupied;
        private System.Windows.Forms.Label caravailble;
        private System.Windows.Forms.Label caroccupied;
        private System.Windows.Forms.Label bikeavailble;
        private System.Windows.Forms.Label bikeoccupied;
        private System.Windows.Forms.Label lbllorry;
        private System.Windows.Forms.Label lblbus;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.Label lblcar;
        private System.Windows.Forms.Label lblbike;
        private System.Windows.Forms.Label lblduration1;
        private System.Windows.Forms.Label lblfees1;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Button btnprintbill;
        private System.Windows.Forms.Button btnmainmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btntimeout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}