using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab08
{

    public partial class fPlanet : Form
    {
        public Planet ThePlanet;
        public fPlanet(Planet t)
        {
            ThePlanet = t;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePlanet.Name = tbName.Text.Trim();
            ThePlanet.Weight = int.Parse(tbWeight.Text.Trim());
            ThePlanet.Radius = int.Parse(tbRadius.Text.Trim());
            ThePlanet.DayLenght = int.Parse(tbDayLenght.Text.Trim());
            ThePlanet.MaxTemp = int.Parse(tbMaxTemp.Text.Trim());
            ThePlanet.MinTemp = int.Parse(tbMinTemp.Text.Trim());
            ThePlanet.HasAtmosphere = chbHasAtmosphere.Checked;
            ThePlanet.HasInhabited = chbHasInhabited.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fPlanet_Load(object sender, EventArgs e)
        {
            if (ThePlanet != null)
            {
                tbName.Text = ThePlanet.Name;
                tbWeight.Text = ThePlanet.Weight.ToString();
                tbRadius.Text = ThePlanet.Radius.ToString();
                tbDayLenght.Text = ThePlanet.DayLenght.ToString();
                tbMaxTemp.Text = ThePlanet.MaxTemp.ToString();
                tbMinTemp.Text = ThePlanet.MinTemp.ToString();
                chbHasAtmosphere.Checked = ThePlanet.HasAtmosphere;
                chbHasInhabited.Checked = ThePlanet.HasInhabited;
            }
        }

        private void tbRadius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
