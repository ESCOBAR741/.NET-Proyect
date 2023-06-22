using System;
using System.Collections.Generic;

namespace ProyASPNetCoreAdmin.Models;

public partial class Administradore
{
    public byte IdAdmin { get; set; }

    public string? NombreAdmin { get; set; } = null!;

    public string? ContraseñaAdmin { get; set; } = null!;

    public string? Nombres { get; set; } = null!;

    public string? Apellidos { get; set; } = null!;

    public string? Run { get; set; } = null!;

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
