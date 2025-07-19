using ImageProcessorApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessorApp.Plugins
{
    public interface IImageEffect
    {
        string Name { get; }
        string? ParameterName { get; }
        Type? ParameterType { get; }

        void ApplyEffect(ImageData image, object parameter);
    }
}
