using Data.Interfaces;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ArticulosRepository : IArticulosRepository
    {
        public Articulo GetArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertarArticulo(string contenido, string titulo, int autorId)
        {
            throw new NotImplementedException();
        }
    }
}
