using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IAutorRepository
    {
        Autor GetAutor(int id);
        bool AutorValido(int id);
    }
}
