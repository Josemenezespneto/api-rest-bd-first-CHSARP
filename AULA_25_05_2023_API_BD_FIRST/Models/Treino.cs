using System;
using System.Collections.Generic;

namespace AULA_25_05_2023_API_BD_FIRST.Models;

public partial class Treino
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();
}
