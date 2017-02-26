using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_API
{
    class temperature
    {
        public float day { get; set; }
        public float max { get; set; }
        public float min { get; set; }

    }

    class weathers 
    {
        public string description { get; set; }
        public string icon { get; set; }
    }
    class W_List
    {
        public int humidity { get; set; }
        public float speed { get; set; }
        public temperature temp { get; set; }
        public List<weathers> weather { get; set; }
        public int clouds { get; set; }
    }
}
