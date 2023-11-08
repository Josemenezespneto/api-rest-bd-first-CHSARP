using System;
using System.Collections.Generic;

namespace BD_FIRST_API_REST.Models;

public partial class Disciplina
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
