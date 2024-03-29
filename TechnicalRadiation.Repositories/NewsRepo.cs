using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;

namespace TechnicalRadiation.Repositories
{
    public class NewsRepo
    {
        
        public IEnumerable<NewsItemDto> GetAllNews(){

            //var allNews = DataProvider.newsItems;
            var newsDto = new List<NewsItemDto>();

            //List<NewsItem> allNews = DataProvider.newsItems.OrderByDescending(DataProvider.newsItems.PublishDate);//
            List<NewsItem> allNews = DataProvider.newsItems;
            var allNewsDescendingDate = allNews.OrderByDescending(s => s.PublishDate);
            foreach(var news in allNewsDescendingDate){
                newsDto.Add( new NewsItemDto(){
                    Id = news.Id,
                    Title = news.Title,
                    ImgSource = news.ImgSource,
                    ShortDescription = news.ShortDescription
                } );
            }
            
            return newsDto;
        }
        public IEnumerable<AuthorDto> GetAllAuthors(){
            var authorDto = new List<AuthorDto>();

            List<Author> allAuthors = DataProvider.Authors;
            foreach(var author_ in allAuthors){
                authorDto.Add(new AuthorDto(){
                    id = author_.Id,
                    name = author_.name
                });
            }
            return authorDto;
        }
        public void DeleteCategoryById(int id)
        {
            DataProvider.categories.RemoveAll(r => r.Id == id);
        }
        public CategoryDto CreateCategory(CategoryInputModel model)
        {
            var nextId = DataProvider.NewsItemCategoriess.Count;

            Category newItem = new Category{
                Id = nextId,
                Name = model.Name,
                Slug = GenerateSlug(model.Name),
                ModifiedBy = "Stefan",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            DataProvider.categories.Add(newItem);
            return new CategoryDto{
                Id = nextId,
                Name = model.Name,
                Slug = model.Name.ToLower()
            };
        }
         public void UpdateCategory(CategoryInputModel body, int id)
        {
  
           var entiy = DataProvider.categories.FirstOrDefault(r => r.Id == id); 
           if (entiy == null){
               return;//throw new Exception("");
           }
           entiy.ModifiedDate = DateTime.Now;
           entiy.Name = body.Name;
           entiy.Slug = GenerateSlug(body.Name);
        }

        public void LinkNewsToCatagory(int catId, int newsId)
        {
            DataProvider.NewsItemCategoriess.Add(new NewsItemCategories{ CategoryId = catId, NewsItem = newsId});
        }

        public void LinkAuthorToNewsItem(int authId, int newsId)
        {
            DataProvider.NewsItemAuthors.Add(new NewsItemAuthor{ AuthorId = authId, NewsItemId = newsId});
        }

        private string GenerateSlug(string name){
            name.ToLower();
             string pattern = " ";
            var regex = new Regex(pattern);

            return regex.Replace(name, "-");
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

       public AuthorDetailDto CreateAuthor(AuthorInputModel model)
       {
           var nextId = DataProvider.NewsItemAuthors.Count;

           Author newAuthor = new Author{
               Id = nextId,
               name = model.Name,
               ProfileImgSource = model.ProfileImgSource,
               Bio = model.Bio
           };
           DataProvider.Authors.Add(newAuthor);
           return new AuthorDetailDto{
               	Id = nextId,
                Name = model.Name,
                ProfileImgSource = model.ProfileImgSource,
                Bio = model.Bio
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
        public AuthorDetailDto GetAuthorById(int id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(r => r.Id == id);
            if (entity == null) { return null; /* throw some exception */ }
            return new AuthorDetailDto(){
                Id = entity.Id,
                Name = entity.name,
                ProfileImgSource = entity.ProfileImgSource,
                Bio = entity.Bio
            };
        }

        public IEnumerable<NewsItemAuthor> GetAuthorByNewsId(int NewsItem, int AuthorId)
        {
            var Author = DataProvider.NewsItemAuthors.FindAll(o => o.AuthorId == AuthorId && o.NewsItemId == NewsItem);
            if(Author == null) { throw new Exception("Author not found");}
            return Author;
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
        public CategoryDetailDto GetCategoryById(int id)
        {
            var GetCategoryId = DataProvider.categories.FirstOrDefault(r => r.Id == id);
            if(GetCategoryId == null) {return null; /*throw exception */}
            return new CategoryDetailDto(){
                Id = GetCategoryId.Id,
                Name = GetCategoryId.Name,
                Slug = GetCategoryId.Slug
            };
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