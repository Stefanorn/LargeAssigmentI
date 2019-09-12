using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Repositories;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.Entities;
using System;

namespace TechnicalRadiation.Services
{
    public class NewsService
    {
        private NewsRepo _NewsRepo;
        
        public NewsService(){
            _NewsRepo = new NewsRepo();

       }
       public IEnumerable<NewsItemDto> GetAllNews(){

           return _NewsRepo.GetAllNews().ToList();
       }
       public IEnumerable<CategoryDto> GetAllCategories(){
           return _NewsRepo.GetAllCategories().ToList();
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