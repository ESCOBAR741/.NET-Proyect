using System;
using System.Collections.Generic;

namespace ProyASPNetCore7Admin.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Run { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte IdDepto { get; set; }

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual Departamento IdDeptoNavigation { get; set; } = null!;

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
