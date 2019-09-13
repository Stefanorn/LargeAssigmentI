using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Services;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;

namespace TechnicalRadiation.webAPI.Controllers
{
    [Route("api")]
    public class NewsController : ControllerBase
    {
        private NewsService _newsService;
        private string _password = "SecretPassword";
        public NewsController(){
            // TODO Ath mapper
            _newsService = new NewsService();
        }
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNews([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25 ){

            var envelope = new Envelope<NewsItemDto>( pageNumber,pageSize, _newsService.GetAllNews());

            return Ok(envelope.Items);

        }
        [Route("{authors}")]
        [HttpGet]
        public IActionResult GetAllAuthors([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25 ){

            var envelope = new Envelope<AuthorDto>( pageNumber,pageSize, _newsService.GetAllAuthors());

            return Ok(envelope.Items);

        }
/*
        [Route("{categories}")]
        [HttpGet]
        public IActionResult GetAllCategories([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100 ){
            var envelope = new Envelope<CategoryDto>(pageNumber = 1, pageSize, _newsService.GetAllCategories());
            return Ok(envelope.Items);
        }
        
        [Route("categories/{id:int}", Name = "GetCategoryById")]
        [HttpGet]
        public IActionResult GetCategoryById(int id){
            return Ok(_newsService.GetCategoryById(id));
        }
        */
        [Route("{id:int}", Name = "GetNewssById")]
        [HttpGet]
        public IActionResult GetNewsById(int id){
            return Ok(_newsService.GetNewsById(id));
        }

        [Route("authors/{id:int}", Name = "GetAuthorById")]
        [HttpGet]
        public IActionResult GetAuthorById(int id){
            return Ok(_newsService.GetAuthorById(id));
        }



        [Route("{id:int}", Name = "GetNewssById")]
        [HttpDelete]
        public IActionResult DeleteNews([FromHeader]string AuthorizedCode, int id){

            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }

            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _newsService.DeleteNewsById(id);
            return NoContent();
        }

        [Route("{id:int}", Name = "GetNewsById")]
        [HttpPut]
        public IActionResult UpdateNewsById([FromHeader]string AuthorizedCode, [FromBody] NewsItemInputModel input,  int id){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _newsService.UpdateNewsById(input,id);
            return NoContent();
        }

        [Route("")]
        [HttpPost]
        public IActionResult CreateNewNews([FromHeader]string AuthorizedCode ,[FromBody] NewsItemInputModel body){
            
            if (AuthorizedCode == null || AuthorizedCode != _password) {
                return StatusCode(403);
            }

            if (!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            var news = _newsService.CreateNewNews(body);
            return CreatedAtRoute( "GetNewsById", new { id = news.Id }, null );
        }

        [Route("authors")]
        [HttpPost]
        public IActionResult CreateAuthor([FromHeader]string AuthorizedCode ,[FromBody] AuthorInputModel body){
            
            if (AuthorizedCode == null || AuthorizedCode != _password) {
                return StatusCode(403);
            }

            if (!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            var news = _newsService.CreateAuthor(body);
            return CreatedAtRoute( "GetAuthorById", new { id = news.Id }, null );
        }


        [Route("{categories}")]
        [HttpGet]
        public IActionResult GetAllCategories([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100 ){
            var envelope = new Envelope<CategoryDto>(pageNumber = 1, pageSize, _newsService.GetAllCategories());
            return Ok(envelope.Items);
        }

        [Route("categories/{id:int}", Name = "GetCategoryById")]
        [HttpGet]
        public IActionResult GetCategoryById(int id){
            return Ok(_newsService.GetCategoryById(id));
        }
        
        
        [Route("{categories}")]
        [HttpPost]
        public IActionResult CreateCategory([FromHeader]string AuthorizedCode, [FromBody] CategoryInputModel body){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }

            var categories = _newsService.CreateCategory(body);
            return CreatedAtRoute( "GetCategoryById", new { id = categories.Id}, null );

        }
        [Route("categories/{id:int}", Name = "GetCategoryById")] 
        [HttpPut]
        public IActionResult UpdateCategory([FromHeader]string AuthorizedCode, [FromBody] CategoryInputModel body, int id){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }

            _newsService.UpdateCategory(body, id);
            return NoContent();  
        }

        [Route("categories/{id:int}", Name = "DeleteCatagory")]
        [HttpDelete]
        public IActionResult DeleteCatagory([FromHeader]string AuthorizedCode, int id){

            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _newsService.DeleteCatagoryById(id);
            return NoContent();
        }

        [Route("categories/{catId:int}/news/{newsId}", Name = "LinkNewsToCatagory")]
        [HttpGet]
        public IActionResult LinkNewsToCatagory([FromHeader]string AuthorizedCode, int catId, int newsId){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            _newsService.LinkNewsToCatagory(catId,newsId);
            return NoContent();
        }
        [Route("author/{authId:int}/news/{newsId}", Name = "LinkNewsToCatagory")]
        [HttpGet]
        public IActionResult LinkAuthorToNewsItem([FromHeader]string AuthorizedCode, int authId, int newsId){
            if (AuthorizedCode == null || AuthorizedCode != _password){
                return StatusCode(403);
            }
            _newsService.LinkAuthorToNewsItem(authId,newsId);
            return NoContent();
        }
    }
}