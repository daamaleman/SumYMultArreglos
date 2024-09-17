using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private RollDice rollDice; // Instancia de la clase RollDice
        public Form1()
        {
            InitializeComponent();
            rollDice = new RollDice(); // Inicializar la instancia de la clase RollDice
        }

        // Método para tirar los dados
        private void button1_Click(object sender, EventArgs e)
        {
            var (dice1, dice2, sum) = rollDice.Roll(); // Llamar al método Roll de la clase RollDice

            lblDie1.Text = $"Dado 1: {dice1.ToString()}"; // Mostrar el valor del dado 1
            lblDie2.Text = $"Dado 2: {dice2.ToString()}"; // Mostrar el valor del dado 2
            lblResult.Text = $"Suma: {sum.ToString()}"; // Mostrar la suma de los dados

            ShowSums(); // Llamar al método ShowSums
        }

        private void ShowSums()
        {
            int[] sums = rollDice.GetSums(); // Obtener el arreglo de las sumas

            lbSums.Items.Clear(); // Limpiar la lista de las sumas
            lbSums.Items.Add("Sumas\tCantidad"); // Título de la lista

            for (int i = 0; i < sums.Length; i++)
            {
                int sum = i + 2; // Suma de los dados
                int amount = sums[i]; // Cantidad de veces que se ha obtenido la suma
                lbSums.Items.Add($"{sum}\t{amount}"); // Mostrar la suma y la cantidad de veces que se ha obtenido
            }
        }


    }
}
