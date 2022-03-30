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
    public partial class UC_Destination_Lakes : UserControl
    {

        private string sequence = "Destination";
        private string AERROW = " ⇒ ";
        private static string travelDestination = null;
        private static int travelPhotoIndex = -1;


        #region MY METHODS
        private void InitializeComponent2()
        {
            label_panelSequence.Text = sequence + AERROW + "Lakes";
            Utility.setAllButtonDefocusedExcept("destination");
            //hideAllPlacesPanel();
            setDefaultComboBoxOptionAndLock();
        }

        private void panelVisibility(Panel panel) { if (panel.Visible) { panel.Hide(); } else { panel.Show(); } }

        private void showSinglePanel(Panel Ref, Panel p1, Panel p2)
        {
            //p1.Height = Ref.Height;
            p1.Top = Ref.Top;
            p1.Left = Ref.Left;
            p1.BringToFront();
            p1.Show();
            p2.Hide();
        }

        private void hideAllPlacesPanel()
        {
            panel_bandarban_places.Hide();
            panel_shunamgonj_places.Hide();
        }

        private void setDefaultComboBoxOptionAndLock()
        {
            comboBox_bandarban.Enabled = false;
            comboBox_bandarban.SelectedIndex = 0;
            comboBox_shunamgonj.Enabled = false;
            comboBox_shunamgonj.SelectedIndex = 0;
        }

        private void setDefaultComboBoxOptionExcept(ComboBox cb)
        {
            if (cb == comboBox_bandarban)
            {
                comboBox_shunamgonj.SelectedIndex = 0;
            }
            else
            {
                comboBox_bandarban.SelectedIndex = 0;
            }
        }

        private void showTravelLocationPanel()
        {
            travelDestination = Tourist.TravelLocation;
            travelPhotoIndex = Tourist.TravelPhotoIndex;

            if (travelDestination == null)
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOptionAndLock();
                Console.WriteLine("Travel Location =  Null");
            }
            else if (travelDestination == "Bogakain Lake (Boga Lake)")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                comboBox_bandarban.SelectedItem = travelDestination;
                comboBox_bandarban.Enabled = false;
                showSinglePanel(panel_A, panel_bandarban_places, panel_shunamgonj_places);
                setDefaultComboBoxOptionExcept(comboBox_bandarban);
            }
            else if (travelDestination == "Niladri Lake")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                comboBox_shunamgonj.SelectedItem = travelDestination;
                comboBox_shunamgonj.Enabled = false;
                showSinglePanel(panel_B, panel_shunamgonj_places, panel_bandarban_places);
                setDefaultComboBoxOptionExcept(comboBox_shunamgonj);
            }
            else
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOptionAndLock();
            }

        }


        #endregion MY METHODS




        public UC_Destination_Lakes()
        {
            InitializeComponent();
            showTravelLocationPanel();
            InitializeComponent2();
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            UC_Destination ucd = new UC_Destination();
            ucd.AutoScroll = true;
            Utility.AddControlsToPanel(ucd);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_destination);
            Utility.setAllButtonDefocusedExcept("destination");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            UC_Transport transport = new UC_Transport();
            Utility.AddControlsToPanel(transport);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_transport);
            Utility.setAllButtonDefocusedExcept("transport");
        }

        private void panel_bandarban_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_A, panel_bandarban_places, panel_shunamgonj_places); // 1st parameter=>Referance_Panel, 2nd=>Highlighteed_Panel, 3rd~4th=>Hidden
            comboBox_bandarban.Enabled = false;
            Tourist.TravelLocation = "Bogakain Lake (Boga Lake)";
            Tourist.TravelPhotoIndex = 0;
            Console.WriteLine("Travel Location Stored");
            Tourist.Zilla = "Bandarban";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);
        }

        private void panel_shunamgonj_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_B, panel_shunamgonj_places, panel_bandarban_places); // 1st parameter=>Referance_Panel, 2nd=>Highlighteed_Panel, 3rd~4th=>Hidden
            comboBox_shunamgonj.Enabled = false;
            Tourist.TravelLocation = "Niladri Lake";
            Tourist.TravelPhotoIndex = 0;
            Console.WriteLine("Travel Location Stored");
            Tourist.Zilla = "Shunamgonj";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);
        }
    }
}
