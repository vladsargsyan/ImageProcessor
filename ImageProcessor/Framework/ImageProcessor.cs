using ImageProcessorApp.Core;
using ImageProcessorApp.Plugins;

namespace ImageProcessorApp.Framework
{
    public class ImageProcessor
    {
        private readonly Dictionary<string, IImageEffect> _availableEffects;

        public ImageProcessor()
        {
            _availableEffects = new Dictionary<string, IImageEffect>();
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            Console.WriteLine("Loading plugins...");
            RegisterPlugin(new DummyPlugins.ResizeEffect());
            RegisterPlugin(new DummyPlugins.BlurEffect());
            RegisterPlugin(new DummyPlugins.GrayscaleEffect());

            Console.WriteLine($"Loaded {_availableEffects.Count} plugins.");
        }

        public void RegisterPlugin(IImageEffect plugin)
        {
            if (!_availableEffects.ContainsKey(plugin.Name))
            {
                _availableEffects.Add(plugin.Name, plugin);
                Console.WriteLine($"Plugin '{plugin.Name}' registered.");
            }
            else
            {
                Console.WriteLine($"Plugin '{plugin.Name}' already registered. Skipping.");
            }
        }

        public IImageEffect? GetEffect(string effectName)
        {
            _availableEffects.TryGetValue(effectName, out var effect);
            return effect;
        }

        public void ProcessImage(ImageData image, List<(string effectName, object parameter)> desiredEffects)
        {
            Console.WriteLine($"\nProcessing Image: {image.Id}");
            foreach (var (effectName, parameter) in desiredEffects)
            {
                IImageEffect? effect = GetEffect(effectName);
                if (effect != null)
                {
                    effect.ApplyEffect(image, parameter);
                }
                else
                {
                    Console.WriteLine($"Error: Effect '{effectName}' not found.");
                }
            }
            Console.WriteLine($"Finished processing Image: {image.Id}");
        }

    }
}
