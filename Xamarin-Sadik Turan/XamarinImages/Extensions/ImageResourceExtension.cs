using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImages.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ResourceId == null)
                return null;

            return ImageSource.FromResource(ResourceId);
        }
    }
}
