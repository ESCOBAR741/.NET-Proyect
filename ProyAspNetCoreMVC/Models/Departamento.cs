using System;
using System.Collections.Generic;

namespace ProyAspNetCoreMVC.Models;

public partial class Departamento
{
    public byte IdDepto { get; set; }

    public string NombreDepto { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
