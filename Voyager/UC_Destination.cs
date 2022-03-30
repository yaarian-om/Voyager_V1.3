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
    public partial class UC_Destination : UserControl
    {


        private string sequence = "Destination";
        private string AERROW = " ⇒ ";
        public static UC_Destination destiny;


        

        private void InitializeComponent2()
        {
            label_panelSequence.Text = "";
        }

        public UC_Destination()
        {
            InitializeComponent();
            Utility.setAllButtonDefocusedExcept("destination");
            InitializeComponent2();
        }


        private void panel_hillStation_Click(object sender, EventArgs e)
        {
            UC_Destination_HillSide ucdhs = new UC_Destination_HillSide();
            Utility.UC_DESTINATION_HILLSIDE = ucdhs;
            Utility.AddControlsToPanel(ucdhs);
            this.AutoScroll = false; // This will turn off the auto scroll features for other panels. Because we just want vertical in one panel just, not the all panels
        }
        

        private void panel_historical_Click(object sender, EventArgs e)
        {
            UC_Destination_Historical ucdh = new UC_Destination_Historical();
            Utility.UC_DESTINATION_HISTORICAL = ucdh;
            Utility.AddControlsToPanel(ucdh);
            this.AutoScroll = false; // This will turn off the auto scroll features for other panels. Because we just want vertical in one panel just, not the all panels
        }

        private void panel_beach_Click(object sender, EventArgs e)
        {
            UC_Destination_Beach ucdb = new UC_Destination_Beach();
            UC_Destination_Beach.DESTINATION = destiny;
            Utility.UC_DESTINATION_BEACH = ucdb;
            Utility.AddControlsToPanel(ucdb);
            this.AutoScroll = false; // This will turn off the auto scroll features for other panels. Because we just want vertical in one panel just, not the all panels
        }

        private void panel_lake_Click(object sender, EventArgs e)
        {
            UC_Destination_Lakes ucdl = new UC_Destination_Lakes();
            Utility.UC_DESTINATION_LAKES = ucdl;
            Utility.AddControlsToPanel(ucdl);
            this.AutoScroll = false; // This will turn off the auto scroll features for other panels. Because we just want vertical in one panel just, not the all panels
        }
    }
}
