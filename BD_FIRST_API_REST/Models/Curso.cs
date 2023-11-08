using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BD_FIRST_API_REST.Models;

public partial class Curso
{
    public int Id { get; set; }

    [DataType(DataType.Text)]
    public string Nome { get; set; } = null!;

    [DataType(DataType.Currency)]
    public float Preco { get; set; }

    public string Ementa { get; set; } = null!;

    public int ProfessorId { get; set; }

    public int DisciplinaId { get; set; }

    public virtual Disciplina Disciplina { get; set; } = null!;

    public virtual Professor Professor { get; set; } = null!;
}
