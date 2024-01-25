using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class Department
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Range(1, 5)]
    public int Building { get; set; }
    [Range(0, int.MaxValue)]
    [DefaultValue(0)]
    public Double Financing { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]

    public string Name { get; set; }

    [Required]
    [ForeignKey(nameof(Faculity))]
    public int FaculityId { get; set; }
    public Faculity Faculity { get; set; }

}
