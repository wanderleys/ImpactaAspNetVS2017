﻿using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
       private MarcaRepositorio _marcaRepositorio = new MarcaRepositorio();
       private ModeloRepositorio _modeloRepositorio = new ModeloRepositorio();
       private CorRepositorio _corRepositorio = new CorRepositorio();
       private VeiculoRepositorio _veiculoRepositorio = new VeiculoRepositorio();
     
        public VeiculoAplicacao()
        {
            PopularControles();
        }

        public List<Marca> Marcas { get; set; }
        public string MarcaSelecionada { get; set; }
        public List<Cor> Cores { get; set; }
        public List<Combustivel> Combustiveis { get; set; }
        public List<Modelo> Modelos { get; set; } = new List<Modelo>();
        public List<Cambio> Cambios { get; set; }

        private void PopularControles()
        {
            Marcas = _marcaRepositorio.Selecionar();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];

            if (MarcaSelecionada != string.Empty)
            {
                Modelos = _modeloRepositorio
                    .SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }

            Cores = _corRepositorio.Selecionar();

            Combustiveis = Enum.GetValues(typeof(Combustivel))
                .Cast<Combustivel>().ToList();

            Cambios = Enum.GetValues(typeof(Cambio))
                .Cast<Cambio>().ToList();
        }         

        public void Inserir()
        {

            try
            {
                var veiculo = new VeiculoPasseio();
                var formulario = HttpContext.Current.Request.Form;

                veiculo.Placa = formulario["placa"];//.ToUpper().Replace("-", string.Empty);
                veiculo.Ano = Convert.ToInt32(formulario["ano"]);
                veiculo.Observacao = formulario["observacao"];
                veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
                veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
                veiculo.Cor = _corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
                veiculo.Modelo = _modeloRepositorio.Selecionar(Convert.ToInt32(formulario["modelo"]));
                veiculo.Carroceria = TipoCarroceria.Hatch;

                _veiculoRepositorio.Inserir(veiculo);
            }
            catch (FileNotFoundException ex)
            {
                HttpContext.Current.Items.Add("MensagemErro",
                   $"O arquivo {ex.FileName} não foi encontrado.");
                throw ex; // se tiver parametro, os erros anteriores nao sao exibidos.
            }
            catch (DirectoryNotFoundException)
            {
                HttpContext.Current.Items.Add("MensagemErro",
                   "Pasta não foi encontrado.");
                throw;
            }
            catch (UnauthorizedAccessException)
            {
                HttpContext.Current.Items.Add("MensagemErro",
                   "Acesso ao arquivo Negado!.");
                throw;
            }
            catch (Exception excecao)
            {
                HttpContext.Current.Items.Add("MensagemErro", 
                    "Ooops! Sua operação não foi concluida.");

                //logar o objeto exceçao;

                throw;//arremessa o erro para frente mas nao pode ser utilizado sempre
            }
        }

    }
}