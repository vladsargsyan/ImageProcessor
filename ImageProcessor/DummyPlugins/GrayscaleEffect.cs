using ImageProcessorApp.Core;
using ImageProcessorApp.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorApp.DummyPlugins
{
    public class GrayscaleEffect : IImageEffect
    {
        public string Name => "Grayscale";
        public string? ParameterName => null;
        public Type? ParameterType => null;

        public void ApplyEffect(ImageData image, object parameter)
        {
            Console.WriteLine($"Applying Grayscale effect to image '{image.Id}' (simulated)");
        }
    }
}
