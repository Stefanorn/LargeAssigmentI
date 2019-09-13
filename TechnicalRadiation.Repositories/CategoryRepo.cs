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
    public class CategoryRepo
    {
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
                Slug = model.Name.ToLower(),
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
               throw new Exception("");
           }
           entiy.ModifiedDate = DateTime.Now;
           entiy.Name = body.Name;
           entiy.Slug = GenerateSlug(body.Name);
        }
        private string GenerateSlug(string name)
        {
            name = name.ToLower();
            
            string pattern = " ";
            var regex = new Regex(pattern);
            return regex.Replace(name, "-");

        }
    }
}