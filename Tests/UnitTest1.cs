using Data.Interfaces;
using Dominio.Service;
using DTOs;
using Moq;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // ********** Arrange: Preparar el entorno de prueba **********

            // Configurar los datos y las dependencias necesarias para el test.
            string contenido = "contenido";
            string titulo = "titulo";
            int autorId = 1;

            // Crear mocks para los repositorios
            Mock<IArticulosRepository> articuloRepo = new Mock<IArticulosRepository>();
            Mock<IAutorRepository> autorRepo = new Mock<IAutorRepository>();

            // Configurar el mock del repositorio de autores
            autorRepo.Setup(IdExists => IdExists.AutorValido(It.IsAny<int>())).Returns(true);
            // Configurar el mock del repositorio de artículos para insertar un artículo
            articuloRepo.Setup(newArticulo => newArticulo.InsertarArticulo(contenido, titulo, autorId)).Returns(1);
            // Configurar el mock del repositorio de artículos para obtener un artículo
            articuloRepo.Setup(getArticulo => getArticulo.GetArticulo(1)).Returns(new Articulo
            {
                Autor = new Autor
                {
                    AutorId = 1,
                    Nombre = "Autor"
                },
                Contenido = contenido,
                Fecha = DateTime.Now,
                Id = 1,
                Titulo = titulo
            });

            // Crear instancia del servicio con los mocks
            ArticulosServicio servicio = new ArticulosServicio(articuloRepo.Object, autorRepo.Object);


            // ********** Act: Ejecutar la acción que se está probando **********

            // Ejecutar el código que se está probando.
            Articulo articulo = servicio.InsertarArticulo(contenido, titulo, autorId);


            // ********** Assert: Verificar los resultados **********

            // Verificar las propiedades individuales del objeto Articulo
            Assert.AreEqual(1, articulo.Id);
            Assert.AreEqual(contenido, articulo.Contenido);
            Assert.AreEqual(titulo, articulo.Titulo);
            Assert.AreEqual(autorId, articulo.Autor.AutorId);
            Assert.AreEqual("Autor", articulo.Autor.Nombre);


            // Verificar que los métodos del repositorio fueron llamados exactamente una vez
            autorRepo.Verify(IdExists => IdExists.AutorValido(autorId), Times.Once);
            articuloRepo.Verify(newArticulo => newArticulo.InsertarArticulo(contenido, titulo, autorId), Times.Once);
            articuloRepo.Verify(getArticulo => getArticulo.GetArticulo(1), Times.Once);
        }
    }
}