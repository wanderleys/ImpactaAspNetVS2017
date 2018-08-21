using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTest()
        {

            var inteiros = new List<int>(100); // classe list, a ordem que vc adiciona é a ordem que ele ficara

            inteiros.Add(2); //.Add sempre para adicionar um elemento na lista
            inteiros.Add(0);
            inteiros.Add(4);
            inteiros.Add(8);

            //inteiros[10] = 51; // sempre prestar atenção na hora de incluir.

            var maisInteiros = new List<int> {2,1,0,20};

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(1, 21); // insert ele empurra para frente se a posição estiver ocupada.

            inteiros.Remove(5); // remove o valor/item indicado() da lista

            inteiros.RemoveAt(0); // remove o indice

            inteiros.Sort(); // ordena

            var primeiro = inteiros.First(); //inteiros[0];
            var ultimo = inteiros.Last();//[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");

            }





       

        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2018,12,25), "Natal");
            feriados.Add(new DateTime(2019, 1, 1), "Ano Novo");
            feriados.Add(new DateTime(2019, 1, 25), "Aniversário de São Paulo");

            var natal = feriados[Convert.ToDateTime("25/12/2018")];

            foreach (var feriado in feriados)
            {
                //Console.WriteLine($"{feriado.Key.ToShortDateString()}:{feriado.Value}");
                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")}:{feriado.Value}");


            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("25/12/2018")));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));



        }
    }
}
