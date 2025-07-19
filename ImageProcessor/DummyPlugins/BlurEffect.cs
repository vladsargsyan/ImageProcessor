using ImageProcessorApp.Core;
using ImageProcessorApp.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorApp.DummyPlugins
{
    public class BlurEffect : IImageEffect
    {
        public string Name => "Blur";
        public string ParameterName => "Radius";
        public Type ParameterType => typeof(int);

        public void ApplyEffect(ImageData image, object parameter)
        {
            if (parameter is int radius)
            {
                Console.WriteLine($"Applying Blur effect to image '{image.Id}' with radius: {radius} pixels (simulated)");
            }
            else
            {
                Console.WriteLine($"Blur effect applied to image '{image.Id}' without a valid radius parameter (simulated)");
            }
        }
    }
}
