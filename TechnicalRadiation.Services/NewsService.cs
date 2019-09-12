using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Repositories;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.HyperMedia;
using TechnicalRadiation.Models.Entities;
using System;
using TechnicalRadiation.Models.Extensions;

namespace TechnicalRadiation.Services
{
    public class NewsService
    {
        private NewsRepo _NewsRepo;
        
        public NewsService(){
            _NewsRepo = new NewsRepo();

       }
       public IEnumerable<NewsItemDto> GetAllNews(){

           //return _NewsRepo.GetAllNews().ToList();
            var news = _NewsRepo.GetAllNews().ToList();
            news.ForEach(r => {
                //r.Links.AddReference("self", $"/api/{r.Id}");
                
                r.Links.AddReference("self",
                                     new { href = $"/api/{r.Id}" });
            });
            return news;
       }
       public IEnumerable<CategoryDto> GetAllCategories(){
           return _NewsRepo.GetAllCategories().ToList();
       }
       public CategoryDetailDto GetCategoryById(int id)
       {
           return _NewsRepo.GetCategoryById(id);
       }

       public NewsItemDto CreateNewNews( NewsItemInputModel model ) {
           return _NewsRepo.CreateNewNews(model);
       }

        public NewsItemDetailDto GetNewsById(int id)
        {
            return _NewsRepo.GetNewsById(id);
        }

        public void UpdateNewsById(NewsItemInputModel input ,int id){
            _NewsRepo.UpdateNewsById(input , id);
        }



        public void DeleteNewsById(int id)
        {
            _NewsRepo.DeleteNewsById(id);
        }
    }
}