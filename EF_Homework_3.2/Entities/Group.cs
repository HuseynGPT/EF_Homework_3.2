using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Homework_3._2.Entities;

public class Group
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(10)")]
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(1, 5)]
    public int Year { get; set; }

    [Required]
    [ForeignKey(nameof(Deparment))]
    public int DepartmentId { get; set; }

    public Department Deparment { get; set; }


}
