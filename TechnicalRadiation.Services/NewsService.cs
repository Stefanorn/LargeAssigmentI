using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Repositories;
using TechnicalRadiation.Models.Dtos;

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
    }
}