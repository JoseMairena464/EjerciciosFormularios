using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cmbConversion.Items.Add("Celsius a Fahrenheit");
            cmbConversion.Items.Add("Fahrenheit a Celsius");
            cmbConversion.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!double.TryParse(txtTemperatura.Text, out double temp))
            {
                errorProvider1.SetError(txtTemperatura, "Ingrese un número válido");
                return;
            }

            double resultado;

            if (cmbConversion.SelectedIndex == 0) // Celsius a Fahrenheit
                resultado = (temp * 9 / 5) + 32;
            else // Fahrenheit a Celsius
                resultado = (temp - 32) * 5 / 9;

            lblResultado.Text = $"Resultado: {resultado:F2}";
        }
    }
}
