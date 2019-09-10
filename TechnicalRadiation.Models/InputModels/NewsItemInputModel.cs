using System;
using System.ComponentModel.DataAnnotations;
namespace TechnicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        // must be valid url
        public string ImgSource { get; set; }
        [Required]
        // max lenghth 50
        public string ShortDescription { get; set; }
        [Required]
        // min lenght 50 max 255
        public string LongDescription { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
    }
}