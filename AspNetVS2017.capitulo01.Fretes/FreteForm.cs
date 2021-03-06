﻿using System;
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
        private List<string> erros;

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
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
            }
        

        }

        private void Calcular()
        {
            var frete = 0m;
            var valor = Convert.ToDecimal(valortextBox.Text);
            var nordeste = new List<string> {"BA","PE","AL", "RN", "CE"};

            switch (ufcomboBox.Text) // igual if e else
            {
                case "SP":
                    frete = 0.2m;
                    break;
                case "RJ":
                    frete = 0.3m;
                    break;
                case "MG":
                    frete = 0.35m;
                    break;
                case "AM":
                    frete = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    frete = 0.5m;
                    break;
                default:
                    frete = 0.75m;
                    break;
                case null: //novidade 2017
                    throw new NullReferenceException("Combo UF não pode ser nulo.");
                    //break;

            }




            fretetextBox.Text = frete.ToString("P2"); //p significa percentual, 2 = 2 casa decimais
            totaltextBox.Text = ((1 + frete) * valor).ToString("c"); //

        }

        private List<string> ValidarFormulario() //pode se criar uma lista de qualquer coisa
        {
            var erros = new List<string>();

            if (clientetextBox.Text == string.Empty)
            {
                erros.Add("O campo Cliente é obrigatório"); // SHIFT + CTRL + BARRA DE ESPAÇO
            }

            if (string.IsNullOrEmpty(valortextBox.Text))
            {
                erros.Add("O campo Valor é obrigatório"); 
            }

            if (string.IsNullOrEmpty(valortextBox.Text))
            {
                erros.Add("O campo Valor é obrigatório");
            }
            else
            {
                if (!decimal.TryParse(valortextBox.Text, out decimal valor))
                {
                    erros.Add("O campo Valor está com o formato inválido");
                    
                }
                else
                {
                    if (valor < 100)
                    {
                        erros.Add("Valor informado abaixo do mínimo (100).");
                    }
                }
            }

            if (ufcomboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione o Estado (UF).");
            }


            return erros;
        }

        private void limparbutton_Click(object sender, EventArgs e)
        {
            clientetextBox.Text = "";
            valortextBox.Text = string.Empty;
            ufcomboBox.SelectedIndex = -1;
            fretetextBox.Clear();
            totaltextBox.Text = null;


        }
    }
}
