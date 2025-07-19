using ImageProcessorApp.Core;
using ImageProcessorApp.Framework;

namespace ImageProcessorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageProcessor processor = new ImageProcessor();

            // Simulate image data
            ImageData image1 = new ImageData("Image#1", "data for image 1");
            ImageData image2 = new ImageData("Image#2", "data for image 2");
            ImageData image3 = new ImageData("Image#3", "data for image 3");

            // Define desired effects for each image
            // Image#1: resize to 100 pixels, add blur 2 pixels size 
            List<(string effectName, object parameter)> effectsForImage1 = new List<(string, object)>
            {
                ("Resize", 100),
                ("Blur", 2)
            };

            // Image#2: resize to 100 pixels 
            List<(string effectName, object parameter)> effectsForImage2 = new List<(string, object)>
            {
                ("Resize", 100)
            };

            // Image#3: resize to 150 pixels, add blur 5 pixels size, convert to grayscale 
            List<(string effectName, object parameter)> effectsForImage3 = new List<(string, object)>
            {
                ("Resize", 150),
                ("Blur", 5),
                ("Grayscale", new object())
            };

            // Process images
            processor.ProcessImage(image1, effectsForImage1);
            processor.ProcessImage(image2, effectsForImage2);
            processor.ProcessImage(image3, effectsForImage3);

        }
    }
}
