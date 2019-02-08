using System;
using System.Collections.Generic;
using System.Text;

namespace ListaBrasil.Modelo
{
    public class Microrregiao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Mesorregiao mesorregiao { get; set; }
    }
}
