using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager
{
    public partial class Dashboard : Form // Innheritance
    {
        #region ATTRIBUTES

        private string username;
        private string AERROW = " ⇒ ";
        //public static Color form_Navigation_PanelBackground = Color.FromArgb(64, 64, 64); // Setting The background Color For the Navigation Panel

        #endregion ATTRIBUTES

        #region MY_METHODS

        private void setUsername(string username)
        {
            this.username = username;
            label_username.Text = username;
        }

        private void current_Time_Date()
        {
            // To get The Current date and time (12 hour format)
            DateTime date = DateTime.Now;
            label_date.Text = date.ToString("F"); // Here we just showing the date. Otherwise the time will be stucked with the enter time, it won't update gradually
        }

        public void InitializeComponent2()
        {
            current_timer.Start();
            current_Time_Date();
            setNavigationPanelPosition(button_home);
            UC_Home uch = new UC_Home();
            Utility.AddControlsToPanel(uch,panelControls); // Do Not Change Here, It will Occur Errors
        }

        public void setNavigationPanelPosition(Button b)
        {
            panel_navigation.Height = b.Height;
            panel_navigation.Top = b.Top;
            panel_navigation.Left = b.Left;
            b.BackColor = Color.FromArgb(15, 14, 14); // This will mark the button with another color
            label_panelName.Text = b.Text;
        }
 
        public void AddControlsToPanel(Control c)
        {
            // Set The specific panel to the position where it will show up whenever that specific button will be clicked
            panelControls.Controls.Clear();
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Focus();
            panelControls.Controls.Add(c);
        }

        private void clearTravelInformation()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string travelDate = Tourist.TravelDate;
            string currentDate = dateTime.ToString("d"); //date = month/date/year
            Console.WriteLine("Current Date = " + currentDate);
            if(travelDate == currentDate)
            {
                // send Empty String to database
            }
        }





        #endregion MY_METHODS





        public Dashboard(string username)
        {
            InitializeComponent();
            InitializeComponent2();
            clearTravelInformation();
            setUsername(username);

        }




        #region FORM_ACTION_METHODS

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            /**
             * when we close any form then the full application will be terminated.
             * Otherwise it'll be running on the background and create issues to reopen the software
             */
            //System.Windows.Forms.Application.ExitThread();
            this.Dispose();
            Application.Exit();
        }

        private void current_timer_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
        }

        #region BUTTON CLICK

        private void button_home_Click(object sender, EventArgs e)
        {
            setNavigationPanelPosition(button_home);
            UC_Home uch = new UC_Home();
            Utility.UC_HOME = uch;
            AddControlsToPanel(uch);
            Utility.setAllButtonDefocusedExcept("home");
        }

        private void button_destination_Click(object sender, EventArgs e)
        {
            UC_Destination ucd = new UC_Destination();
            Utility.UC_DESTINATION = ucd;
            UC_Destination.destiny = ucd;
            AddControlsToPanel(ucd);
            setNavigationPanelPosition(button_destination);
        }

        private void button_transport_Click(object sender, EventArgs e)
        {
            setNavigationPanelPosition(button_transport);
            UC_Transport transport = new UC_Transport();
            AddControlsToPanel(transport);
            Utility.setAllButtonDefocusedExcept("transport");
        }

        private void button_hotel_Click(object sender, EventArgs e)
        {
            setNavigationPanelPosition(button_hotel);
            UC_Hotel uch = new UC_Hotel();
            AddControlsToPanel(uch);
            Utility.setAllButtonDefocusedExcept("hotel");
        }

        private void button_booking_Click(object sender, EventArgs e)
        {
            setNavigationPanelPosition(button_booking);
            Utility.setAllButtonDefocusedExcept("booking");
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            setNavigationPanelPosition(button_profile);
            Utility.setAllButtonDefocusedExcept("profile");
        }

        #endregion BUTTON CLICK

        #region BUTTON LEAVE

        private void button_home_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_home);
        }

        private void button_destination_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_destination);
        }

        private void button_transport_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_transport);
        }

        private void button_hotel_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_hotel);
        }

        private void button_booking_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_booking);
        }

        private void button_profile_Leave(object sender, EventArgs e)
        {
            Utility.buttonLeaveAnimation(button_profile);
        }

        #endregion BUTTON LEAVE

        #endregion FORM_ACTION_METHODS


    }
}
