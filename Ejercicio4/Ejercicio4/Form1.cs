using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        // Este arreglo almacena la cantidad de vendedores en cada rango de salario.
        private int[] salaryRanges = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        // Este método calcula el salario basado en las ventas brutas y actualiza el arreglo salaryRanges en consecuencia.
        private void CalculateSalary(int grossSales)
        {
            int salary = (int)(200 + 0.09 * grossSales);

            if (salary >= 1000)
            {
                salaryRanges[8]++;
            }
            else if (salary >= 900)
            {
                salaryRanges[7]++;
            }
            else if (salary >= 800)
            {
                salaryRanges[6]++;
            }
            else if (salary >= 700)
            {
                salaryRanges[5]++;
            }
            else if (salary >= 600)
            {
                salaryRanges[4]++;
            }
            else if (salary >= 500)
            {
                salaryRanges[3]++;
            }
            else if (salary >= 400)
            {
                salaryRanges[2]++;
            }
            else if (salary >= 300)
            {
                salaryRanges[1]++;
            }
            else
            {
                salaryRanges[0]++;
            }
        }

        // Este método se encarga de agregar una venta y calcular el salario correspondiente.
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            int grossSales;
            if (int.TryParse(tbSales.Text, out grossSales))
            {
                CalculateSalary(grossSales);
                MessageBox.Show("Venta agregada exitosamente");
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
            tbSales.Clear();
        }

        // Este método muestra el reporte de los salarios de los vendedores.
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            lbReport.Items.Clear();
            lbReport.Items.Add("Rango de salario:");
            lbReport.Items.Add($"$200-$299:   {salaryRanges[0]} vendedores");
            lbReport.Items.Add($"$300-$399:   {salaryRanges[1]} vendedores");
            lbReport.Items.Add($"$400-$499:   {salaryRanges[2]} vendedores");
            lbReport.Items.Add($"$500-$599:   {salaryRanges[3]} vendedores");
            lbReport.Items.Add($"$600-$699:   {salaryRanges[4]} vendedores");
            lbReport.Items.Add($"$700-$799:   {salaryRanges[5]} vendedores");
            lbReport.Items.Add($"$800-$899:   {salaryRanges[6]} vendedores");
            lbReport.Items.Add($"$900-$999:   {salaryRanges[7]} vendedores");
            lbReport.Items.Add($"$1000 o más: {salaryRanges[8]} vendedores");
        }
    }
}
