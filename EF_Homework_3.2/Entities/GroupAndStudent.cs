using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class GroupAndStudent
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }
    public Group Group { get; set; }

    [Required]
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }
    public Student Student { get; set; }
}