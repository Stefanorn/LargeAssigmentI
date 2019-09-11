using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Services;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.webAPI.Controllers
{
    [Route("api")]
 //   [ApiController]
    public class NewsController : ControllerBase
    {
        private NewsService _newsService;
        public NewsController(){
            // TODO Ath mapper
            _newsService = new NewsService();
        }
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNews(){

            return Ok(_newsService.GetAllNews() );
        }
        
        [Route("{id:int}", Name = "GetNewssById")]
        [HttpGet]
        public IActionResult GetNewsById(int id){
            return Ok(_newsService.GetNewsById(id));
        }

//TODO Authorized Routs !! 
        [Route("{id:int}", Name = "GetNewssById")]
        [HttpDelete]
        public IActionResult DeleteNews(int id){
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _newsService.DeleteNewsById(id);
            return NoContent();
        }

        [Route("{id:int}", Name = "GetNewssById")]
        [HttpPut]
        public IActionResult UpdateNewsById([FromBody] NewsItemInputModel input,  int id){
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            _newsService.UpdateNewsById(input,id);
            return NoContent();
        }

        [Route("")]
        [HttpPost]
        public IActionResult CreateNews([FromBody] NewsItemInputModel body){
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            var news = _newsService.CreateNewNews(body);
            return CreatedAtRoute( "GetNewssById", new { id = news.Id}, null );
        }
    }
}