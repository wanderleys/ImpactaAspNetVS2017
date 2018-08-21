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
            trocoTextBox.Text = valorT.ToString("C", new CultureInfo("pt-BR")); //c+numero indica as casas decimais/ configura a moeda no troco de acordo com a regiao

            //ToDo: refatorar para usar vetor e for.

            //Convert faz arredondamento pra maior

            var moedas = new decimal[] {1, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m };
            //var indice = 0;



          //  foreach (var moeda in moedas)
            {
                //moedasListView.Items[indice++].Text = ((int)(valorT / moeda)).ToString();
                

            }

            for (int i = 0; i < moedas.Length; i++)
            {
                moedasListView.Items[i].Text = ((int)(valorT / moedas[i])).ToString();
                valorT = valorT % moedas[i];

            }


            ////var moedas1 = Convert.ToInt32(Troco / 1);

            //var moedas1 = (int)valorT;
            ////valorT = valorT - moedas1; funciona tbm
            //valorT = valorT % 1; //comando modulo exibe o resto da divisao

            //var moedas050 = (int)(valorT / 0.5M); //
            //valorT = valorT % 0.5m;

            //var moedas025 = (int)(valorT / 0.25M);
            //valorT %= 0.25m;

            //var moedas010 = (int)(valorT / 0.1m);
            //valorT %= 0.1m;

            //var moedas005 = (int)(valorT / 0.05m);
            //valorT %= 0.05m;

            //var moedas001 = (int)(valorT / 0.01m);
            //valorT %= 0.01m;


            //moedasListView.Items[0].Text = moedas1.ToString();
            //moedasListView.Items[1].Text = moedas050.ToString();
            //moedasListView.Items[2].Text = moedas025.ToString();
            //moedasListView.Items[3].Text = moedas010.ToString();
            //moedasListView.Items[4].Text = moedas005.ToString();
            //moedasListView.Items[5].Text = moedas001.ToString();













        }

    }
}
