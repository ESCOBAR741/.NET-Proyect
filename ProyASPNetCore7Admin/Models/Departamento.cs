using System;
using System.Collections.Generic;

namespace ProyASPNetCore7Admin.Models;

public partial class Departamento
{
    public byte Id { get; set; }

    public string NombreDepto { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
