using System.ComponentModel.DataAnnotations.Schema;

namespace FanurApp.Models;

public class Resource
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public int CultureId { get; set; }
    [ForeignKey("CultureId")]
    public Culture Culture { get; set; }
}