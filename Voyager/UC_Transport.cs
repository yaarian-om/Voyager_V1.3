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
    public partial class UC_Transport : UserControl
    {

        private static string vehicleName;
        private static string planeClass;
        


        #region My Methods
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
            panel_air_places.Hide();
            panel_bus_places.Hide();
            panel_rail_places.Hide();
        }

        private void setDefaultComboBoxOption()
        {
            comboBox_planeNames.SelectedIndex = 0;
            comboBox_planeClass.SelectedIndex = 0;
            comboBox_planeClass.Enabled = false;
            comboBox_busNames.SelectedIndex = 0;
            comboBox_railNames.SelectedIndex = 0;
            groupBox_bus_ac.Enabled = false;
            groupBox_rail_ac.Enabled = false;
            //radioButton_bus_ac.Checked = true;
            //radioButton_rail_ac.Checked = true;
        }

        private void setDefaultComboBoxOptionExcept(ComboBox cb)
        {
            if (cb == comboBox_railNames)
            {
                comboBox_busNames.SelectedIndex = 0;
                comboBox_planeNames.SelectedIndex = 0;
                comboBox_planeClass.SelectedIndex = 0;
                if(Tourist.RailAC == true)
                {
                    radioButton_rail_ac.Checked = true;
                }
                else
                {
                    radioButton_rail_nonAC.Checked = true;
                }
            }
            else if (cb == comboBox_busNames)
            {
                comboBox_railNames.SelectedIndex = 0;
                comboBox_planeNames.SelectedIndex = 0;
                comboBox_planeClass.SelectedIndex = 0;
                if (Tourist.BusAC == true)
                {
                    radioButton_bus_ac.Checked = true;
                }
                else
                {
                    radioButton_bus_nonAC.Checked = true;
                }
            }
            else
            {
                comboBox_railNames.SelectedIndex = 0;
                comboBox_busNames.SelectedIndex = 0;
            }
        }

        private void comboBox_air_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_planeNames.SelectedItem == "Biman Bangladesh Airlines")
            {
                Tourist.VehicleName = "Biman Bangladesh Airlines"; // Storing Tour places data
                //Console.WriteLine("Vehicle Name = "+ Tourist.VehicleName);
                comboBox_planeClass.Enabled = true;
                //label_cost.Text = Convert.ToString(Transport.cost);
                Tourist.VehicleName = "Biman Bangladesh Airlines";
            }
            else if (comboBox_planeNames.SelectedItem == "Novoair")
            {
                Tourist.VehicleName = "Novoair";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                comboBox_planeClass.Enabled = true;
                //label_cost.Text = Convert.ToString(Transport.cost);
                Tourist.VehicleName = "Novoair";
            }
            else if (comboBox_planeNames.SelectedItem == "Regent Airways")
            {
                Tourist.VehicleName = "Regent Airways";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                comboBox_planeClass.Enabled = true;
                //label_cost.Text = Convert.ToString(Transport.cost);
                Tourist.VehicleName = "Regent Airways";
            }
            else if (comboBox_planeNames.SelectedItem == "US-Bangla Airlines")
            {
                Tourist.VehicleName = "US-Bangla Airlines";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                comboBox_planeClass.Enabled = true;
                //label_cost.Text = Convert.ToString(Transport.cost);
                Tourist.VehicleName = "US-Bangla Airlines";
            }
        }

        private void comboBox_planeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_planeClass.SelectedItem == "First Class")
            {
                Tourist.VehicleClass = "Biman Bangladesh Airlines"; // Storing Tour places data
                //Console.WriteLine("Vehicle Class = " + Tourist.VehicleClass);
                string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, true, "First Class",false,false,false);
                Console.WriteLine("Vehicle Cost = " + vehicleCost);
                label_cost.Text = vehicleCost;
                Tourist.VehicleClass = "First Class";
            }
            else if (comboBox_planeClass.SelectedItem == "Business Class")
            {
                Tourist.VehicleClass = "Business Class";
                //Console.WriteLine("Vehicle Class = " + Tourist.VehicleClass);
                string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, true, "Business Class", false, false, false);
                Console.WriteLine("Vehicle Cost = " + vehicleCost);
                label_cost.Text = vehicleCost;
            }
            else if (comboBox_planeClass.SelectedItem == "Economy Class")
            {
                Tourist.VehicleClass = "Economy Class";
                //Console.WriteLine("Vehicle Class = " + Tourist.VehicleClass);
                string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, true, "Economy Class", false, false, false);
                Console.WriteLine("Vehicle Cost = " + vehicleCost);
                label_cost.Text = vehicleCost;
            }
        }

        private void comboBox_busNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_busNames.SelectedItem == "Green Line")
            {
                Tourist.VehicleName = "Green Line"; // Storing Tour places data
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
            else if (comboBox_busNames.SelectedItem == "Desh Travels")
            {
                Tourist.VehicleName = "Desh Travels";
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
            else if (comboBox_busNames.SelectedItem == "Shohagh Paribahan")
            {
                Tourist.VehicleName = "Shohagh Paribahan";
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
            else if (comboBox_busNames.SelectedItem == "Soudia Coach Service")
            {
                Tourist.VehicleName = "Soudia Coach Service";
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
            else if (comboBox_busNames.SelectedItem == "Shyamoli Paribahan")
            {
                Tourist.VehicleName = "Shyamoli Paribahan";
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
            else if (comboBox_busNames.SelectedItem == "Royal Coach")
            {
                Tourist.VehicleName = "Royal Coach";
                //Console.WriteLine("VehicleClass = " + Tourist.VehicleName);
                groupBox_bus_ac.Enabled = true;
            }
        }

        private void comboBox_railNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_railNames.SelectedItem == "Sonar Bangla")
            {
                Tourist.VehicleName = "Sonar Bangla"; // Storing Tour places data
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Kalani Express")
            {
                Tourist.VehicleName = "Kalani Express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Chattala Express")
            {
                Tourist.VehicleName = "Chattala Express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Hawr express")
            {
                Tourist.VehicleName = "Hawr express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Upoban Express")
            {
                Tourist.VehicleName = "Upoban Express";
                // Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Mohanogor Provati Express")
            {
                Tourist.VehicleName = "Mohanogor Provati Express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Parbat Express")
            {
                Tourist.VehicleName = "Parbat Express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Sonar Bangla Express")
            {
                Tourist.VehicleName = "Sonar Bangla Express";
                // Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
            else if (comboBox_railNames.SelectedItem == "Joyontika Express")
            {
                Tourist.VehicleName = "Joyontika Express";
                //Console.WriteLine("Vehicle Name = " + Tourist.VehicleName);
                groupBox_rail_ac.Enabled = true;
            }
        }

        private void showVehiclePanel()
        {

            vehicleName = Tourist.VehicleName;
            planeClass = Tourist.VehicleClass;
            
            if (vehicleName == null)
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
                Console.WriteLine("Vehicle Name =  Null");

            }
            else if (vehicleName == "Biman Bangladesh Airlines" || vehicleName == "Novoair" || 
                     vehicleName == "Regent Airways" || vehicleName == "US-Bangla Airlines")
            {
                // AIR
                Console.WriteLine("Vehicle Name = " + vehicleName);
                Console.WriteLine("Plane Class = " + planeClass);
                showSinglePanel(panel_A, panel_air_places, panel_bus_places, panel_rail_places);
                comboBox_planeNames.SelectedItem = vehicleName;
                comboBox_planeClass.SelectedItem = planeClass;
                setDefaultComboBoxOptionExcept(comboBox_planeNames);
            }
            else if (vehicleName == "Green Line" || vehicleName == "Desh Travels" || 
                     vehicleName == "Shohagh Paribahan" || vehicleName == "Soudia Coach Service" || 
                     vehicleName == "Shyamoli Paribahan" || vehicleName == "Royal Coach")
            {
                // BUS
                Console.WriteLine("Vehicle Name = " + vehicleName);
                comboBox_busNames.SelectedItem = vehicleName;
                showSinglePanel(panel_B, panel_bus_places, panel_air_places, panel_rail_places);
                setDefaultComboBoxOptionExcept(comboBox_busNames);
            }
            else if (vehicleName == "Sonar Bangla" || vehicleName == "Kalani Express" || vehicleName == "Chattala Express"
                        || vehicleName == "Hawr express" || vehicleName == "Upoban Express" || vehicleName == "Mohanogor Provati Express"
                        || vehicleName == "Parbat Express" || vehicleName == "Sonar Bangla Express" || vehicleName == "Joyontika Express")
            {
                // RAIL
                Console.WriteLine("Vehicle Name = " + vehicleName);
                comboBox_railNames.SelectedItem = vehicleName;
                showSinglePanel(panel_C, panel_rail_places, panel_air_places, panel_bus_places);
                setDefaultComboBoxOptionExcept(comboBox_railNames);
            }
            else
            {
                hideAllPlacesPanel();
                setDefaultComboBoxOption();
            }

        }

        private void vehicleLockDecision(string zillaName)
        {
            if (zillaName == "Rangamati")
            {
                panel_air.Enabled = false;
                panel_air_places.Enabled = false;
                panel_rail.Enabled = false;
                panel_rail_places.Enabled = false;
                label_cost.Text = "";
            }
            else if(zillaName == "Netrokona")
            {
                panel_air.Enabled = false;
                panel_air_places.Enabled = false;
                label_cost.Text = "";
            }
            else if (zillaName == "Dhaka")
            {
                panel_air.Enabled = false;
                panel_air_places.Enabled = false;
                panel_rail.Enabled = false;
                panel_rail_places.Enabled = false;
                label_cost.Text = "";
            }
            else if (zillaName == "Cox's Bazar")
            {
                panel_rail.Enabled = false;
                panel_rail_places.Enabled = false;
                label_cost.Text = "";
            }
            else if (zillaName == "Patuakhali")
            {
                panel_rail.Enabled = false;
                panel_rail_places.Enabled = false;
                label_cost.Text = "";
            }
            else if (zillaName == "Shunamgonj")
            {
                panel_air.Enabled = false;
                panel_air_places.Enabled = false;
                panel_rail.Enabled = false;
                panel_rail_places.Enabled = false;
                label_cost.Text = "";
            }
        }

        private void InitializeComponent2()
        {
            Utility.setAllButtonDefocusedExcept("transport");
        }

        #endregion My Methods


        public UC_Transport()
        {
            InitializeComponent();
            showVehiclePanel();
            InitializeComponent2();
            
        }


        private void button_next_Click(object sender, EventArgs e)
        {
            //UC_Hotel uch = new UC_Hotel();
            //Utility.AddControlsToPanel(transport, panel_background);
            //Utility.AddControlsToPanel(uch);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_hotel);// This Will Shift the Navigation panel to the button specified
            Console.WriteLine("Stored Data = "+Tourist.VehicleName);
            Utility.setAllButtonDefocusedExcept("hotel");
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            UC_Destination ucd = new UC_Destination();
            //Utility.AddControlsToPanel(transport, panel_background);
            Utility.AddControlsToPanel(ucd);
            Utility.setNavigationPanelPosition(Utility.DASHBOARD.button_destination);// This Will Shift the Navigation panel to the button specified
            Utility.setAllButtonDefocusedExcept("destination");
        }

        private void panel_air_Click(object sender, EventArgs e)
        {
            vehicleLockDecision(Tourist.Zilla);
            showSinglePanel(panel_A, panel_air_places, panel_bus_places, panel_rail_places);
            setDefaultComboBoxOption();
            label_cost.Text = "";
        }

        private void panel_bus_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_B, panel_bus_places, panel_air_places, panel_rail_places);
            setDefaultComboBoxOption();
            vehicleLockDecision(Tourist.Zilla);
            label_cost.Text = "";
        }

        private void panel_rail_Click(object sender, EventArgs e)
        {
            showSinglePanel(panel_C, panel_rail_places, panel_air_places, panel_bus_places);
            setDefaultComboBoxOption();
            vehicleLockDecision(Tourist.Zilla);
            label_cost.Text = "";
        }

        private void radioButton_bus_ac_CheckedChanged(object sender, EventArgs e)
        {
            string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, false, "", true, false, true);
            Console.WriteLine("Bus Vehicle Cost ac = " + vehicleCost);
            label_cost.Text = vehicleCost;
            Tourist.BusAC = true;
        }

        private void radioButton_bus_nonAC_CheckedChanged(object sender, EventArgs e)
        {
            string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, false, "", true, false, false);
            Console.WriteLine("Bus Vehicle Cost non ac = " + vehicleCost);
            label_cost.Text = vehicleCost;
            Tourist.BusAC = false;
        }

        private void radioButton_rail_ac_CheckedChanged(object sender, EventArgs e)
        {
            string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, false, "", false, true, true);
            Console.WriteLine("Rail Vehicle Cost ac = " + vehicleCost);
            label_cost.Text = vehicleCost;
            Tourist.RailAC = true;
        }

        private void radioButton_rail_nonAC_CheckedChanged(object sender, EventArgs e)
        {
            string vehicleCost = Tourist.getVehicleCost(Tourist.Zilla, false, "", false, true, false);
            Console.WriteLine("Rail Vehicle Cost non ac = " + vehicleCost);
            label_cost.Text = vehicleCost;
            Tourist.RailAC = false;
        }
    }
}
