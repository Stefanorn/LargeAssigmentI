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
                r.Links.AddReference("edit",
                                     new { href = $"/api/{r.Id}" }); 
                r.Links.AddReference("delete",
                                     new { href = $"/api/{r.Id}" }); 
                /*r.Links.AddReference("authors", NewsRepo.GetAuthorByNewsId(r.Id,4).Select(o=> new { href = $"/api/authors/{o.Id}" }); 
               /*  r.Links.AddReference("categories",
                                     new { href = $"/api/categories/{r.Id}" });  */
            });
            return news;
       }
       public IEnumerable<CategoryDto> GetAllCategories(){
           return _NewsRepo.GetAllCategories().ToList();
       }
       public IEnumerable<AuthorDto> GetAllAuthors(){
           return _NewsRepo.GetAllAuthors().ToList();
       }
       
       /*
       public CategoryDetailDto GetCategoryById(int id)
       {
           return _NewsRepo.GetCategoryById(id);
       }
*/
       public NewsItemDto CreateNewNews( NewsItemInputModel model ) {
           return _NewsRepo.CreateNewNews(model);
       }

        public NewsItemDetailDto GetNewsById(int id)
        {
            return _NewsRepo.GetNewsById(id);
        }

        public AuthorDetailDto GetAuthorById(int id)
        {
            return _NewsRepo.GetAuthorById(id);
        }

        public void UpdateNewsById(NewsItemInputModel input ,int id){
            _NewsRepo.UpdateNewsById(input , id);
        }

        public void DeleteNewsById( int id)
        {
            _NewsRepo.DeleteNewsById(id);
        }

        public void LinkNewsToCatagory(int catId, int newsId)
        {
            _NewsRepo.LinkNewsToCatagory(catId,newsId);
        }
        public void LinkAuthorToNewsItem(int authId, int newsId){
            _NewsRepo.LinkAuthorToNewsItem(authId,newsId);
        }
          public CategoryDetailDto GetCategoryById(int id)
       {
           return _NewsRepo.GetCategoryById(id);
       }
        public void DeleteCatagoryById(int id)
        {
            _NewsRepo.DeleteCategoryById(id);
        }

        public CategoryDto CreateCategory(CategoryInputModel model)
        {
            return _NewsRepo.CreateCategory(model);
        }

        public AuthorDetailDto CreateAuthor(AuthorInputModel model)
        {
            return _NewsRepo.CreateAuthor(model);
        }

        public void UpdateCategory(CategoryInputModel body, int id)
        {
            _NewsRepo.UpdateCategory(body, id);
        }
    }
}