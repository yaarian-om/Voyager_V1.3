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
    public partial class UC_Destination_HillSide : UserControl
    {

        private string sequence = "Destination";
        private string AERROW = " ⇒ ";
        private static string travelDestination = null;
        private static int travelPhotoIndex = -1;

        #region MY METHODS

        private void InitializeComponent2()
        {
            //panelControls.AutoScroll = false;
            label_panelSequence.Text = sequence + AERROW + "Hill Station";
            Utility.setAllButtonDefocusedExcept("destination");
            //hideAllPlacesPanel();
            //setDefaultComboBoxOption();
            //setComboBoxLock();
        }
        private void setPlacePicture(PictureBox pictureBox, int pos)
        {
            pictureBox.Image = imageList_places.Images[pos];
        }

        private void panelVisibility(Panel panel){ if ( panel.Visible){panel.Hide(); } else{ panel.Show(); } }

        private void showSinglePanel(Panel Ref,Panel p1, Panel p2, Panel p3, Panel p4)
        {
            //p1.Height = Ref.Height;
            p1.Top = Ref.Top;
            p1.Left = Ref.Left;
            p1.BringToFront();
            p1.Show();
            p2.Hide();
            p3.Hide();
            p4.Hide();
        }

        private void hideAllPlacesPanel()
        {
            panel_bandarban_places.Hide();
            panel_sylhet_places.Hide();
            panel_rangamati_places.Hide();
            panel_netrokona_places.Hide();
        }

        private void setDefaultComboBoxOption()
        {
            comboBox_bandarban.SelectedIndex = 0;
            comboBox_rangamati.SelectedIndex = 0;
            comboBox_sylhet.SelectedIndex = 0;
            comboBox_netrokona.SelectedIndex = 0;
        }

        private void setComboBoxLock()
        {
            comboBox_netrokona.Enabled = false;
        }

        private void setDefaultComboBoxOptionExcept(ComboBox cb)
        {
            if (cb == comboBox_bandarban)
            {
                comboBox_sylhet.SelectedIndex = 0;
                comboBox_rangamati.SelectedIndex = 0;
                comboBox_netrokona.SelectedIndex = 0;
            }
            else if (cb == comboBox_sylhet)
            {
                comboBox_bandarban.SelectedIndex = 0;
                comboBox_rangamati.SelectedIndex = 0;
                comboBox_netrokona.SelectedIndex = 0;
            }
            else if (cb == comboBox_rangamati)
            {
                comboBox_bandarban.SelectedIndex = 0;
                comboBox_sylhet.SelectedIndex = 0;
                comboBox_netrokona.SelectedIndex = 0;
            }
            else
            {
                comboBox_bandarban.SelectedIndex = 0;
                comboBox_rangamati.SelectedIndex = 0;
                comboBox_sylhet.SelectedIndex = 0;
            }
        }

        private void showTravelLocationPanel()
        {
           
            travelDestination = Tourist.TravelLocation;
            travelPhotoIndex = Tourist.TravelPhotoIndex;
            int nameIndex = -1;
            if (travelDestination == null)
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                setComboBoxLock();
                Console.WriteLine("Travel Location =  Null");

            }
            else if (travelDestination == "Nil Giri" || travelDestination == "Thanchi" || travelDestination == "Nilachal")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                showSinglePanel(panel_A, panel_bandarban_places, panel_sylhet_places, panel_rangamati_places,panel_netrokona_places);
                comboBox_bandarban.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_bandarban, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_bandarban);
            }
            else if (travelDestination == "Bichanakandi" || travelDestination == "Jaflong")
            {
                comboBox_sylhet.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_sylhet, travelPhotoIndex);
                showSinglePanel(panel_B, panel_sylhet_places, panel_bandarban_places, panel_rangamati_places, panel_netrokona_places);
                setDefaultComboBoxOptionExcept(comboBox_sylhet);
            }
            else if (travelDestination == "Sajek" || travelDestination == "Shuvolong Waterfalls")
            {
                showSinglePanel(panel_C, panel_rangamati_places, panel_bandarban_places, panel_sylhet_places, panel_netrokona_places);
                comboBox_rangamati.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_rangamati, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_rangamati);
            }
            else if (travelDestination == "Birishiri")
            {
                comboBox_netrokona.Enabled = false;
                showSinglePanel(panel_D, panel_netrokona_places, panel_bandarban_places, panel_sylhet_places, panel_rangamati_places);
                comboBox_netrokona.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_netrokona, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_netrokona);
            }
            else
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                setComboBoxLock();
            }


        }

        #endregion MY METHODS

        public UC_Destination_HillSide()
        {
            InitializeComponent();
            showTravelLocationPanel();
            InitializeComponent2();
        }

        private void panel_bandarban_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_A,panel_bandarban_places, panel_sylhet_places,panel_rangamati_places,panel_netrokona_places); // 1st parameter=>Referance_Panel, 2nd=>Highlighteed_Panel, 3rd~5th=>Hidden
        }

        private void panel_sylhet_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_B,panel_sylhet_places, panel_bandarban_places, panel_rangamati_places, panel_netrokona_places);
        }

        private void panel_rangamati_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_C,panel_rangamati_places, panel_sylhet_places, panel_bandarban_places, panel_netrokona_places);
        }

        private void panel_netrokona_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_D,panel_netrokona_places, panel_rangamati_places, panel_sylhet_places, panel_bandarban_places);
            Tourist.TravelLocation = "Birishiri";
            Tourist.TravelPhotoIndex = 0;
            Tourist.Zilla = "Netrokona";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);
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

        private void comboBox_bandarban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_bandarban.SelectedItem == "Nil Giri")
            {
                setPlacePicture(pictureBox_bandarban, 3); // If the user selects Ahsan Manzeel then picture will be updated
                Tourist.TravelLocation = "Nil Giri"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 3;
                Tourist.Zilla = "Bandarban";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_bandarban.SelectedItem == "Thanchi")
            {
                setPlacePicture(pictureBox_bandarban, 6);
                Tourist.TravelLocation = "Thanchi";
                Tourist.TravelPhotoIndex = 6;
                Tourist.Zilla = "Bandarban";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_bandarban.SelectedItem == "Nilachal")
            {
                setPlacePicture(pictureBox_bandarban, 2);
                Tourist.TravelLocation = "Nilachal";
                Tourist.TravelPhotoIndex = 2;
                Tourist.Zilla = "Bandarban";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }

        private void comboBox_sylhet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_sylhet.SelectedItem == "Bichanakandi")
            {
                setPlacePicture(pictureBox_sylhet, 0); // If the user selects any place then picture will be updated
                Tourist.TravelLocation = "Bichanakandi"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 0;
                Tourist.Zilla = "Sylhet";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_sylhet.SelectedItem == "Jaflong")
            {
                setPlacePicture(pictureBox_sylhet, 1);
                Tourist.TravelLocation = "Jaflong";
                Tourist.TravelPhotoIndex = 1;
                Tourist.Zilla = "Sylhet";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }

        private void comboBox_rangamati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rangamati.SelectedItem == "Sajek")
            {
                setPlacePicture(pictureBox_rangamati, 4); // If the user selects any place then picture will be updated
                Tourist.TravelLocation = "Sajek"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 4;
                Tourist.Zilla = "Rangamati";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_rangamati.SelectedItem == "Shuvolong Waterfalls")
            {
                setPlacePicture(pictureBox_rangamati, 5);
                Tourist.TravelLocation = "Shuvolong Waterfalls";
                Tourist.TravelPhotoIndex = 5;
                Tourist.Zilla = "Rangamati";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }


    }
}
