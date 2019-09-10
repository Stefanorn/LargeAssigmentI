using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;

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

        public NewsItemDto CreateNewNews( NewsItemInputModel model ) {
        
           var nextId = DataProvider.newsItems.Count;
           
           NewsItem newItem = new NewsItem{
               Id = nextId,
               Title = model.Title,
               ImgSource = model.ImgSource,
               ShortDescription = model.ShortDescription,
               LongDescription = model.LongDescription,
               PublishDate = model.PublishDate,
               ModifiedBy = "Stefan",
               CreatedDate = DateTime.Now,
               ModifiedDate = DateTime.Now
           };
           DataProvider.newsItems.Add(newItem);
           return new NewsItemDto{
               Id = nextId,
               Title = model.Title,
               ImgSource = model.ImgSource,
               ShortDescription = model.ShortDescription,
           };
       }
    }
}