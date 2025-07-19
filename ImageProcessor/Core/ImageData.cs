using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorApp.Core
{
    public class ImageData
    {
        public string Id { get; set; }
        public string Data { get; set; }

        public ImageData(string id, string data)
        {
            Id = id;
            Data = data;
        }
    }
}
