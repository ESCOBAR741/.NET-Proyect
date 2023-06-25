using System;
using System.Collections.Generic;

namespace ProyASPNetCore7Admin.Models;

public partial class AdminMantenedore
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Run { get; set; } = null!;

    public string UsuarioAm { get; set; } = null!;

    public string PasswordAm { get; set; } = null!;
}
