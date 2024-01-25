using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class Faculity
{
    [Key]
    public int Id { get; set; }


    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }


}