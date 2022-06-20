using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            customlize();
        }
        private void customlize()
        {
            panelMedia.Visible = false;
            panelPlaylist.Visible = false;
            panelTools.Visible = false;
            //..
        }
        private void hideSubMenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = false;
            if (panelPlaylist.Visible == true)
                panelPlaylist.Visible = false;
            if (panelTools.Visible == true)
                panelTools.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMedia);

        }
        #region Media

        private void button2_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }
        #endregion

        private void btPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylist);
        }
        #region PlayList
        private void button9_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }
       

        private void button7_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        #endregion

        private void btTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTools);
        }
        #region Tools

        private void button14_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // your code...
            hideSubMenu();
        }
        #endregion
    }
}