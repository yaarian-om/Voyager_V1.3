
namespace Voyager
{
    partial class UC_Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Hotel));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_single = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_suite = new System.Windows.Forms.Panel();
            this.button_next = new System.Windows.Forms.Button();
            this.panel_background = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.label_single_price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_single.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_suite.SuspendLayout();
            this.panel_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_single
            // 
            this.panel_single.BackColor = System.Drawing.Color.Transparent;
            this.panel_single.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_single.Controls.Add(this.label6);
            this.panel_single.Controls.Add(this.label_single_price);
            this.panel_single.Controls.Add(this.label1);
            this.panel_single.Controls.Add(this.pictureBox1);
            this.panel_single.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_single.Location = new System.Drawing.Point(39, 27);
            this.panel_single.Name = "panel_single";
            this.panel_single.Size = new System.Drawing.Size(312, 549);
            this.panel_single.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suite";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_suite
            // 
            this.panel_suite.BackColor = System.Drawing.Color.Transparent;
            this.panel_suite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_suite.Controls.Add(this.label5);
            this.panel_suite.Controls.Add(this.label3);
            this.panel_suite.Controls.Add(this.label2);
            this.panel_suite.Controls.Add(this.pictureBox2);
            this.panel_suite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_suite.Location = new System.Drawing.Point(423, 27);
            this.panel_suite.Name = "panel_suite";
            this.panel_suite.Size = new System.Drawing.Size(295, 549);
            this.panel_suite.TabIndex = 6;
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
            // 
            // panel_background
            // 
            this.panel_background.AutoScroll = true;
            this.panel_background.Controls.Add(this.panel_single);
            this.panel_background.Controls.Add(this.panel_suite);
            this.panel_background.Controls.Add(this.button_previous);
            this.panel_background.Controls.Add(this.button_next);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(756, 781);
            this.panel_background.TabIndex = 17;
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
            this.button_previous.TabIndex = 14;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            // 
            // label_single_price
            // 
            this.label_single_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_single_price.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_single_price.ForeColor = System.Drawing.Color.White;
            this.label_single_price.Location = new System.Drawing.Point(41, 387);
            this.label_single_price.Name = "label_single_price";
            this.label_single_price.Size = new System.Drawing.Size(222, 64);
            this.label_single_price.TabIndex = 3;
            this.label_single_price.Text = "2200";
            this.label_single_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "6000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "Per Night";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 47);
            this.label6.TabIndex = 5;
            this.label6.Text = "Per Night";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.panel_background);
            this.Name = "UC_Hotel";
            this.Size = new System.Drawing.Size(756, 781);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_single.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_suite.ResumeLayout(false);
            this.panel_background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_single;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_suite;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Label label_single_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
