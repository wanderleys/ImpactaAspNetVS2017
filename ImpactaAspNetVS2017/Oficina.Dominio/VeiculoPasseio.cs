﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //todo: OO - herança.
   public class VeiculoPasseio : Veiculo
    {
        public TipoCarroceria Carroceria { get; set; }

        //todo: oo - polimorfismo por substituição (override).
        public override List<string> Validar()
        {
            var erros = base.ValidarBase();
            //var ano = Ano;

            if (!Enum.IsDefined(typeof(TipoCarroceria), Carroceria))
            {
                erros.Add($"A Carroceria informada ({Carroceria}) não é válida.");
            }

            return erros;
        }
    }
}
