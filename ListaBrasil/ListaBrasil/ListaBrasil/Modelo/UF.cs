﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListaBrasil.Modelo
{
    public class UF
    {
        public int id { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
        public Regiao regiao { get; set; }
    }
}
