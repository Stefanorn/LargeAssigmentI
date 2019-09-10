using System.Collections.Generic;
using TechnicalRadiation.Models.Dtos;

namespace TechnicalRadiation.Repositories
{
    public class NewsRepo
    {
        
        public IEnumerable<NewsItemDto> GetAllNews(){

            return new List<NewsItemDto> {
                new NewsItemDto(){
                    Id = 4,
                    Title = "Hello",
                    ImgSource = "www.www.com",
                    ShortDescription = "This is a NewsItem yo"
                },
            };
            
        }
    }
}