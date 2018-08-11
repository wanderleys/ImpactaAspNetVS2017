using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.capitulo01.Fretes
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcularbutton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
               Calcular();
            }
        

        }

        private List<string> ValidarFormulario() //pode se criar uma lista de qualquer coisa
        {
            
        }

        private void Calcular()
        {
            throw new NotImplementedException();
        }
    }
}
