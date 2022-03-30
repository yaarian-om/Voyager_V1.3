
namespace Voyager
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_booking = new System.Windows.Forms.Button();
            this.button_hotel = new System.Windows.Forms.Button();
            this.button_transport = new System.Windows.Forms.Button();
            this.button_destination = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel_userinfo = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.current_timer = new System.Windows.Forms.Timer(this.components);
            this.label_panelName = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.panel_userinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.panel_navigation);
            this.panel_left.Controls.Add(this.button_profile);
            this.panel_left.Controls.Add(this.button_booking);
            this.panel_left.Controls.Add(this.button_hotel);
            this.panel_left.Controls.Add(this.button_transport);
            this.panel_left.Controls.Add(this.button_destination);
            this.panel_left.Controls.Add(this.button_home);
            this.panel_left.Controls.Add(this.panel_userinfo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(214, 846);
            this.panel_left.TabIndex = 0;
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_navigation.Location = new System.Drawing.Point(3, 255);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(3, 86);
            this.panel_navigation.TabIndex = 5;
            // 
            // button_profile
            // 
            this.button_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_profile.FlatAppearance.BorderSize = 0;
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.ForeColor = System.Drawing.Color.White;
            this.button_profile.Image = ((System.Drawing.Image)(resources.GetObject("button_profile.Image")));
            this.button_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_profile.Location = new System.Drawing.Point(0, 778);
            this.button_profile.Name = "button_profile";
            this.button_profile.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_profile.Size = new System.Drawing.Size(214, 68);
            this.button_profile.TabIndex = 6;
            this.button_profile.Text = "Profile";
            this.button_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            this.button_profile.Leave += new System.EventHandler(this.button_profile_Leave);
            // 
            // button_booking
            // 
            this.button_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_booking.FlatAppearance.BorderSize = 0;
            this.button_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_booking.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_booking.ForeColor = System.Drawing.Color.White;
            this.button_booking.Image = ((System.Drawing.Image)(resources.GetObject("button_booking.Image")));
            this.button_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_booking.Location = new System.Drawing.Point(0, 599);
            this.button_booking.Name = "button_booking";
            this.button_booking.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_booking.Size = new System.Drawing.Size(214, 86);
            this.button_booking.TabIndex = 5;
            this.button_booking.Text = "Booking";
            this.button_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_booking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_booking.UseVisualStyleBackColor = false;
            this.button_booking.Click += new System.EventHandler(this.button_booking_Click);
            this.button_booking.Leave += new System.EventHandler(this.button_booking_Leave);
            // 
            // button_hotel
            // 
            this.button_hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hotel.FlatAppearance.BorderSize = 0;
            this.button_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hotel.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hotel.ForeColor = System.Drawing.Color.White;
            this.button_hotel.Image = ((System.Drawing.Image)(resources.GetObject("button_hotel.Image")));
            this.button_hotel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hotel.Location = new System.Drawing.Point(0, 513);
            this.button_hotel.Name = "button_hotel";
            this.button_hotel.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_hotel.Size = new System.Drawing.Size(214, 86);
            this.button_hotel.TabIndex = 4;
            this.button_hotel.Text = "Hotel";
            this.button_hotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hotel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_hotel.UseVisualStyleBackColor = false;
            this.button_hotel.Click += new System.EventHandler(this.button_hotel_Click);
            this.button_hotel.Leave += new System.EventHandler(this.button_hotel_Leave);
            // 
            // button_transport
            // 
            this.button_transport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_transport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_transport.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_transport.FlatAppearance.BorderSize = 0;
            this.button_transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_transport.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_transport.ForeColor = System.Drawing.Color.White;
            this.button_transport.Image = ((System.Drawing.Image)(resources.GetObject("button_transport.Image")));
            this.button_transport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_transport.Location = new System.Drawing.Point(0, 427);
            this.button_transport.Name = "button_transport";
            this.button_transport.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_transport.Size = new System.Drawing.Size(214, 86);
            this.button_transport.TabIndex = 3;
            this.button_transport.Text = "Transport";
            this.button_transport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_transport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_transport.UseVisualStyleBackColor = false;
            this.button_transport.Click += new System.EventHandler(this.button_transport_Click);
            this.button_transport.Leave += new System.EventHandler(this.button_transport_Leave);
            // 
            // button_destination
            // 
            this.button_destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_destination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_destination.FlatAppearance.BorderSize = 0;
            this.button_destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_destination.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_destination.ForeColor = System.Drawing.Color.White;
            this.button_destination.Image = ((System.Drawing.Image)(resources.GetObject("button_destination.Image")));
            this.button_destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_destination.Location = new System.Drawing.Point(0, 341);
            this.button_destination.Name = "button_destination";
            this.button_destination.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_destination.Size = new System.Drawing.Size(214, 86);
            this.button_destination.TabIndex = 2;
            this.button_destination.Text = "Destination";
            this.button_destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_destination.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_destination.UseVisualStyleBackColor = false;
            this.button_destination.Click += new System.EventHandler(this.button_destination_Click);
            this.button_destination.Leave += new System.EventHandler(this.button_destination_Leave);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_home.Location = new System.Drawing.Point(0, 255);
            this.button_home.Name = "button_home";
            this.button_home.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.button_home.Size = new System.Drawing.Size(214, 86);
            this.button_home.TabIndex = 1;
            this.button_home.Text = "Home";
            this.button_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            this.button_home.Leave += new System.EventHandler(this.button_home_Leave);
            // 
            // panel_userinfo
            // 
            this.panel_userinfo.Controls.Add(this.label_username);
            this.panel_userinfo.Controls.Add(this.label_date);
            this.panel_userinfo.Controls.Add(this.label_time);
            this.panel_userinfo.Controls.Add(this.pictureBox_user);
            this.panel_userinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_userinfo.Location = new System.Drawing.Point(0, 0);
            this.panel_userinfo.Name = "panel_userinfo";
            this.panel_userinfo.Size = new System.Drawing.Size(214, 255);
            this.panel_userinfo.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_username.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(0, 178);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(214, 26);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_date.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(0, 204);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(214, 26);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_time.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(0, 230);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(214, 25);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "Time";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.Image")));
            this.pictureBox_user.Location = new System.Drawing.Point(45, 35);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(115, 123);
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
            // 
            // current_timer
            // 
            this.current_timer.Enabled = true;
            this.current_timer.Tick += new System.EventHandler(this.current_timer_Tick);
            // 
            // label_panelName
            // 
            this.label_panelName.BackColor = System.Drawing.Color.Transparent;
            this.label_panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_panelName.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_panelName.ForeColor = System.Drawing.Color.White;
            this.label_panelName.Location = new System.Drawing.Point(214, 0);
            this.label_panelName.Name = "label_panelName";
            this.label_panelName.Size = new System.Drawing.Size(756, 65);
            this.label_panelName.TabIndex = 1;
            this.label_panelName.Text = "Panel Name";
            this.label_panelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(214, 65);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(756, 781);
            this.panelControls.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(970, 846);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.label_panelName);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel_left.ResumeLayout(false);
            this.panel_userinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_userinfo;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        public System.Windows.Forms.Button button_home;
        public System.Windows.Forms.Button button_profile;
        public System.Windows.Forms.Button button_booking;
        public System.Windows.Forms.Button button_hotel;
        public System.Windows.Forms.Button button_transport;
        public System.Windows.Forms.Button button_destination;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Timer current_timer;
        public System.Windows.Forms.Panel panel_navigation;
        public System.Windows.Forms.Label label_panelName;
        public System.Windows.Forms.Panel panelControls;
    }
}