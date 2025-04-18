﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public Autor Autor { get; set; }
    }

    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
    }
}
