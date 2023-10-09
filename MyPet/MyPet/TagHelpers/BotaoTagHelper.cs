using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyPet.TagHelpers;

public class BotaoTagHelper : TagHelper
{
    public string? Texto { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        //Setar o class
        output.Attributes.SetAttribute("class", "btn btn-primary");

        //Setar o conteúdo do botão
        output.Content.SetContent(string.IsNullOrEmpty(Texto) ? "Cadastrar" : Texto);

    }
}
