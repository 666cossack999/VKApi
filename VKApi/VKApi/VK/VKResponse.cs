using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKApi.VK
{
    public class VKResponse<T>
    {
        public List<T> Response { get; set; }
    }
}
