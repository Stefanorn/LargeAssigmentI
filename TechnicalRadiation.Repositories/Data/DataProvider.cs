using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;


namespace TechnicalRadiation.Repositories.Data
{
    public class DataProvider
    {
        private static readonly string _adminName = "DBAdmin";
        private static int _nextId = 0;
        private static int NextÍd(){
            return ++_nextId;
        }
        //categories
        public static List<Category> categories = new List<Category>
        {
            new Category{
                Id = 1,
                Name = "Sund fréttir",
                Slug = "sund"
            }
        };
        public static List<Author> Authors = new List<Author>
        {
            new Author{
                Id = 1,
                name = "J.K. Rowling",
                ProfileImgSource = "https://huberfinancial.com/wp-content/uploads/JKRowling_Photo-895x1030.jpg",
                Bio = "British Novelist",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };
        //newsitems
        public static List<NewsItem> newsItems = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Fyrsti : Þurfa að synda í gegn­um stór­an olíuflekk (þessi er með tíman 34min",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = new DateTime (2019, 01, 31, 7, 33, 20),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = 2,
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk (þessi er með tíman 35min)",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = new DateTime (2019, 01, 31, 7, 35, 20),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = 3,
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = new DateTime (2019, 01, 31, 7, 34, 20),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            }/*,            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },            new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            },
                        new NewsItem
            {
                Id = NextÍd(),
                Title = "Þurfa að synda í gegn­um stór­an olíuflekk",

                ImgSource = "https://cdn.mbl.is/frimg/1/15/70/1157040.jpg",
                ShortDescription = "Fólk að synda",
                LongDescription = "Long Description comes here",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
                
                //_links,
            } */


        };
        //authors
        public static List<NewsItemAuthor> NewsItemAuthors = new List<NewsItemAuthor>
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
        public static List<NewsItemCategories> NewsItemCategoriess = new List<NewsItemCategories>
        {
            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItem = 1
            }
        };
    }
}