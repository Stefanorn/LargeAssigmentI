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

           var News = _NewsRepo.GetAllNews().ToList();

           return News;
       }

       public NewsItemDto CreateNewNews( NewsItemInputModel model ) {
           return _NewsRepo.CreateNewNews(model);
       }

        public NewsItemDto GetNewsById(int id)
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