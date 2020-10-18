using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suity
{
   
    public partial class Form1 : Form
    {
        int suitCost = 1000;
        int shirtCost = 500;
        int shoesCost = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset.ResetAllControls(this);
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // --------------- start of exit button ------------------
        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want really exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        // --------------- end of exit button ------------------


        // --------------- start of reset button ------------------
        private void button3_Click(object sender, EventArgs e)
        {

            Reset.ResetAllControls(this);
        }
        // --------------- end of exit button ------------------


        //--------------------- start check suits ---------------------------
        private void suit1_CheckedChanged(object sender, EventArgs e)
        {
            if (suit1.Checked == true)
            {
                blackSuit1.Enabled = true;
                blueSuit1.Enabled = true;
                whiteSuit1.Enabled = true;
            }
            else
            {
                blackSuit1.Enabled = false;
                blueSuit1.Enabled = false;
                whiteSuit1.Enabled = false;
            }
        }

        private void suit2_CheckedChanged(object sender, EventArgs e)
        {
            if (suit2.Checked == true)
            {
                blackSuit2.Enabled = true;
                blueSuit2.Enabled = true;
                whiteSuit2.Enabled = true;
            }
            else
            {
                blackSuit2.Enabled = false;
                blueSuit2.Enabled = false;
                whiteSuit2.Enabled = false;
            }
        }

        private void suit3_CheckedChanged(object sender, EventArgs e)
        {
            if (suit3.Checked == true)
            {
                blackSuit3.Enabled = true;
                blueSuit3.Enabled = true;
                whiteSuit3.Enabled = true;
            }
            else
            {
                blackSuit3.Enabled = false;
                blueSuit3.Enabled = false;
                whiteSuit3.Enabled = false;
            }
        }

        private void suit4_CheckedChanged(object sender, EventArgs e)
        {
            if (suit4.Checked == true)
            {
                blackSuit4.Enabled = true;
                blueSuit4.Enabled = true;
                whiteSuit4.Enabled = true;
            }
            else
            {
                blackSuit4.Enabled = false;
                blueSuit4.Enabled = false;
                whiteSuit4.Enabled = false;
            }
        }

        private void suit5_CheckedChanged(object sender, EventArgs e)
        {
            if (suit5.Checked == true)
            {
                blackSuit5.Enabled = true;
                blueSuit5.Enabled = true;
                whiteSuit5.Enabled = true;
            }
            else
            {
                blackSuit5.Enabled = false;
                blueSuit5.Enabled = false;
                whiteSuit5.Enabled = false;
            }
        }

        private void suit6_CheckedChanged(object sender, EventArgs e)
        {
            if (suit6.Checked == true)
            {
                blackSuit6.Enabled = true;
                blueSuit6.Enabled = true;
                whiteSuit6.Enabled = true;
            }
            else
            {
                blackSuit6.Enabled = false;
                blueSuit6.Enabled = false;
                whiteSuit6.Enabled = false;
            }
        }

        private void suit7_CheckedChanged(object sender, EventArgs e)
        {
            if (suit7.Checked == true)
            {
                blackSuit7.Enabled = true;
                blueSuit7.Enabled = true;
                whiteSuit7.Enabled = true;
            }
            else
            {
                blackSuit7.Enabled = false;
                blueSuit7.Enabled = false;
                whiteSuit7.Enabled = false;
            }
        }
        //--------------------- end check suits ---------------------------


        //--------------------- start check shirts ---------------------------
        private void shirt1_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt1.Checked == true)
            {
                blackShirt1.Enabled = true;
                blueShirt1.Enabled = true;
                whiteShirt1.Enabled = true;
            }
            else
            {
                blackShirt1.Enabled = false;
                blueShirt1.Enabled = false;
                whiteShirt1.Enabled = false;
            }
        }

        private void shirt2_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt2.Checked == true)
            {
                blackShirt2.Enabled = true;
                blueShirt2.Enabled = true;
                whiteShirt2.Enabled = true;
            }
            else
            {
                blackShirt2.Enabled = false;
                blueShirt2.Enabled = false;
                whiteShirt2.Enabled = false;
            }
        }

        private void shirt3_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt3.Checked == true)
            {
                blackShirt3.Enabled = true;
                blueShirt3.Enabled = true;
                whiteShirt3.Enabled = true;
            }
            else
            {
                blackShirt3.Enabled = false;
                blueShirt3.Enabled = false;
                whiteShirt3.Enabled = false;
            }
        }

        private void shirt4_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt4.Checked == true)
            {
                blackShirt4.Enabled = true;
                blueShirt4.Enabled = true;
                whiteShirt4.Enabled = true;
            }
            else
            {
                blackShirt4.Enabled = false;
                blueShirt4.Enabled = false;
                whiteShirt4.Enabled = false;
            }
        }

        private void shirt5_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt5.Checked == true)
            {
                blackShirt5.Enabled = true;
                blueShirt5.Enabled = true;
                whiteShirt5.Enabled = true;
            }
            else
            {
                blackShirt5.Enabled = false;
                blueShirt5.Enabled = false;
                whiteShirt5.Enabled = false;
            }
        }

        private void shirt6_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt6.Checked == true)
            {
                blackShirt6.Enabled = true;
                blueShirt6.Enabled = true;
                whiteShirt6.Enabled = true;
            }
            else
            {
                blackShirt6.Enabled = false;
                blueShirt6.Enabled = false;
                whiteShirt6.Enabled = false;
            }
        }

        private void shirt7_CheckedChanged(object sender, EventArgs e)
        {
            if (shirt7.Checked == true)
            {
                blackShirt7.Enabled = true;
                blueShirt7.Enabled = true;
                whiteShirt7.Enabled = true;
            }
            else
            {
                blackShirt7.Enabled = false;
                blueShirt7.Enabled = false;
                whiteShirt7.Enabled = false;
            }
        }
        //--------------------- end of check shirts ---------------------------


        //--------------------- start of check shoes ---------------------------
        private void shoes1_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes1.Checked == true)
            {
                blackShoes1.Enabled = true;
                blueShoes1.Enabled = true;
                whiteShoes1.Enabled = true;
            }
            else
            {
                blackShoes1.Enabled = false;
                blueShoes1.Enabled = false;
                whiteShoes1.Enabled = false;
            }
        }

        private void shoes2_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes2.Checked == true)
            {
                blackShoes2.Enabled = true;
                blueShoes2.Enabled = true;
                whiteShoes2.Enabled = true;
            }
            else
            {
                blackShoes2.Enabled = false;
                blueShoes2.Enabled = false;
                whiteShoes2.Enabled = false;
            }
        }

        private void shoes3_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes3.Checked == true)
            {
                blackShoes3.Enabled = true;
                blueShoes3.Enabled = true;
                whiteShoes3.Enabled = true;
            }
            else
            {
                blackShoes3.Enabled = false;
                blueShoes3.Enabled = false;
                whiteShoes3.Enabled = false;
            }
        }

        private void shoes4_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes4.Checked == true)
            {
                blackShoes4.Enabled = true;
                blueShoes4.Enabled = true;
                whiteShoes4.Enabled = true;
            }
            else
            {
                blackShoes4.Enabled = false;
                blueShoes4.Enabled = false;
                whiteShoes4.Enabled = false;
            }
        }

        private void shoes5_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes5.Checked == true)
            {
                blackShoes5.Enabled = true;
                blueShoes5.Enabled = true;
                whiteShoes5.Enabled = true;
            }
            else
            {
                blackShoes5.Enabled = false;
                blueShoes5.Enabled = false;
                whiteShoes5.Enabled = false;
            }
        }

        private void shoes6_CheckedChanged(object sender, EventArgs e)
        {
            if (shoes6.Checked == true)
            {
                blackShoes6.Enabled = true;
                blueShoes6.Enabled = true;
                whiteShoes6.Enabled = true;
            }
            else
            {
                blackShoes6.Enabled = false;
                blueShoes6.Enabled = false;
                whiteShoes6.Enabled = false;
            }
        }
        //--------------------- end of check shoes ---------------------------


        //--------------------- start of total button ---------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            int[] itemcost = new int[3];
            itemcost[0] = Convert.ToInt32(blackSuit1.Value + blueSuit1.Value + whiteSuit1.Value + blackSuit2.Value + blueSuit2.Value + whiteSuit3.Value + blackSuit3.Value + blueSuit3.Value + whiteSuit3.Value + blackSuit4.Value + blueSuit4.Value + whiteSuit4.Value + blackSuit5.Value + blueSuit5.Value + whiteSuit5.Value + blackSuit6.Value + blueSuit6.Value + whiteSuit6.Value + blackSuit7.Value + blueSuit7.Value + whiteSuit7.Value) * suitCost;
            itemcost[1] = Convert.ToInt32(blackShirt1.Value + blueShirt1.Value + whiteShirt1.Value + blackShirt2.Value + blueShirt2.Value + whiteShirt3.Value + blackShirt3.Value + blueShirt3.Value + whiteShirt3.Value + blackShirt4.Value + blueShirt4.Value + whiteShirt4.Value + blackShirt5.Value + blueShirt5.Value + whiteShirt5.Value + blackShirt6.Value + blueShirt6.Value + whiteShirt6.Value + blackShirt7.Value + blueShirt7.Value + whiteShirt7.Value) * shirtCost;
            itemcost[2] = Convert.ToInt32(blackShoes1.Value + blueShoes1.Value + whiteShoes1.Value + blackShoes2.Value + blueShoes2.Value + whiteShoes3.Value + blackShoes3.Value + blueShoes3.Value + whiteShoes3.Value + blackShoes4.Value + blueShoes4.Value + whiteShoes4.Value + blackShoes5.Value + blueShoes5.Value + whiteShoes5.Value + blackShoes6.Value + blueShoes6.Value + whiteShoes6.Value) * shoesCost;

            int total = itemcost[0] + itemcost[1] + itemcost[2];

            txtTotal.Text = Convert.ToString(total);
        }
        
    }

    // ----------------- A class for reset all changes using the reset button --------------------------------

    /* ---- Another method to reset all controls ---- create another form and close the current form ! -------
     * 
                public partial class Form1 : Form
                {

                    public Form1()
                    {
                        InitializeComponent();
                    }

                    private void bReset_Click(object sender, EventArgs e)
                    {
                        Form1 NewForm = new Form1();           
                        NewForm.Show();
                        this.Dispose(false);
                    }
              }
     */
    public class Reset 
    {
        public static void ResetAllControls(Control f) // reset all controls in form (outside panals)
        {
            foreach (Control control in f.Controls)
            {
                ResetForm(control);
            }
        }

        private static void ResetForm(Control c) // reset all controls panals
        {
            if (c.HasChildren)
            {
                foreach (Control subControl in c.Controls)
                {
                    ResetForm(subControl);
                }
            }
            switch (c.GetType().Name)
            {
                case "TextBox":
                    TextBox textBox = (TextBox)c; // *TYPE CASTING* (TextBox)c = textbox input = text
                    textBox.Text = null;
                    break;

                case "CheckBox":
                    CheckBox checkBox = (CheckBox)c;  // *TYPE CASTING* (CheckBox)c = CheckBox input = true
                    checkBox.Checked = false;
                    break;

                case "NumericUpDown":
                    NumericUpDown numericUpDown = (NumericUpDown)c;  // *TYPE CASTING* (NumericUpDown)c = NumericUpDown input = numbers
                    numericUpDown.Value = 0;
                    numericUpDown.Enabled = false; // for disable all NumericUpDown in the form
                    break;
            }
        }
    }
}
