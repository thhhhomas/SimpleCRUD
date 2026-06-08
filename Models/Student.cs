using System.ComponentModel.DataAnnotations;

namespace SOGSA.Api.Models;

public class Student {

  [Key]
  public long Id { get; set; }

  [Required]
  [MaxLength(100)]
  public required string Name { get; set; }

}
