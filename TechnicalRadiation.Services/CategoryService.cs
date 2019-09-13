using System;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class CategoryService
    {
        private CategoryRepo _categoryRepo;
        public CategoryService(){
            _categoryRepo = new CategoryRepo();
        }
        public void DeleteCatagoryById(int id)
        {
            _categoryRepo.DeleteCategoryById(id);
        }

        public CategoryDto CreateCategory(CategoryInputModel model)
        {
            return _categoryRepo.CreateCategory(model);
        }

        public void UpdateCategory(CategoryInputModel body, int id)
        {
            _categoryRepo.UpdateCategory(body, id);
        }
    }
}