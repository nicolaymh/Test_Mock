# Proyecto de Ejemplo con Moq 🛠️

## Objetivo 🎯

El objetivo de este proyecto es proporcionar un ejemplo claro y práctico de cómo utilizar Moq para realizar pruebas unitarias en una aplicación .NET. Moq es una biblioteca popular para la creación de objetos simulados (mocks) en pruebas, que permite verificar el comportamiento de las dependencias y asegurar que el código bajo prueba se comporte como se espera.

## Descripción del Proyecto 📚

Este proyecto contiene una simple aplicación de ejemplo que gestiona artículos y autores. Utiliza Moq para simular las dependencias de repositorios en las pruebas unitarias de los servicios que manejan la lógica de negocio.

## Estructura del Proyecto 🏗️

```Plaintext
Test_Mock/
├── Data/
│ ├── Dependencias/
│ ├── Interfaces/
│ │ ├── IAutorRepository.cs
│ │ ├── IArticulosRepository.cs
│ ├── AutorRepository.cs
│ ├── ArticulosRepository.cs
├── Dominio/
│ ├── Dependencias/
│ ├── Service/
│ │ ├── ArticulosServicio.cs
├── DTOs/
│ ├── Dependencias/
│ ├── Articulo.cs
├── Tests/
│ ├── Dependencias/
│ ├── UnitTest1.cs
├── WebApi/
│ ├── Connected Services/
│ ├── Dependencias/
│ ├── Properties/
│ ├── Controllers/
│ │ ├── ArticulosController.cs
│ ├── appsettings.json
│ ├── Program.cs
```

El proyecto está organizado en las siguientes capas:

- **Data**: Contiene las interfaces y sus implementaciones para el acceso a datos.
  - **Interfaces**: Contiene las interfaces para los repositorios.
    - `IAutorRepository.cs`
    - `IArticulosRepository.cs`
  - **Implementaciones**: Contiene las implementaciones de los repositorios.
    - `AutorRepository.cs`
    - `ArticulosRepository.cs`
- **Dominio**: Contiene las entidades y servicios del dominio.
  - **Service**: Contiene los servicios de la lógica de negocio.
    - `ArticulosServicio.cs`
- **DTOs**: Contiene los objetos de transferencia de datos (DTOs).
  - `Articulo.cs`
- **Tests**: Contiene las pruebas unitarias.
  - `UnitTest1.cs`
- **WebApi**: Contiene los controladores de la API.
  - **Controllers**: Contiene los controladores de la API.
    - `ArticulosController.cs`
  - `Program.cs`
  - `appsettings.json`

## Tecnologías Utilizadas 🛠️

- .NET
- Moq
- MSTest (framework de pruebas unitarias)

## Instalación y Configuración ⚙️

1. Clona este repositorio:
    ```bash
    git clone https://github.com/nicolaymh/TestMock.git
    ```

2. Abre el proyecto en tu IDE preferido (Visual Studio, Rider, etc.).

3. Asegúrate de tener instaladas las dependencias necesarias. Puedes hacerlo desde la consola del Administrador de Paquetes de NuGet:
    ```bash
    Install-Package Moq
    ```

## Ejecución de las Pruebas 🧪

Para ejecutar las pruebas unitarias, puedes usar el IDE o la línea de comandos:

1. Desde el IDE, abre el Explorador de Pruebas y ejecuta todas las pruebas.
2. Desde la línea de comandos, navega a la carpeta del proyecto de pruebas y ejecuta:
    ```bash
    dotnet test
    ```
