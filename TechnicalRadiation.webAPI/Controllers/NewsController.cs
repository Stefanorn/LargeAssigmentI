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
  //  [ApiController]
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
        [HttpDelete]
        public IActionResult DeleteNews(int id){
            return Ok();
        }

        [Route("{id:int}", Name = "GetNewssById")]
        [HttpPatch]
        public IActionResult UpdateNews(int id){
            return Ok();
        }

        [Route("")]
        [HttpPost]
        public IActionResult CreateNews([FromBody] NewsItemInputModel body){
            if(!ModelState.IsValid){
                return BadRequest("input model not valid");
            }
            return Ok(_newsService.CreateNewNews(body));
            //return CreatedAtRoute( Ge)
        }
    }
}