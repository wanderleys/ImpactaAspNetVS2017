using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];

            int[] inteiros = new int[5]; // 5 posições 
            inteiros[0] = 9;
            inteiros[4] = 2;

            var decimais = new decimal[] { 0.3m, 0.2m, 7m};

            decimal[] outroVetor = { 0.5m, 8.6m, 12 };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine("Tamanho do vetor:" + decimais.Length);

        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 3.1m, 9.3m, 10 };

            Array.Resize(ref decimais, 5);

            decimais[4] = 1.8m;
            

        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 3.1m, 9.3m, 1.3m};

            Array.Sort(decimais); //array apoio para colecao / vetores
                                  //Linq 

            Assert.AreEqual(decimais[0], 1.3m);

        }


        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            //StringBuilder
            var nome = "Hejlsberg";

            Assert.AreEqual(nome[0], 'H');
            foreach (var @char in nome)
            
            {
                Console.Write(@char);
            }
        }


        [TestMethod]
        public void ParamsTest()
        {
            var decimais = new decimal[] { 3.1m, 9.3m, 1.3m };

            
        }




       
        
        private decimal Media(params decimal[] decimais)
        {
            //return decimais.Avarage();

            decimal soma = 0;
            //var cont = decimais.Length; criar uma variavel quando a linha coleção for muito grande.
            foreach (var numero in decimais)
            {
                soma += numero;
            }
           
           return soma / decimais.Length;

        }

    }
}
