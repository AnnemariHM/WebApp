using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class Leffa
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public LeffaPituus Size { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum LeffaPituus { Small, Medium, Large }