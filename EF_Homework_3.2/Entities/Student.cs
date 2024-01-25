using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;


public class Student
{

    [Key]
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Name { get; set; }

    [Required, NotNull]
    [Range(0, 5)]
    public int Raiting { get; set; }

    [Required]
    [Column(TypeName = "nvarhcar(MAX)")]
    public string Surname { get; set; }
}
 