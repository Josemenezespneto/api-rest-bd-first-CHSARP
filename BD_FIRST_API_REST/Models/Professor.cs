using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BD_FIRST_API_REST.Models;
public partial class Professor
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informar o nome")]
    public string Nome { get; set; } = null!;
    [Required(ErrorMessage = "Informar o CPF")]
    [MaxLength(11,ErrorMessage = "O CPF não poderá ter mais de {1} caracteres")]
    [MinLength(11, ErrorMessage = "O CPF não poderá ter menos de {1} caracteres")]
    public string Cpf { get; set; } = null!;
    [Required(ErrorMessage = "Informar a Titulação")]
    public string Titulacao { get; set; } = null!;

    //public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
