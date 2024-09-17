using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio3.models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        // Lista de ventas
        private List<Sales> sales = new List<Sales>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            // Valores ingresados por el usuario
            int seller = int.Parse(tbSeller.Text);
            int product = int.Parse(tbProducts.Text);
            float salesValue = float.Parse(tbAmount.Text);

            // Validación de los valores ingresados
            if (seller >= 1 && seller <= 4 && product >= 1 && product <= 5)
            {
                // Creación de la venta y agregación a la lista
                Sales newSale = new Sales(seller, product, salesValue);
                sales.Add(newSale);

                MessageBox.Show("Venta agregada correctamente");
            }
            else
            {
                MessageBox.Show("Los valores ingresados no son válidos");
            }

            // Limpiar los campos
            tbSeller.Clear();
            tbProducts.Clear();
            tbAmount.Clear();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // Arreglo para almacenar las ventas por vendedor
            float[,] salesSummary = new float[5, 4];

            // Sumar las ventas por vendedor
            foreach (Sales sales in sales)
            {
               salesSummary[sales.Product - 1, sales.Seller - 1] += sales.SalesValue;
            }

            // Mostrar el reporte
            lbReport.Items.Clear();
            lbReport.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

            // Calcular el total por producto
            for (int product = 0; product < 5; product++) 
            {
                // Sumar las ventas de cada producto
                float totalProduct = 0;
                string line = $"Producto {product + 1}     ";

                // Iterar sobre los vendedores
                for (int seller = 0; seller < 4; seller++)
                {
                    line += $"{salesSummary[product, seller],8:F2}   ";
                    totalProduct += salesSummary[product, seller];
                }
                // Agregar el total por producto a la línea
                line += $"| {totalProduct,8:F2}";
                lbReport.Items.Add(line);
            }

            // Calcular el total por vendedor
            lbReport.Items.Add("----------------------------------------------------------");
            string totalLines = "Total Vendedor     ";

            // Iterar sobre los vendedores
            for (int seller = 0; seller < 4; seller++)
            {
                // Sumar las ventas de cada producto por vendedor
                float totalSeller = 0;
                for (int product = 0; product < 5; product++) 
                {
                    totalSeller += salesSummary[product, seller];
                }
                // Agregar el total por vendedor a la línea
                totalLines += $"{totalSeller,8:F2}   ";
            }
            // Mostrar el total por vendedor
            lbReport.Items.Add(totalLines);
        }
    }
}
