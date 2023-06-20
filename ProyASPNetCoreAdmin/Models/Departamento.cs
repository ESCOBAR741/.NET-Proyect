using System;
using System.Collections.Generic;

namespace ProyASPNetCoreAdmin.Models;

public partial class Departamento
{
    public byte IdDepto { get; set; }

    public string NombreDepto { get; set; } = null!;

    public byte IdAdmin { get; set; }

    public virtual Administradore IdAdminNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
