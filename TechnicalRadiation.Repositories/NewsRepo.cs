using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;

namespace TechnicalRadiation.Repositories
{
    public class NewsRepo
    {
        
        public IEnumerable<NewsItemDto> GetAllNews(){

            var allNews = DataProvider.newsItems;
            var newsDto = new List<NewsItemDto>();

            foreach(var news in allNews){
                newsDto.Add( new NewsItemDto(){
                    Id = news.Id,
                    Title = news.Title,
                    ImgSource = news.ImgSource,
                    ShortDescription = news.ShortDescription
                } );
            }
            
            return newsDto;
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
               //_links = model.Links
           };
       }

        public void DeleteNewsById(int id)
        {
            DataProvider.newsItems.RemoveAll(r => r.Id == id);
        }

        public NewsItemDetailDto GetNewsById(int id)
        {
            var entity = DataProvider.newsItems.FirstOrDefault(r => r.Id == id);
            if (entity == null) { return null; /* throw some exception */ }
            return new NewsItemDetailDto(){
                Id = entity.Id,
                Title = entity.Title,
                ImgSource = entity.ImgSource,
                ShortDescription = entity.ShortDescription,
                LongDescription = entity.LongDescription,
                PublishDate = entity.PublishDate
            };
        }

        public void UpdateNewsById( NewsItemInputModel input, int id){
            var entity = DataProvider.newsItems.FirstOrDefault(r => r.Id == id);
            if (entity == null) { return; /* throw some exception */ }
            entity.Title = input.Title;
            entity.ImgSource = input.ImgSource;
            entity.ShortDescription = input.ShortDescription;
            entity.LongDescription = input.LongDescription;
            entity.PublishDate = input.PublishDate;
            entity.ModifiedDate = DateTime.Now;
        }

        public IEnumerable<CategoryDto> GetAllCategories(){

            var allcategories = DataProvider.categories;
            var CategoryDto = new List<CategoryDto>();

            foreach(var categories in allcategories){
                CategoryDto.Add( new CategoryDto(){
                    Id = categories.Id,
                    Name = categories.Name,
                    Slug = categories.Slug
                } );
            }
            
            return CategoryDto;
        }
    }
}