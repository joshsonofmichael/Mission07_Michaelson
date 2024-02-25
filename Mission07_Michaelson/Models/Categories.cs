using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace Mission07_Michaelson.Models
{
  public class Category
  {
    public int CategoryId {get; set;}
    public required string CategoryName {get; set;}
  }
}