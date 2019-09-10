using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
       [Required]
       public string Name { get; set; } 
       [Required]
       [Url]
       public string ProfileImgSource { get; set; } 
       // max Length 255
       [Required]
       [MaxLength(255)]
       public string Bio { get; set; } 
    }
}