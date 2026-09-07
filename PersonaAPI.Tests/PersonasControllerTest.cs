using PersonaAPI.Controllers;
using PersonaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace PersonaAPI.Tests
{
    public class PersonasControllerTest
    {
        [Fact]
        public async Task PostPersona_AgregarPersona_CuandoDatosSonValidos()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var nuevaPersona = new Persona
            {
                PrimerNombre = "Kevin",
                SegundoNombre = "Alexander",
                PrimerApellido = "Argueta",
                SegundoApellido = "Leiva",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(nuevaPersona);

            // Assert
            var createdResult =
                Assert.IsType<CreatedAtActionResult>(result.Result);

            var persona =
                Assert.IsType<Persona>(createdResult.Value);

            Assert.Equal("Kevin", persona.PrimerNombre);
            Assert.Equal("Argueta", persona.PrimerApellido);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoPrimerNombreEsNulo()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "",
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoPrimerApellidoEsNulo()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_AgregarPersona_CuandoSegundoNombreEsNulo()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                SegundoNombre = null,
                PrimerApellido = "Argueta",
                SegundoApellido = "Leiva",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            var createdResult =
                Assert.IsType<CreatedAtActionResult>(result.Result);

            var personaCreada =
                Assert.IsType<Persona>(createdResult.Value);

            Assert.Null(personaCreada.SegundoNombre);
        }


        [Fact]
        public async Task PostPersona_AgregarPersona_CuandoSegundoApellidoEsNulo()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                SegundoNombre = "Alexander",
                PrimerApellido = "Argueta",
                SegundoApellido = null,
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            var createdResult =
                Assert.IsType<CreatedAtActionResult>(result.Result);

            var personaCreada =
                Assert.IsType<Persona>(createdResult.Value);

            Assert.Null(personaCreada.SegundoApellido);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoPrimerNombreExcede100Caracteres()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = new string('A', 101),
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoSegundoNombreExcede100Caracteres()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                SegundoNombre = new string('A', 101),
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoPrimerApellidoExcede100Caracteres()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = new string('A', 101),
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoSegundoApellidoExcede100Caracteres()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "Argueta",
                SegundoApellido = new string('A', 101),
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoFechaNacimientoEsNula()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = default
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_NoAgregarPersona_CuandoDuiEsInvalido()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "Argueta",
                DUI = "123456789",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }


        [Fact]
        public async Task PostPersona_AgregarPersona_CuandoDuiEsValido()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            // Act
            var result = await controller.PostPersona(persona);

            // Assert
            Assert.IsType<CreatedAtActionResult>(result.Result);
        }


        [Fact]
        public async Task GetPersona_RetornaPersona_CuandoIdEsValido()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            var persona = new Persona
            {
                PrimerNombre = "Kevin",
                PrimerApellido = "Argueta",
                DUI = "12345678-9",
                FechaNacimiento = DateTime.Now.AddYears(-25)
            };

            context.Personas.Add(persona);
            await context.SaveChangesAsync();

            // Act
            var result = await controller.GetPersona(persona.Id);

            // Assert
            var actionResult =
                Assert.IsType<ActionResult<Persona>>(result);

            var personaResultado =
                Assert.IsType<Persona>(actionResult.Value);

            Assert.Equal("Kevin", personaResultado.PrimerNombre);
        }


        [Fact]
        public async Task GetPersona_RetornaNotFound_CuandoIdNoExiste()
        {
            // Arrange
            var context = Setup.GetDatabaseContext();
            var controller = new PersonaController(context);

            // Act
            var result = await controller.GetPersona(999);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
