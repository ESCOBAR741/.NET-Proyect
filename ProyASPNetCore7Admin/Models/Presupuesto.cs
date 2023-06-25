using System;
using System.Collections.Generic;

namespace ProyASPNetCore7Admin.Models;

public partial class Presupuesto
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int Monto { get; set; }

    public int Saldo { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
