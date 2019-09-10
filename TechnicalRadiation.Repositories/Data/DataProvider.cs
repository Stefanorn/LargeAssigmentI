using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;


namespace TechnicalRadiation.Repositories.Data
{
    public class DataProvider
    {
        private static readonly string _adminName = "DBAdmin";
        //newsitems
        private static List<NewsItem> newsItems = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,00
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },
            new NewsItem
            {
                Id = 2,
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda"
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,00
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                //_links,
            },
            new NewsItem
            {
                Id = 3,
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda"
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,00
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
 
                //_links,
            }
        };
        //authors
        private static List<NewsItemAuthor> NewsItemAuthors = new List<NewsItemAuthor>
        {
            new NewsItemAuthor
            {
                AuthorId = 1,
                NewsItemId = 1

            },
            new NewsItemAuthor
            {
                AuthorId = 2,
                NewsItemId = 2

            },
            new NewsItemAuthor
            {
                AuthorId = 3,
                NewsItemId = 3

            }
        };
        //categories
        private static List<NewsItemCategories> NewsItemCategoriess = new List<NewsItemCategories>
        {
            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItem = 1
            }
        };
    }
}