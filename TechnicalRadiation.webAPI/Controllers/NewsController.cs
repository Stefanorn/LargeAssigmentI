using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Services;

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
        [Route("{id:int}", Name = "GetRentalsById")]
        [HttpGet]
        public IActionResult GetRentalsById(int id){
            return Ok();
        }
    }
}