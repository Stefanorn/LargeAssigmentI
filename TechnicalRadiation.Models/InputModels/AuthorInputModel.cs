using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
       [Required]
       public string Name { get; set; } 
       [Required]
       //must be a valid URL
       [Required]
       [URL]
       public string ProfileImgSource { get; set; } 
       [Required]
       // max Length 255
       [Required]
       [MaxLength(255)]
       public string Bio { get; set; } 
    }
}