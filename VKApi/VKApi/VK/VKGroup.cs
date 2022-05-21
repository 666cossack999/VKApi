using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKApi.VK
{
    public class VKGroup
    {
        public int    Id { get; set; }
        public string Name { get; set; }
        public string Screen_name { get; set; }
        public int    Is_closed { get; set; }
        public string Type { get; set; }
        public string Photo_50 { get; set; }
        public string Photo_100 { get; set; }
        public string Photo_200 { get; set; }

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
