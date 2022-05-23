using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKApi.VK
{
    public class VKGroup
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
        [Newtonsoft.Json.JsonProperty("screen_name")]
        public string Screen_name { get; set; }
        [Newtonsoft.Json.JsonProperty("is_closed")]
        public int Is_closed { get; set; }
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
        [Newtonsoft.Json.JsonProperty("photo_50")]
        public string Photo_50 { get; set; }
        [Newtonsoft.Json.JsonProperty("photo_100")]
        public string Photo_100 { get; set; }
        [Newtonsoft.Json.JsonProperty("photo_200")]
        public string Photo_200 { get; set; }

        public class Response<T>
        {
            public VKGroup[] response { get; set; }
        }

        


        public override string ToString()
        {
            return @$"
            id = {Id}
            name = {Name}
            screen_name = {Screen_name}
            is_closed = {Is_closed}
            type = {Type}
            photo_50 = {Photo_50}
            photo_100 = {Photo_100}
            photo_200 = {Photo_200}
            ";
        }

       
    }
}
