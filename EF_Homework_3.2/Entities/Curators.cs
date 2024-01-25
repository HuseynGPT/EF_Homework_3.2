using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class Curators
{
    [Key]
    public int MyProperty { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Surname { get; set; }

}
