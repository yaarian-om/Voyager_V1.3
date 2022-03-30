
namespace Voyager
{
    partial class UC_Transport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transport));
            this.panel_background = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_rail_places = new System.Windows.Forms.Panel();
            this.radioButton_rail_nonAC = new System.Windows.Forms.RadioButton();
            this.radioButton_rail_ac = new System.Windows.Forms.RadioButton();
            this.comboBox_railNames = new System.Windows.Forms.ComboBox();
            this.groupBox_rail_ac = new System.Windows.Forms.GroupBox();
            this.panel_bus_places = new System.Windows.Forms.Panel();
            this.comboBox_busNames = new System.Windows.Forms.ComboBox();
            this.groupBox_bus_ac = new System.Windows.Forms.GroupBox();
            this.radioButton_bus_nonAC = new System.Windows.Forms.RadioButton();
            this.radioButton_bus_ac = new System.Windows.Forms.RadioButton();
            this.panel_air_places = new System.Windows.Forms.Panel();
            this.comboBox_planeClass = new System.Windows.Forms.ComboBox();
            this.comboBox_planeNames = new System.Windows.Forms.ComboBox();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.panel_rail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_bus = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_air = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_B = new System.Windows.Forms.Panel();
            this.panel_C = new System.Windows.Forms.Panel();
            this.panel_A = new System.Windows.Forms.Panel();
            this.panel_background.SuspendLayout();
            this.panel_rail_places.SuspendLayout();
            this.panel_bus_places.SuspendLayout();
            this.groupBox_bus_ac.SuspendLayout();
            this.panel_air_places.SuspendLayout();
            this.panel_rail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_bus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_air.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.AutoScroll = true;
            this.panel_background.Controls.Add(this.label4);
            this.panel_background.Controls.Add(this.label_cost);
            this.panel_background.Controls.Add(this.label5);
            this.panel_background.Controls.Add(this.panel_rail_places);
            this.panel_background.Controls.Add(this.panel_bus_places);
            this.panel_background.Controls.Add(this.panel_air_places);
            this.panel_background.Controls.Add(this.button_previous);
            this.panel_background.Controls.Add(this.button_next);
            this.panel_background.Controls.Add(this.panel_rail);
            this.panel_background.Controls.Add(this.panel_bus);
            this.panel_background.Controls.Add(this.panel_air);
            this.panel_background.Controls.Add(this.panel_B);
            this.panel_background.Controls.Add(this.panel_C);
            this.panel_background.Controls.Add(this.panel_A);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(756, 764);
            this.panel_background.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tk/-";
            // 
            // label_cost
            // 
            this.label_cost.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.ForeColor = System.Drawing.Color.White;
            this.label_cost.Location = new System.Drawing.Point(339, 627);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(150, 39);
            this.label_cost.TabIndex = 20;
            this.label_cost.Text = "0";
            this.label_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 620);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 46);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cost :";
            // 
            // panel_rail_places
            // 
            this.panel_rail_places.Controls.Add(this.radioButton_rail_nonAC);
            this.panel_rail_places.Controls.Add(this.radioButton_rail_ac);
            this.panel_rail_places.Controls.Add(this.comboBox_railNames);
            this.panel_rail_places.Controls.Add(this.groupBox_rail_ac);
            this.panel_rail_places.Location = new System.Drawing.Point(607, 488);
            this.panel_rail_places.Name = "panel_rail_places";
            this.panel_rail_places.Size = new System.Drawing.Size(266, 81);
            this.panel_rail_places.TabIndex = 15;
            // 
            // radioButton_rail_nonAC
            // 
            this.radioButton_rail_nonAC.AutoSize = true;
            this.radioButton_rail_nonAC.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_rail_nonAC.ForeColor = System.Drawing.Color.White;
            this.radioButton_rail_nonAC.Location = new System.Drawing.Point(137, 44);
            this.radioButton_rail_nonAC.Name = "radioButton_rail_nonAC";
            this.radioButton_rail_nonAC.Size = new System.Drawing.Size(92, 25);
            this.radioButton_rail_nonAC.TabIndex = 3;
            this.radioButton_rail_nonAC.TabStop = true;
            this.radioButton_rail_nonAC.Text = "Non-AC";
            this.radioButton_rail_nonAC.UseVisualStyleBackColor = true;
            this.radioButton_rail_nonAC.CheckedChanged += new System.EventHandler(this.radioButton_rail_nonAC_CheckedChanged);
            // 
            // radioButton_rail_ac
            // 
            this.radioButton_rail_ac.AutoSize = true;
            this.radioButton_rail_ac.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_rail_ac.ForeColor = System.Drawing.Color.White;
            this.radioButton_rail_ac.Location = new System.Drawing.Point(46, 44);
            this.radioButton_rail_ac.Name = "radioButton_rail_ac";
            this.radioButton_rail_ac.Size = new System.Drawing.Size(51, 25);
            this.radioButton_rail_ac.TabIndex = 2;
            this.radioButton_rail_ac.TabStop = true;
            this.radioButton_rail_ac.Text = "AC";
            this.radioButton_rail_ac.UseVisualStyleBackColor = true;
            this.radioButton_rail_ac.CheckedChanged += new System.EventHandler(this.radioButton_rail_ac_CheckedChanged);
            // 
            // comboBox_railNames
            // 
            this.comboBox_railNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_railNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_railNames.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_railNames.FormattingEnabled = true;
            this.comboBox_railNames.Items.AddRange(new object[] {
            "Sonar Bangla",
            "Kalani Express",
            "Chattala Express",
            "Hawr express",
            "Upoban Express",
            "Mohanogor Provati Express",
            "Parbat Express",
            "Sonar Bangla Express",
            "Joyontika Express"});
            this.comboBox_railNames.Location = new System.Drawing.Point(0, 0);
            this.comboBox_railNames.Name = "comboBox_railNames";
            this.comboBox_railNames.Size = new System.Drawing.Size(266, 29);
            this.comboBox_railNames.TabIndex = 0;
            this.comboBox_railNames.SelectedIndexChanged += new System.EventHandler(this.comboBox_railNames_SelectedIndexChanged);
            // 
            // groupBox_rail_ac
            // 
            this.groupBox_rail_ac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_rail_ac.ForeColor = System.Drawing.Color.White;
            this.groupBox_rail_ac.Location = new System.Drawing.Point(0, 30);
            this.groupBox_rail_ac.Name = "groupBox_rail_ac";
            this.groupBox_rail_ac.Size = new System.Drawing.Size(266, 51);
            this.groupBox_rail_ac.TabIndex = 23;
            this.groupBox_rail_ac.TabStop = false;
            this.groupBox_rail_ac.Text = "AC/Non-AC";
            // 
            // panel_bus_places
            // 
            this.panel_bus_places.Controls.Add(this.comboBox_busNames);
            this.panel_bus_places.Controls.Add(this.groupBox_bus_ac);
            this.panel_bus_places.Location = new System.Drawing.Point(314, 489);
            this.panel_bus_places.Name = "panel_bus_places";
            this.panel_bus_places.Size = new System.Drawing.Size(266, 79);
            this.panel_bus_places.TabIndex = 15;
            // 
            // comboBox_busNames
            // 
            this.comboBox_busNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_busNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busNames.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_busNames.FormattingEnabled = true;
            this.comboBox_busNames.Items.AddRange(new object[] {
            "Green Line",
            "Desh Travels",
            "Shohagh Paribahan",
            "Soudia Coach Service",
            "Shyamoli Paribahan",
            "Royal Coach"});
            this.comboBox_busNames.Location = new System.Drawing.Point(0, 0);
            this.comboBox_busNames.Name = "comboBox_busNames";
            this.comboBox_busNames.Size = new System.Drawing.Size(266, 29);
            this.comboBox_busNames.TabIndex = 0;
            this.comboBox_busNames.SelectedIndexChanged += new System.EventHandler(this.comboBox_busNames_SelectedIndexChanged);
            // 
            // groupBox_bus_ac
            // 
            this.groupBox_bus_ac.Controls.Add(this.radioButton_bus_nonAC);
            this.groupBox_bus_ac.Controls.Add(this.radioButton_bus_ac);
            this.groupBox_bus_ac.ForeColor = System.Drawing.Color.White;
            this.groupBox_bus_ac.Location = new System.Drawing.Point(3, 33);
            this.groupBox_bus_ac.Name = "groupBox_bus_ac";
            this.groupBox_bus_ac.Size = new System.Drawing.Size(266, 51);
            this.groupBox_bus_ac.TabIndex = 22;
            this.groupBox_bus_ac.TabStop = false;
            this.groupBox_bus_ac.Text = "AC/Non-AC";
            // 
            // radioButton_bus_nonAC
            // 
            this.radioButton_bus_nonAC.AutoSize = true;
            this.radioButton_bus_nonAC.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_bus_nonAC.ForeColor = System.Drawing.Color.White;
            this.radioButton_bus_nonAC.Location = new System.Drawing.Point(138, 15);
            this.radioButton_bus_nonAC.Name = "radioButton_bus_nonAC";
            this.radioButton_bus_nonAC.Size = new System.Drawing.Size(92, 25);
            this.radioButton_bus_nonAC.TabIndex = 1;
            this.radioButton_bus_nonAC.TabStop = true;
            this.radioButton_bus_nonAC.Text = "Non-AC";
            this.radioButton_bus_nonAC.UseVisualStyleBackColor = true;
            this.radioButton_bus_nonAC.CheckedChanged += new System.EventHandler(this.radioButton_bus_nonAC_CheckedChanged);
            // 
            // radioButton_bus_ac
            // 
            this.radioButton_bus_ac.AutoSize = true;
            this.radioButton_bus_ac.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_bus_ac.ForeColor = System.Drawing.Color.White;
            this.radioButton_bus_ac.Location = new System.Drawing.Point(44, 16);
            this.radioButton_bus_ac.Name = "radioButton_bus_ac";
            this.radioButton_bus_ac.Size = new System.Drawing.Size(51, 25);
            this.radioButton_bus_ac.TabIndex = 0;
            this.radioButton_bus_ac.TabStop = true;
            this.radioButton_bus_ac.Text = "AC";
            this.radioButton_bus_ac.UseVisualStyleBackColor = true;
            this.radioButton_bus_ac.CheckedChanged += new System.EventHandler(this.radioButton_bus_ac_CheckedChanged);
            // 
            // panel_air_places
            // 
            this.panel_air_places.Controls.Add(this.comboBox_planeClass);
            this.panel_air_places.Controls.Add(this.comboBox_planeNames);
            this.panel_air_places.Location = new System.Drawing.Point(26, 489);
            this.panel_air_places.Name = "panel_air_places";
            this.panel_air_places.Size = new System.Drawing.Size(266, 79);
            this.panel_air_places.TabIndex = 14;
            // 
            // comboBox_planeClass
            // 
            this.comboBox_planeClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox_planeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_planeClass.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_planeClass.FormattingEnabled = true;
            this.comboBox_planeClass.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Economy Class"});
            this.comboBox_planeClass.Location = new System.Drawing.Point(0, 50);
            this.comboBox_planeClass.Name = "comboBox_planeClass";
            this.comboBox_planeClass.Size = new System.Drawing.Size(266, 29);
            this.comboBox_planeClass.TabIndex = 1;
            this.comboBox_planeClass.SelectedIndexChanged += new System.EventHandler(this.comboBox_planeClass_SelectedIndexChanged);
            // 
            // comboBox_planeNames
            // 
            this.comboBox_planeNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_planeNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_planeNames.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_planeNames.FormattingEnabled = true;
            this.comboBox_planeNames.Items.AddRange(new object[] {
            "Biman Bangladesh Airlines",
            "Novoair",
            "Regent Airways",
            "US-Bangla Airlines"});
            this.comboBox_planeNames.Location = new System.Drawing.Point(0, 0);
            this.comboBox_planeNames.Name = "comboBox_planeNames";
            this.comboBox_planeNames.Size = new System.Drawing.Size(266, 29);
            this.comboBox_planeNames.TabIndex = 0;
            this.comboBox_planeNames.SelectedIndexChanged += new System.EventHandler(this.comboBox_air_SelectedIndexChanged);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.BurlyWood;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Black;
            this.button_previous.Location = new System.Drawing.Point(517, 706);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(115, 39);
            this.button_previous.TabIndex = 13;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Chartreuse;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Black;
            this.button_next.Location = new System.Drawing.Point(638, 706);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(115, 39);
            this.button_next.TabIndex = 12;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // panel_rail
            // 
            this.panel_rail.BackColor = System.Drawing.Color.Transparent;
            this.panel_rail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_rail.Controls.Add(this.label3);
            this.panel_rail.Controls.Add(this.pictureBox3);
            this.panel_rail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_rail.Location = new System.Drawing.Point(610, 27);
            this.panel_rail.Name = "panel_rail";
            this.panel_rail.Size = new System.Drawing.Size(266, 408);
            this.panel_rail.TabIndex = 7;
            this.panel_rail.Click += new System.EventHandler(this.panel_rail_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.panel_rail_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 307);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.panel_rail_Click);
            // 
            // panel_bus
            // 
            this.panel_bus.BackColor = System.Drawing.Color.Transparent;
            this.panel_bus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bus.Controls.Add(this.label2);
            this.panel_bus.Controls.Add(this.pictureBox2);
            this.panel_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bus.Location = new System.Drawing.Point(317, 27);
            this.panel_bus.Name = "panel_bus";
            this.panel_bus.Size = new System.Drawing.Size(266, 408);
            this.panel_bus.TabIndex = 6;
            this.panel_bus.Click += new System.EventHandler(this.panel_bus_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.panel_bus_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 307);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.panel_bus_Click);
            // 
            // panel_air
            // 
            this.panel_air.BackColor = System.Drawing.Color.Transparent;
            this.panel_air.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_air.Controls.Add(this.label1);
            this.panel_air.Controls.Add(this.pictureBox1);
            this.panel_air.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_air.Location = new System.Drawing.Point(26, 27);
            this.panel_air.Name = "panel_air";
            this.panel_air.Size = new System.Drawing.Size(266, 408);
            this.panel_air.TabIndex = 5;
            this.panel_air.Click += new System.EventHandler(this.panel_air_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Air";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.panel_air_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel_air_Click);
            // 
            // panel_B
            // 
            this.panel_B.Location = new System.Drawing.Point(317, 492);
            this.panel_B.Name = "panel_B";
            this.panel_B.Size = new System.Drawing.Size(266, 76);
            this.panel_B.TabIndex = 17;
            // 
            // panel_C
            // 
            this.panel_C.Location = new System.Drawing.Point(607, 490);
            this.panel_C.Name = "panel_C";
            this.panel_C.Size = new System.Drawing.Size(266, 75);
            this.panel_C.TabIndex = 17;
            // 
            // panel_A
            // 
            this.panel_A.Location = new System.Drawing.Point(26, 488);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(266, 80);
            this.panel_A.TabIndex = 16;
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.panel_background);
            this.Name = "Transport";
            this.Size = new System.Drawing.Size(756, 764);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.panel_rail_places.ResumeLayout(false);
            this.panel_rail_places.PerformLayout();
            this.panel_bus_places.ResumeLayout(false);
            this.groupBox_bus_ac.ResumeLayout(false);
            this.groupBox_bus_ac.PerformLayout();
            this.panel_air_places.ResumeLayout(false);
            this.panel_rail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_bus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_air.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Panel panel_rail_places;
        private System.Windows.Forms.ComboBox comboBox_railNames;
        private System.Windows.Forms.Panel panel_bus_places;
        private System.Windows.Forms.ComboBox comboBox_busNames;
        private System.Windows.Forms.Panel panel_air_places;
        private System.Windows.Forms.ComboBox comboBox_planeNames;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Panel panel_rail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_bus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_air;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_B;
        private System.Windows.Forms.Panel panel_C;
        private System.Windows.Forms.Panel panel_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_planeClass;
        private System.Windows.Forms.RadioButton radioButton_bus_nonAC;
        private System.Windows.Forms.RadioButton radioButton_bus_ac;
        private System.Windows.Forms.RadioButton radioButton_rail_nonAC;
        private System.Windows.Forms.RadioButton radioButton_rail_ac;
        private System.Windows.Forms.GroupBox groupBox_rail_ac;
        private System.Windows.Forms.GroupBox groupBox_bus_ac;
    }
}
