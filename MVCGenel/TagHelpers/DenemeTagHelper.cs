using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCGenel.TagHelpers
{
    public class DenemeTagHelper : TagHelper 
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Content.SetContent("Tıklayınız!!");
            output.Attributes.SetAttribute("href", "https://www.google.com");
        }
    }
}
