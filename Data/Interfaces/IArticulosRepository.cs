using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IArticulosRepository
    {
        int InsertarArticulo(string contenido, string titulo, int autorId);
        Articulo GetArticulo(int id);
    }
}
