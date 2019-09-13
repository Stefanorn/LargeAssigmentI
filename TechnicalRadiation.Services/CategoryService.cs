/*using System;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class CategoryService
    {
        private CategoryRepo _categoryRepo = new CategoryRepo();
        public void DeleteCatagoryById(int id)
        {
            _categoryRepo.DeleteCategoryById(id);
        }

        public CategoryDto CreateCategory(CategoryInputModel body)
        {
            return _categoryRepo.CreateCategory(body);
        }

        public void UpdateCategory(CategoryInputModel body, int id)
        {
            _categoryRepo.UpdateCategory(body, id);
        }
    }
}*/