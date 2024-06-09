using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Xml.Serialization;

namespace MVCGenel.TagHelpers
{
    public class hivdaTagHelper : TagHelper
    {       
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Content.SetContent("Tıklayınız");
            output.Attributes.SetAttribute("href", "https://www.bilgeadam.com");
        }
        //Varsayılan Etiket Adı: Sınıf adının sonundaki TagHelper kısmı çıkarılarak belirlenir.hivdaTagHelper sınıfı için varsayılan etiket adı <hivda> olur.
    }
}
