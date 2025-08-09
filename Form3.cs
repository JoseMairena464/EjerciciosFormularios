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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool ValidarEntradas(out double num1, out double num2)
        {
            {
                num1 = num2 = 0;
                if (!double.TryParse(txtNum1.Text, out num1))
                {
                    MessageBox.Show("El primer número no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!double.TryParse(txtNum2.Text, out num2))
                {
                    MessageBox.Show("El segundo número no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double a, out double b))
                lblResultado.Text = $"Resultado: {a + b}";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double a, out double b))
                lblResultado.Text = $"Resultado: {a - b}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double a, out double b))
                lblResultado.Text = $"Resultado: {a * b}";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblResultado.Text = $"Resultado: {a / b}";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

}
