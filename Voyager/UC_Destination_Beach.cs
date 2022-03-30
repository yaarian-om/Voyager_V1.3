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
    public partial class UC_Destination_Beach : UserControl
    {


        private string sequence = "Destination";
        private string AERROW = " ⇒ ";
        private static string travelDestination = null;
        private static int travelPhotoIndex = -1;
        public static UC_Destination DESTINATION;


        #region MY METHODS
        private void InitializeComponent2()
        {
            label_panelSequence.Text = sequence + AERROW + "Beach";
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
            panel_coxs_bazar_places.Hide();
            panel_patuakhali_places.Hide();
            panel_chittagong_places.Hide();
        }

        private void setDefaultComboBoxOption()
        {
            comboBox_chittagong.SelectedIndex = 0;
            comboBox_patuakhali.SelectedIndex = 0;
            comboBox_coxs_bazar.SelectedIndex = 0;
        }
        private void setDefaultComboBoxOptionExcept(ComboBox cb)
        {
            if(cb == comboBox_chittagong)
            {
                comboBox_patuakhali.SelectedIndex = 0;
                comboBox_coxs_bazar.SelectedIndex = 0;
            }
            else if (cb == comboBox_patuakhali)
            {
                comboBox_chittagong.SelectedIndex = 0;
                comboBox_coxs_bazar.SelectedIndex = 0;
            }
            else
            {
                comboBox_chittagong.SelectedIndex = 0;
                comboBox_patuakhali.SelectedIndex = 0;
            }
        }

        private void setComboBoxLock()
        {
            comboBox_patuakhali.Enabled = false;
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
            else if (travelDestination == "Cox's Bazar Beach" || travelDestination == "Inani Beach" || travelDestination == "ST. Martin's Island")
            {
                Console.WriteLine("Travel Location = "+travelDestination);
               
                showSinglePanel(panel_A, panel_coxs_bazar_places, panel_patuakhali_places, panel_chittagong_places);
                comboBox_coxs_bazar.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_coxs_bazar, travelPhotoIndex);
                setDefaultComboBoxOptionExcept(comboBox_coxs_bazar);
            }
            else if (travelDestination == "Kuakata Beach")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                
                comboBox_patuakhali.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_patuakhali, travelPhotoIndex);
                showSinglePanel(panel_B, panel_patuakhali_places, panel_coxs_bazar_places, panel_chittagong_places);
                setDefaultComboBoxOptionExcept(comboBox_patuakhali);
            }
            else if (travelDestination == "Patenga Sea Beach" || travelDestination == "Parki Beach")
            {
                Console.WriteLine("Travel Location = " + travelDestination);
                
                comboBox_chittagong.SelectedItem = travelDestination;
                setPlacePicture(pictureBox_chittagong, travelPhotoIndex);
                showSinglePanel(panel_C, panel_chittagong_places, panel_coxs_bazar_places, panel_patuakhali_places);
                setDefaultComboBoxOptionExcept(comboBox_chittagong);
            }
            else
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                setComboBoxLock();
            }


        }



        #endregion MY METHODS



        public UC_Destination_Beach()
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
            //Utility.AddControlsToPanel(transport, panel_background);
            Utility.AddControlsToPanel(transport);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_transport);// This Will Shift the Navigation panel to the button specified
            Utility.setAllButtonDefocusedExcept("transport");
        }

        private void panel_coxs_bazar_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_A, panel_coxs_bazar_places, panel_patuakhali_places, panel_chittagong_places); // 1st parameter=>Referance_Panel, 2nd=>Highlighteed_Panel, 3rd~4th=>Hidden
            setDefaultComboBoxOption();
        }

        private void panel_patuakhali_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_B, panel_patuakhali_places, panel_coxs_bazar_places, panel_chittagong_places);
            comboBox_patuakhali.Enabled = false;
            Tourist.TravelLocation = "Kuakata Beach";
            Tourist.TravelPhotoIndex = 0;
            setDefaultComboBoxOption();
            Tourist.Zilla = "Patuakhali";
            Console.WriteLine("Zilla Location = " + Tourist.Zilla);

        }

        private void panel_chittagong_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_C, panel_chittagong_places, panel_coxs_bazar_places, panel_patuakhali_places);
            setDefaultComboBoxOption();
        }

        private void comboBox_dhaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_coxs_bazar.SelectedItem == "Cox's Bazar Beach")
            {
                setPlacePicture(pictureBox_coxs_bazar, 0); // If the user selects Ahsan Manzeel then picture will be updated
                Tourist.TravelLocation = "Cox's Bazar Beach"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 0;
                Tourist.Zilla = "Cox's Bazar";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_coxs_bazar.SelectedItem == "Inani Beach")
            {
                setPlacePicture(pictureBox_coxs_bazar, 1);
                Tourist.TravelLocation = "Inani Beach";
                Tourist.TravelPhotoIndex = 1;
                Tourist.Zilla = "Cox's Bazar";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_coxs_bazar.SelectedItem == "ST. Martin's Island")
            {
                setPlacePicture(pictureBox_coxs_bazar, 2);
                Tourist.TravelLocation = "ST. Martin's Island";
                Tourist.TravelPhotoIndex = 2;
                Tourist.Zilla = "Cox's Bazar";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }

        private void comboBox_chittagong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chittagong.SelectedItem == "Patenga Sea Beach")
            {
                setPlacePicture(pictureBox_chittagong, 4); // If the user selects Ahsan Manzeel then picture will be updated
                Tourist.TravelLocation = "Patenga Sea Beach"; // Storing Tour places data
                Tourist.TravelPhotoIndex = 4;
                Tourist.Zilla = "Chittagong";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
            else if (comboBox_chittagong.SelectedItem == "Parki Beach")
            {
                setPlacePicture(pictureBox_chittagong, 5);
                Tourist.TravelLocation = "Parki Beach";
                Tourist.TravelPhotoIndex = 5;
                Tourist.Zilla = "Chittagong";
                Console.WriteLine("Zilla Location = " + Tourist.Zilla);
            }
        }
    }
}
