using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Cryptography.X509Certificates;

namespace KucukUnluUyumu_CustomTagHelper.TagHelpers
{
    public class KucukUnluUyumuTagHelper : TagHelper
    {
        public string Kelime {  get; set; } 

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<string> kelimedekiSesliHarfler = new List<string>();
            bool uyar = true;

            List<string> grup1 = new List<string>() { "a", "e", "ı", "i" };
            List<string> grup2 = new List<string>() { "o", "ö", "u", "ü" };
            List<string> grup3 = new List<string>() { "a", "e", "u", "ü" };

            foreach(var harf in Kelime)
            {
                if (grup1.Contains(harf.ToString()) || grup2.Contains(harf.ToString()))
                {
                    kelimedekiSesliHarfler.Add(harf.ToString());
                }
            }

            for(int i = 0; i < kelimedekiSesliHarfler.Count-1; i++)  
            {
                if ((grup1.Contains(kelimedekiSesliHarfler[i]) && !grup1.Contains(kelimedekiSesliHarfler[i + 1])) || (grup2.Contains(kelimedekiSesliHarfler[i]) && !grup3.Contains(kelimedekiSesliHarfler[i + 1])))
                {
                    output.Content.SetContent(Kelime + ": Uymaz");
                    uyar = false;
                    break;
                }
                
            }

            if(uyar)
                output.Content.SetContent(Kelime + ": Uyar");

        }
    }

}
