using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customerizeDesing();
        }
        private void customerizeDesing()
        {
            panelMediaSubMenu.Visible=false;
            panelPlaylistSubMenu.Visible=false;
            panelToolsSubMenu.Visible=false;
            //..
        }
        private void hideSubMenu()
        {
            if(panelMediaSubMenu.Visible==true)
                panelMediaSubMenu.Visible = false;
            if(panelPlaylistSubMenu.Visible==true)
                panelPlaylistSubMenu.Visible= false;
            if(panelToolsSubMenu.Visible==true)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Media
        private void btnMedia_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }
        #endregion Media


        #region Playlist
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }
        #endregion Playlist
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            /*
            * 내 코드 작성
            */
            hideSubMenu();
        }

        #region Tools
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
             * 내 코드 작성
             */
            hideSubMenu();
        }
        #endregion Tools 
        private void btnHelp_Click(object sender, EventArgs e)
        {
            /*
           * 내 코드 작성
           */
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm !=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region config
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
