
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace Mission07_Michaelson.Models
{
  public class Movie
  {
    [Key]
    public int MovieId {get; set;}
    
    public required string Title {get; set;}
    public required string Category {get; set;}
    public required string Year {get; set;}
    public required string Director {get; set;}
    public required string Rating {get; set;}
    public bool? Edited {get; set;}
    public string? LentTo {get; set;}
    public string? Notes {get; set;}
  }
}