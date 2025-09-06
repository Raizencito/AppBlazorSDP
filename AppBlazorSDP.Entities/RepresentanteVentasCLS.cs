using System;
using System.ComponentModel.DataAnnotations;

namespace AppBlazorSDP.Entities;

public class RepresentanteVentaCls
{
    [Required(ErrorMessage = "El número de empleado es obligatorio")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número positivo")]
    public int? Num_Empl { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Range(18, 100, ErrorMessage = "La Edad debe ser mayor o igual a 18")]
    public int? Edad { get; set; }

    [Required(ErrorMessage = "El campo Cargo es obligatorio")]
    public string Cargo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La Fecha de Contrato es obligatoria")]
    [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha válida")]
    [Range(typeof(DateTime), "1995-01-01", "2100-12-31", ErrorMessage = "La fecha debe ser desde 1995 en adelante")]
    public DateTime FechaContrato { get; set; }


    [Required(ErrorMessage = "El campo Cuota es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "Cuota debe ser un valor numerico positivo")]
    public double? Cuota { get; set; }

    [Required(ErrorMessage = "El campo Ventas es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "Ventas debe ser un valor numerico positivo")]
    public double? Ventas { get; set; }

    [Required(ErrorMessage = "El campo Sucursal es obligatorio")]
    public Departamento Sucursal { get; set; }


    //enlace con Jefe
    [Required(ErrorMessage = "Debe seleccionar un Jefe")]
    public int IdJefe { get; set; }

    public JefeCLS? Jefe { get; set; }


}

