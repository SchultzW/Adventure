using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;


namespace Adventure
{
    public partial class Adventure : Form
    {
        public Adventure()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
        public bool IsPlayerAlive(int currentHP)
        {
            if (currentHP >= 0)
                return true;
            else
                return false;
        }
         public int ComputePLayerLevel(int exp)
        {
            if (exp < 100)
            {
                return 1;
            }
            else if (exp < 250)
            {
                return 2;
            }
            else if (exp < 500)
            {
                return 3;

            }
            else if (exp < 1000)
            {
                return 4;
            }
            else
                return 5;
        }
    }
}
