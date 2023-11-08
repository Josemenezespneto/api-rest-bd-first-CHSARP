using System;
using System.Collections.Generic;

namespace AULA_25_05_2023_API_BD_FIRST.Models;

public partial class Atividade
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int Tempo { get; set; }

    public int? TreinoId { get; set; }

    public virtual Treino? Treino { get; set; }
}
