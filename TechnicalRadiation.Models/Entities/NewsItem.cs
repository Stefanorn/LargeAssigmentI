using System;

namespace TechnicalRadiation.Models.Entities
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSource { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime PublishDate { get; set; }
        // Code Generated
        public string ModifiedBy { get; set; }
        // Code Generated
        public DateTime CreatedDate { get; set; }
        // Code Generated
        public DateTime ModifiedDate { get; set; }
    }
}