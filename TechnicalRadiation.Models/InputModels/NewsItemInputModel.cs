using System;
using System.ComponentModel.DataAnnotations;
namespace TechnicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [URL]
        // must be valid url
        public string ImgSource { get; set; }
        [Required]
        [MaxLength(50)]
        // max lenghth 50
        public string ShortDescription { get; set; }
        [Required]
        [MaxLength(255)]
        // min lenght 50 max 255
        public string LongDescription { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PublishDate { get; set; }
    }
}