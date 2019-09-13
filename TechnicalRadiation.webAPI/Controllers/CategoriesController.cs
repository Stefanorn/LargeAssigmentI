/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Services;
using TechnicalRadiation.Models.InputModels;



namespace TechnicalRadiation.webAPI.Controllers
{
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private string _password = "SecretPassword";
        
        private CategoryService _categoryService;

        CategoriesController(){
           _categoryService = new CategoryService();
        }

        [Route("")]
        [HttpPost]
        public IActionResult CreateNewCategory([FromHeader]string AuthorizedCode, [FromBody] CategoryInputModel body){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }

            var categories = _categoryService.CreateCategory(body);
            return CreatedAtRoute( "GetNewssById", new { id = categories.Id}, null );

        }
        [Route("{id:int}", Name = "GetCatById")] 
        [HttpPut]
        public IActionResult UpdateCategory([FromHeader]string AuthorizedCode, [FromBody] CategoryInputModel body, int id){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }

            _categoryService.UpdateCategory(body, id);
            return NoContent();  
        }

        [Route("{id:int}", Name = "GetNewssById")]
        [HttpDelete]
        public IActionResult DeleteCatagory([FromHeader]string AuthorizedCode, int id){

            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _categoryService.DeleteCatagoryById(id);
            return NoContent();
        }

    }
}*/