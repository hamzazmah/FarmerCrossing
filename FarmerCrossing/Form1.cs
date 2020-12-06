using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerCrossing
{
    public partial class FarmerCrossing : Form
    {
        public FarmerCrossing()
        {
            InitializeComponent();  
        }

        private void FarmerCrossing_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FarmerCrossing_KeyDown);
            MessageBox.Show("A farmer with his wolf, duck and bag of corn come to the east side of a river they wish to cross.\nThere is a boat at the river’s edge, but of course only the farmer can row.\nThe boat can only hold two things(including the rower) at any one time.\nIf the wolf is ever left alone with the duck, the wolf will eat it.\nSimilarly, if the duck is ever left alone with the corn, the duck will eat it. \nHow can the farmer get across the river so that all four arrive safely on the other side?", "How to Play!");
            picCornLeft.Visible = false;
            picWolfLeft.Visible = false;
            picDuckLeft.Visible = false;
            picBoatLeft.Visible = false;
            btnMoveRight.Enabled = false;
        }

        private void FarmerCrossing_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A && !(picBoat.Bounds.IntersectsWith(picColliderLeft.Bounds)))
            {
                picBoat.Left -= 1;

            }
            if (e.KeyCode == Keys.D && !(picBoat.Bounds.IntersectsWith(picColliderRight.Bounds)))
            {
                picBoat.Left += 1;
            }
            if(e.KeyCode == Keys.S)
            {
                picBoat.Top += 1;
            }
            if(e.KeyCode == Keys.W)
            {
                picBoat.Top -= 1;
            }

        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if(radCorn.Checked || radDuck.Checked || radWolf.Checked)
            {
                if (picCornRight.Visible || picDuckRight.Visible || picWolfRight.Visible)
                {
                    if (radCorn.Checked)
                    {
                        if (picCornRight.Visible)
                        {
                            
                            btnMoveRight.Enabled = true;
                            btnMoveLeft.Enabled = false;
                            picCornLeft.Visible = true;
                            picCornRight.Visible = false;
                            picBoatLeft.Visible = true;
                            picBoat.Visible = false;
                            if (picDuckRight.Visible && picWolfRight.Visible)
                            {
                                MessageBox.Show("Wolf Ate the Duck!", "Retry");
                                this.Dispose();
                            }
                            MessageBox.Show("Corn Crossed the River!", "Corn Crossed the River!");
                        }
                        else
                        {
                            MessageBox.Show("Corn Not Here!");
                        }
                    }
                    if (radDuck.Checked)
                    {
                        if (picDuckRight.Visible)
                        {
                            MessageBox.Show("Duck Crossed the River!", "Duck Crossed the River!");
                            btnMoveRight.Enabled = true;
                            btnMoveLeft.Enabled = false;
                            picDuckLeft.Visible = true;
                            picDuckRight.Visible = false;
                            picBoatLeft.Visible = true;
                            picBoat.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Duck Not Here!");
                        }
                    }
                    if (radWolf.Checked)
                    {
                        if (picWolfRight.Visible)
                        {
                            btnMoveRight.Enabled = true;
                            btnMoveLeft.Enabled = false;
                            picWolfLeft.Visible = true;
                            picWolfRight.Visible = false;
                            picBoatLeft.Visible = true;
                            picBoat.Visible = false;
                            if (picDuckRight.Visible && picCornRight.Visible)
                            {
                                MessageBox.Show("Duck Ate the Corn!", "Retry!");
                                this.Dispose();
                            }
                            MessageBox.Show("Wolf Crossed the River!", "Wolf Crossed the River!");
                        }
                        else
                        {
                            MessageBox.Show("Wolf Not Here!");
                        }
                    }
                    if(!picBoat.Visible)
                    {
                        if(picDuckLeft.Visible && picCornLeft.Visible && picWolfLeft.Visible)
                        {
                            MessageBox.Show("Everyone Crossed the River!", "You Win!");
                            this.Dispose();
                        }
                    }  
                }
                else
                {
                    MessageBox.Show("No Tries Left!");
                }
            }
            
            else
            {
                MessageBox.Show("Please Choose!");
            }
           
            radCorn.Checked = false;
            radDuck.Checked = false;
            radWolf.Checked = false;
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
                if (!radCorn.Checked && !radDuck.Checked && !radWolf.Checked)
                {
                    btnMoveLeft.Enabled = true;
                    btnMoveRight.Enabled = false;
                    picBoatLeft.Visible = false;
                    picBoat.Visible = true;
                }

                if (radCorn.Checked)
                {
                    if (picCornLeft.Visible)
                    {
                        MessageBox.Show("Corn Crossed the River!", "Corn Crossed the River!");
                        btnMoveLeft.Enabled = true;
                        btnMoveRight.Enabled = false;
                        picCornLeft.Visible = false;
                        picCornRight.Visible = true;
                        picBoatLeft.Visible = false;
                        picBoat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Corn Not Here!");
                    }
                }

                if (radDuck.Checked)
                {
                    if (picDuckLeft.Visible)
                    {
                        MessageBox.Show("Duck Crossed the River!", "Duck Crossed the River!");
                        btnMoveLeft.Enabled = true;
                        btnMoveRight.Enabled = false;
                        picDuckLeft.Visible = false;
                        picDuckRight.Visible = true;
                        picBoatLeft.Visible = false;
                        picBoat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Duck Not Here!");
                    }
                }
                if (radWolf.Checked)
                {
                    if (picWolfLeft.Visible)
                    {
                        MessageBox.Show("Wolf Crossed the River!", "Wolf Crossed the River!");
                        btnMoveLeft.Enabled = true;
                        btnMoveRight.Enabled = false;
                        picWolfLeft.Visible = false;
                        picWolfRight.Visible = true;
                        picBoatLeft.Visible = false;
                        picBoat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Duck Not Here!");
                    }
                }

                if (!picBoatLeft.Visible)
                {
                    if (picDuckLeft.Visible && picWolfLeft.Visible)
                    {
                        MessageBox.Show("Wolf Ate the Duck!", "Game Over");
                        this.Dispose();
                    }
                    if (picDuckLeft.Visible && picCornLeft.Visible)
                    {
                        MessageBox.Show("Duck Ate the Corn!", "Game Over!");
                        this.Dispose();
                    }
                }
            radCorn.Checked = false;
            radDuck.Checked = false;
            radWolf.Checked = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Only One item at a Time." +
                "\n2. If Duck is Left with Corn, the Duck will eat it." +
                "\n3. If Duck is Left with Wolf, the Wolf will eat it." +
                "\n4. Move All 3 Across to Win!", "Help!");
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
