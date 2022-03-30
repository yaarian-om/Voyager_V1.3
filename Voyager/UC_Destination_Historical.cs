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
    public partial class UC_Destination_Historical : UserControl
    {

        private string sequence = "Destination";
        private string AERROW = " ⇒ ";
        private static string travelDestination = null;
        private static int travelPhotoIndex = -1;
        public static UC_Destination DESTINATION;


        #region MY METHODS
        private void InitializeComponent2()
        {
            label_panelSequence.Text = sequence + AERROW + "Historical";
            Utility.setAllButtonDefocusedExcept("destination");
            //hideAllPlacesPanel();
            //setDefaultComboBoxOption();
            setComboBoxLock();
        }

        private void setPlacePicture(PictureBox pictureBox, int pos)
        {
            pictureBox.Image = imageList_places.Images[pos];
        }

        private void panelVisibility(Panel panel) { if (panel.Visible) { panel.Hide(); } else { panel.Show(); } }

        private void showSinglePanel(Panel Ref, Panel p1, Panel p2, Panel p3)
        {
            //p1.Height = Ref.Height;
            p1.Top = Ref.Top;
            p1.Left = Ref.Left;
            p1.BringToFront();
            p1.Show();
            p2.Hide();
            p3.Hide();
            
        }

        private void hideAllPlacesPanel()
        {
            panel_dhaka_places.Hide();
            panel_cumilla_places.Hide();
            panel_bogra_places.Hide();
        }

        private void setDefaultComboBoxOption()
        {
            comboBox_dhaka.SelectedIndex = 0;
            comboBox_cumilla.SelectedIndex = 0;
            comboBox_bogra.SelectedIndex = 0;
        }

        private void setComboBoxLock()
        {
            comboBox_cumilla.Enabled = false;
            comboBox_bogra.Enabled = false;
        }


        private void setDefaultComboBoxOptionExcept(ComboBox cb)
        {
            if (cb == comboBox_dhaka)
            {
                comboBox_cumilla.SelectedIndex = 0;
                comboBox_bogra.SelectedIndex = 0;
            }
            else if (cb == comboBox_cumilla)
            {
                comboBox_dhaka.SelectedIndex = 0;
                comboBox_bogra.SelectedIndex = 0;
            }
            else
            {
                comboBox_dhaka.SelectedIndex = 0;
                comboBox_cumilla.SelectedIndex = 0;
            }
        }





        private void showTravelLocationPanel()
        {
         
            travelDestination = Tourist.TravelLocation;
            travelPhotoIndex = Tourist.TravelPhotoIndex;
            if (travelDestination == null)
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                setComboBoxLock();
                Console.WriteLine("Travel Location =  Null");

            }
            else if (travelDestination == "Ahsan Manzeel" || travelDestination == "Labagh Fort")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                showSinglePanel(panel_A, panel_dhaka_places, panel_cumilla_places, panel_bogra_places);
                comboBox_dhaka.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_dhaka, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_dhaka);
            }
            else if (travelDestination == "Mynamati")
            {
                comboBox_cumilla.Enabled = false;
                comboBox_cumilla.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_cumilla, travelPhotoIndex);
                showSinglePanel(panel_B, panel_cumilla_places, panel_dhaka_places, panel_bogra_places);
                setDefaultComboBoxOptionExcept(comboBox_cumilla);
            }
            else if (travelDestination == "Mahasthangarh")
            {
                comboBox_bogra.Enabled = false;
                showSinglePanel(panel_C, panel_bogra_places, panel_dhaka_places, panel_cumilla_places);
                comboBox_bogra.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_bogra, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_bogra);
            }
            else
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                setComboBoxLock();
            }


        }





        #endregion MY METHODS

        public UC_Destination_Historical()
        {
            InitializeComponent();
            showTravelLocationPanel();
            InitializeComponent2();

        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            UC_Destination ucd = new UC_Destination();
            Utility.AddControlsToPanel(ucd);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_destination);// This Will Shift the Navigation panel to the button specified
            Utility.setAllButtonDefocusedExcept("destination");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            UC_Transport transport = new UC_Transport();
            Utility.AddControlsToPanel(transport);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_transport);// This Will Shift the Navigation panel to the button specified
            Utility.setAllButtonDefocusedExcept("transport");
        }

        private void panel_dhaka_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_A, panel_dhaka_places, panel_cumilla_places, panel_bogra_places); // 1st parameter=>Referance_Panel, 2nd=>Highlighteed_Panel, 3rd~4th=>Hidden
        }

        private void panel_cumilla_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_B, panel_cumilla_places, panel_dhaka_places, panel_bogra_places);
            Tourist.TravelLocation = "Mynamati";
            Tourist.TravelPhotoIndex = 0;
            Tourist.Zilla = "Comilla";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);
        }

        private void panel_bogra_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_C, panel_bogra_places, panel_dhaka_places, panel_cumilla_places);
            Tourist.TravelLocation = "Mahasthangarh";
            Tourist.TravelPhotoIndex = 0;
            Tourist.Zilla = "Bogra";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);
        }


        private void comboBox_dhaka_SelectedIndexChanged(object sender, EventArgs e) // It will be performed when any user change any option, by Default none
        {
            if (comboBox_dhaka.SelectedItem == "Ahsan Manzeel")
            {
                setPlacePicture(pictureBox_dhaka, 0); // If the user selects Ahsan Manzeel then picture will be updated
                Tourist.TravelLocation = "Ahsan Manzeel"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 0;
                Tourist.Zilla = "Dhaka";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_dhaka.SelectedItem == "Labagh Fort")
            {
                setPlacePicture(pictureBox_dhaka, 1);
                Tourist.TravelLocation = "Labagh Fort";
                Tourist.TravelPhotoIndex = 1;
                Tourist.Zilla = "Dhaka";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }
    }
}
