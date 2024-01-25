using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_Homework_3._2.Entities;

public class GroupAndCurator
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(CuratorId))]
    public int CuratorId { get; set; }
    [Required]

    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }


    public Group Group { get; set; }
    public Curators Curator { get; set; }
}
