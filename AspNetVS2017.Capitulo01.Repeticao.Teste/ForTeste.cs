using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Teste
{
    [TestClass]
    public class ForTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {(i * j)} ");
                }

                Console.WriteLine(new string('-', 100));
            }   
        }

        [TestMethod]
        public void EstruturaForTest()
        {
            var i = 1;
            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }
        }

        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;

            for (; i <= 3;)
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
    
}
