using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon balloon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                balloon = new Balloon()
                {
                    Colour = txtColor.Text,
                    Height = Convert.ToDecimal(txtHeight.Text),
                    Diameter = Convert.ToDecimal(txtDiameter.Text)
                };             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = $"Colour: {balloon.Colour} \nHeight: {balloon.Height} \nDiameter: {balloon.Diameter}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
