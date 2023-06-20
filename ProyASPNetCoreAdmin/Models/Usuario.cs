using System;
using System.Collections.Generic;

namespace ProyASPNetCoreAdmin.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Run { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public byte IdDepto { get; set; }

    public byte IdAdmin { get; set; }

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual Administradore IdAdminNavigation { get; set; } = null!;

    public virtual Departamento IdDeptoNavigation { get; set; } = null!;
}
