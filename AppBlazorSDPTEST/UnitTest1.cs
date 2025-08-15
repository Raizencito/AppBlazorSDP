using System;
using System.ComponentModel.DataAnnotations;
using AppBlazorSDP.Entities;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace AppBlazorSDPTEST
{
    public class RepresentanteVentaClsTests
    {
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var contexto = new ValidationContext(modelo, null, null);
            var resultados = new List<ValidationResult>();
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }

        [Fact]
        public void ValidarModelo_ConDatosValidos_NoDebeTenerErrores()
        {
            var representante = new RepresentanteVentaCls
            {
                Num_Empl = 70000000,
                Nombre = "Juan Pérez",
                Edad = 25,
                Cargo = "Vendedor",
                FechaContrato = DateTime.Today,
                Cuota = 1500.50,
                Ventas = 2000.75
            };

            var errores = ValidarModelo(representante);

            Assert.Empty(errores); 
        }

        [Fact]
        public void ValidarModelo_CamposObligatoriosVacios_DebeRetornarErrores()
        {
            var representante = new RepresentanteVentaCls(); 

            var errores = ValidarModelo(representante);

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El numero de empleado es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El campo Nombre es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El campo Cargo es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La Fecha de Contrato es obligatoria"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El campo Cuota es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El campo Ventas es obligatorio"));
        }
    }
}
