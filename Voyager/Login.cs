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
    public partial class Login : Form
    {

        #region ATTRIBUTES

        private int textClearController = 0; // It'll control how many times to clear the text automatically

        #endregion ATTRIBUTES

        #region MY_METHODS

        public void InitializeComponent2()
        {
            panel_transparent.BackColor = Color.FromArgb(170, 0, 0, 0); // ARGB means A=transparancy,R=red,G=green,B=blue   
        }

        #endregion MY_METHODS



        public Login()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        #region FORM_ACTION_METHODS

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkbox is tikked, then show pass =>> systemPass = false, else it's true
            if (checkBox_showPass.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            /**
             *  Get the password from file or database, 
             *  then if username & password matches, hide this page &
             *  Open Dashboard and send the username there
             */
            string tempUser = "sudipta112";
            string tempPass = "sudipta";
            string sendUsername = textBox_username.Text;
            if ((tempUser == textBox_username.Text) && (tempPass == textBox_password.Text))
            {
                this.Hide();
                Dashboard db_1 = new Dashboard(sendUsername);
                Utility.DASHBOARD = db_1;
                db_1.Show();
            }
            else
            {
                MessageBox.Show("Username & Password did't match !!");
                textBox_username.Text = "";
                textBox_password.Text = "";
            }

        }

        private void textBox_username_MouseClick(object sender, MouseEventArgs e)
        {
            // When the the user clicked for the 1st time the default suggest will disappear
            if(textClearController <= 0)
            {
                textBox_username.Text = "";
                textClearController++;
            }
            
        }

        private void textBox_password_MouseClick(object sender, MouseEventArgs e)
        {
            // When the the user clicked for the 1st time the default suggest will disappear
            if (textClearController <= 1)
            {
                textBox_password.Text = "";
                textClearController++;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // add the signup page here
        }

        #endregion FORM_ACTION_METHODS


    }
}
