using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class Lecture
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(typeof(DateTime), minimum: "01-01,2000", maximum: "23-1-2024")]
    public DateTime Date { get; set; }

    [Required]
    [ForeignKey(nameof(Subject))]
    public int SubjectId { get; set; }

    [Required]
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public Subject Subject { get; set; }
}
