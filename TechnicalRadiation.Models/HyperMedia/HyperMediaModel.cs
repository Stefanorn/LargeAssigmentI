//code credit: https://github.com/arnarleifs/WebServices2019/blob/master/net-core/RentAWorld/RentAWorld.Models/HyperMedia/HyperMediaModel.cs
using System.Dynamic;
using Newtonsoft.Json;

namespace TechnicalRadiation.Models.HyperMedia
{
    public class HyperMediaModel
   {
        public HyperMediaModel() { Links = new ExpandoObject(); }        
        [JsonProperty(PropertyName = "_links")]        
        public ExpandoObject Links { get; set; }

    }
}