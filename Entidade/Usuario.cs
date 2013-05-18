﻿using BaseEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Usuario : EntidadeBase
    {
        [MaxLength(40]
        public string Nome { get; set; }
    }
}
