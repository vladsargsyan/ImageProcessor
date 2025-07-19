using ImageProcessorApp.Core;
using ImageProcessorApp.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorApp.DummyPlugins
{
    public class ResizeEffect : IImageEffect
    {
        public string Name => "Resize";
        public string ParameterName => "Size";
        public Type ParameterType => typeof(int);

        public void ApplyEffect(ImageData image, object parameter)
        {
            if (parameter is int size)
            {
                Console.WriteLine($"Applying Resize effect to image '{image.Id}' with size: {size} pixels (simulated)");
                // In a real scenario, image.Data would be modified
            }
            else
            {
                Console.WriteLine($"Resize effect applied to image '{image.Id}' without a valid size parameter (simulated)");
            }
        }
    }
}
