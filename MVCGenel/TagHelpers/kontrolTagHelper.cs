using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCGenel.TagHelpers
{
    public class kontrolTagHelper : TagHelper
    {
        public int Sayi { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Sayi % 2 == 0)
            {
                output.Content.SetContent(Sayi + ": ÇİFT");
            }
            else
            {
                output.Content.SetContent(Sayi + ": TEK");
            }
        }
    }
}
