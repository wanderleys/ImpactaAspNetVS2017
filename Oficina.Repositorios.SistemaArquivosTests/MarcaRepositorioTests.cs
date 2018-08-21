using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
{
  MarcaRepositorio _marcaRepositorio = new MarcaRepositorio();
    

    [TestMethod()]
    public void SelecionarTest()

    {
        var MarcaRepositorio = new MarcaRepositorio();

        var marcas = _marcaRepositorio.Selecionar();

        foreach (var marca in marcas)
        {
            Console.WriteLine($"{marca.Id}: {marca.Nome}");
        }
    }

    [TestMethod()]
    [DataRow(3)]
    [DataRow(-3)]
    public void SelecionarPorIdTeste(int id)
    {
        var marca = _marcaRepositorio.Selecionar(id);

        if (id > 0)
        {
            Assert.IsTrue(marca.Nome == "GM"); // afirme que()

        }
        else
        {
            Assert.IsNull(marca);
        }

    }
}
}