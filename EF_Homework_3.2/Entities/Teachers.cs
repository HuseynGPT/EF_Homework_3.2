using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class Teacher
{
    [Key]
    public int Id { get; set; }

    [DefaultValue(0)]
    public bool Professor { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Surname { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public double Salary { get; set; }

}