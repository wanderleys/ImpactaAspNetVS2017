using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{

    //ToDo: OO - Classe ou abstração.
    //abstract - nao pode ser instanciada.
    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        //todo: OO = encapsulamento.
        private string _placa; //propfull
        public string Placa
        {
            get { return  _placa.ToUpper().Replace("-", string.Empty); }
            set { _placa = value.ToUpper().Replace("-", string.Empty); }
        }



        //public string Placa
        //{
        //    get
        //    {
        //        return Placa.ToUpper().Replace("-", string.Empty);
        //    }
        //    set
        //    {

        //    }
        //}
        public Modelo Modelo { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        public string Observacao { get; set; }

        public abstract List<string> Validar();

        protected List<string> ValidarBase()
        {
            var erros = new List<string>();

            if (Ano <= 1960 || Ano - DateTime.Now.Year > 1)
            {
                erros.Add($"o Ano informado ({Ano}) não é válido");
            }

            return erros;
        }
    }
}