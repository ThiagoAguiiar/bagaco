﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Adm : Usuario
    {
        private int codigoAdm;

        public int CodigoAdm { get => codigoAdm; set => codigoAdm = value; }

        public Adm(string cpf, string senha) : base(cpf, senha)
        {

        }


      
    }
}
