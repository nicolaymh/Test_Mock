using Data.Interfaces;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Service
{
    public class ArticulosServicio
    {
        private readonly IAutorRepository autorRepository;
        private readonly IArticulosRepository articuloRepository;

        public ArticulosServicio(IArticulosRepository articuloRepository, IAutorRepository autorRepository)
        {
            this.autorRepository = autorRepository;
            this.articuloRepository = articuloRepository;
        }

        public Articulo InsertarArticulo(string contenido, string titulo, int autorId)
        {
            if (!autorRepository.AutorValido(autorId))
            {
                throw new Exception("Autor not valido");
            }


            var articuloId = articuloRepository.InsertarArticulo(contenido, titulo, autorId);

            return ConsultarArticulo(articuloId);
        }

        public Articulo ConsultarArticulo(int id)
        {
            return articuloRepository.GetArticulo(id);
        }

    }
}
