using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

//Leffa-class, leffan ominaisuudet taulukossa
public class Leffa
{
    public int Id { get; set; }

    [Required]
    public string? Nimi { get; set; }

    public string? Kieli { get; set; }

    public Genret Genre { get; set; }

    public double Kesto { get; set; }
}

public enum Genret { action, adventure, comedy, drama, fantasy, horror, musicals, mystery, romance, sports, thriller, western, }