using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;
#pragma warning disable CS8618

public class User
{
    [Required]
    [MinLength(2)]
    [Display(Name = "Your name:")]
    public string Name {get;set;}
    [Required]
    public string Location {get;set;} 
    [Required]
    public string Language {get;set;}

    [MinLength(20)]
    [DataType(DataType.Text)]
    public string Comment {get;set;} 
}