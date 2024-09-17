using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2.models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private SitNums avion;
        public Form1()
        {
            InitializeComponent();
            avion = new SitNums();  
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int section = rdbSmoke.Checked ? 1 : 2;
            int selectNumber = avion.assignSit(section);

            if (selectNumber == -1)
            {
                string otherSection = (section == 1) ? "No Fumar" : "Fumar";
                if (MessageBox.Show($"La seccion que elegiste ya tiene la capacidad exacta. Desea que se le asigne a la seccion {otherSection}?", "Seccion llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    section = (section == 1) ? 2 : 1;
                    selectNumber = avion.assignSit(section);
                }
            }

            if (selectNumber != -1)
            {
                string sectionName = (section == 1) ? "No Fumar" : "Fumar";
                lblApproach.Text = $"Asiento {selectNumber} \nSeccion: {sectionName}";
            }
            else
            {
                lblApproach.Text = "Lo siento, el avion esta lleno";
            }

        }
    }
}
