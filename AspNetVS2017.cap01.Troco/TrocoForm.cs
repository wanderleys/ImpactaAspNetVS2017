using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.cap01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorC = Convert.ToDecimal(valorCompratextBox.Text);
            decimal valorP = Convert.ToDecimal(valorPagotextBox.Text);
            decimal valorT = valorP - valorC;

            //trocoTextBox.Text = Convert.ToString(valorT);
            trocoTextBox.Text = valorT.ToString("C", new CultureInfo("pt-BR")); //c+numero indica as casas decimais/ configura a moeda no troco
        }

    }
}
