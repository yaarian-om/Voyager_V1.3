using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager
{
    class Utility
    {

        public static Dashboard DASHBOARD;
        public static Login LOGIN;
        public static UC_Transport TRANSPORT;
        public static UC_Home UC_HOME;
        public static UC_Destination UC_DESTINATION;
        public static UC_Destination_HillSide UC_DESTINATION_HILLSIDE;
        public static UC_Destination_Historical UC_DESTINATION_HISTORICAL;
        public static UC_Destination_Beach UC_DESTINATION_BEACH;
        public static UC_Destination_Lakes UC_DESTINATION_LAKES;
        public static Color form_Navigation_PanelBackground = Color.FromArgb(64, 64, 64); // Setting The background Color For the Navigation Panel


        public static void AddControlsToPanel(System.Windows.Forms.Control c, System.Windows.Forms.Control panelControls) // Do Not Change Here, It will Occur Errors
        {
            // Set The specific panel to the position where it will show up whenever that specific button will be clicked
            panelControls.Controls.Clear();
            c.Dock = DockStyle.Fill;
            panelControls.BringToFront();
            panelControls.Focus();
            panelControls.Controls.Add(c);
        }

        public static void setNavigationPanelPosition(Button b)
        {
            DASHBOARD.panel_navigation.Height = b.Height;
            DASHBOARD.panel_navigation.Top = b.Top;
            DASHBOARD.panel_navigation.Left = b.Left;
            b.BackColor = Color.FromArgb(15, 14, 14); // This will mark the button with another color
            DASHBOARD.label_panelName.Text = b.Text;
        }

        public static void AddControlsToPanel(Control c)
        {
            // Set The specific panel to the position where it will show up whenever that specific button will be clicked
            DASHBOARD.panelControls.Controls.Clear();
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Focus();
            DASHBOARD.panelControls.Controls.Add(c);
        }

        public static void buttonLeaveAnimation(Button b)
        {
            b.BackColor = form_Navigation_PanelBackground; // When user clicks another button then the highlight of that button will be off and get back to the previous color
        }

        public static void setAllButtonDefocusedExcept(string buttonName)
        {
            if(buttonName == "home")
            {
                buttonLeaveAnimation(DASHBOARD.button_booking);
                buttonLeaveAnimation(DASHBOARD.button_destination);
                buttonLeaveAnimation(DASHBOARD.button_hotel);
                buttonLeaveAnimation(DASHBOARD.button_profile);
                buttonLeaveAnimation(DASHBOARD.button_transport);
            }
            else if(buttonName == "destination")
            {
                buttonLeaveAnimation(DASHBOARD.button_booking);
                buttonLeaveAnimation(DASHBOARD.button_home);
                buttonLeaveAnimation(DASHBOARD.button_hotel);
                buttonLeaveAnimation(DASHBOARD.button_profile);
                buttonLeaveAnimation(DASHBOARD.button_transport);
            }
            else if (buttonName == "transport")
            {
                buttonLeaveAnimation(DASHBOARD.button_booking);
                buttonLeaveAnimation(DASHBOARD.button_home);
                buttonLeaveAnimation(DASHBOARD.button_hotel);
                buttonLeaveAnimation(DASHBOARD.button_profile);
                buttonLeaveAnimation(DASHBOARD.button_destination);
            }
            else if (buttonName == "hotel")
            {
                buttonLeaveAnimation(DASHBOARD.button_transport);
                buttonLeaveAnimation(DASHBOARD.button_home);
                buttonLeaveAnimation(DASHBOARD.button_booking);
                buttonLeaveAnimation(DASHBOARD.button_profile);
                buttonLeaveAnimation(DASHBOARD.button_destination);
            }
            else if (buttonName == "booking")
            {
                buttonLeaveAnimation(DASHBOARD.button_transport);
                buttonLeaveAnimation(DASHBOARD.button_home);
                buttonLeaveAnimation(DASHBOARD.button_hotel);
                buttonLeaveAnimation(DASHBOARD.button_profile);
                buttonLeaveAnimation(DASHBOARD.button_destination);
            }
            else if (buttonName == "profile")
            {
                buttonLeaveAnimation(DASHBOARD.button_transport);
                buttonLeaveAnimation(DASHBOARD.button_home);
                buttonLeaveAnimation(DASHBOARD.button_booking);
                buttonLeaveAnimation(DASHBOARD.button_hotel);
                buttonLeaveAnimation(DASHBOARD.button_destination);
            }

        }



    }
}
