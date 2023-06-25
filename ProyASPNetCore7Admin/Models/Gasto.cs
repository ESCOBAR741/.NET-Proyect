using System;
using System.Collections.Generic;

namespace ProyASPNetCore7Admin.Models;

public partial class Gasto
{
    public int Id { get; set; }

    public string TipoGasto { get; set; } = null!;

    public string Detalle { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Monto { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FechaGasto { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
