using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fMain : Form
    {
        
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Planet planet = new Planet();
            fPlanet ft = new fPlanet(planet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPlanetsinfo.Text += string.Format("Назва планети: {0} , Масса планети: {1}, Радіус планети: {2}, Тривалість доби: {3}, Максимальна температура:{4}, Мінімальна температура: {5}, [Є атмосфера:{6} | Обітаєма планета?{7}\r\n", planet.Name, planet.Weight, planet.Radius, planet.DayLenght, planet.MaxTemp, planet.MinTemp, planet.HasAtmosphere,planet.HasInhabited);
            }
        }

        private void tbPlanetsinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    } 
}
