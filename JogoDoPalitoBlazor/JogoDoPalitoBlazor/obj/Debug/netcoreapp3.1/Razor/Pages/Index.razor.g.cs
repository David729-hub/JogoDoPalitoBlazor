#pragma checksum "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5761136c9c7296b9f6a5ab3d8a1d613464cb04f0"
// <auto-generated/>
#pragma warning disable 1591
namespace JogoDoPalitoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using JogoDoPalitoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using JogoDoPalitoBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\_Imports.razor"
using JogoDoPalitoBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bem Vindo! Ao \"Jogo do Palito\"</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Digite o numero de Palitos: </p>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "id", "Counter");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "disabled", 
#nullable restore
#line 6 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                             Input

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "min", "20");
            __builder.AddAttribute(7, "max", "30");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                                             toothpick

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => toothpick = __value, toothpick, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "id", "btn");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "disabled", 
#nullable restore
#line 8 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                    Input

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                                     Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Jogar");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.AddMarkupContent(18, "<p>Remova de 1 a 3 palitos: </p>\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "id", "Counter");
            __builder.AddAttribute(21, "type", "number");
            __builder.AddAttribute(22, "disabled", 
#nullable restore
#line 10 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                             Input2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "min", "1");
            __builder.AddAttribute(24, "max", "3");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                            removalplayer

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => removalplayer = __value, removalplayer, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "id", "btn");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "disabled", 
#nullable restore
#line 12 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                    Input2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
                                                                      Play

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Retirar");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, 
#nullable restore
#line 13 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
    Resposta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, 
#nullable restore
#line 14 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
    Fim

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\JogoDoPalitoBlazor\JogoDoPalitoBlazor\Pages\Index.razor"
       
    public string Fim = String.Empty;
    public string Resposta = String.Empty;
    public bool Input2 { get; set; } = true;
    public int toothpick { get; set; } = 20;
    public int removalplayer { get; set; } = 1;
    public bool Input { get; set; }
    public int removalComputer { get; set; } = 1;
    int user = 0;
    int total = 0;

    private void Start()
    {
        //Click botão jogar

        if (toothpick < 20 || toothpick > 30)
        {
            toothpick = 20;
        }
        Fim = String.Empty;
        Resposta = String.Empty;
        Input = !Input;
        Input2 = !Input2;
    }
    private void Play()
    {
    inicio:
        if (toothpick >= 1 && toothpick <= 30)
        {
            Resposta = String.Empty;
            switch (user)
            {
                case 0:


                    total = toothpick - removalplayer;
                    if (total < 0 || removalplayer > 3 || removalplayer < 0)
                    {
                        Resposta = " Valor Invalido ";
                        break;
                    }
                    else
                    {
                        toothpick = toothpick - removalplayer;
                    }
                    if (toothpick <= 0)
                    {
                        Fim = "!!!Você Perdeu O Jogo!!! ";
                        Input = !Input;
                        Input2 = !Input2;
                        toothpick = 10;
                        break;
                    }
                    user++;

                    goto inicio;

                case 1:
                    Resposta = String.Empty;
                    toothpick = Computer(toothpick);
                    Resposta = "Eu Retiro " + removalComputer + " - RESTAM: " + toothpick + " PALITOS";
                    if (toothpick <= 0)
                    {
                        Resposta = "Eu Retiro" + removalComputer + " - RESTAM: " + toothpick + " PALITOS ";
                        Fim = "!!!Você Venceu o jogo!!!";
                        Input = !Input;
                        Input2 = !Input2;
                        toothpick = 10;
                        break;
                    }
                    user--;
                    break;
            }
        }

    }

    //jogada do computador
    public int Computer(int toothpick)
    {
        int calc = 0;
        int total = 0;
        int number = 0;
        int limit = 3;
        for (int number2 = 1; number2 <= 2; number2++)
        {
            total = toothpick - number2;
            if (total == 1)
            {
                number = number2;
                break;
            }
            else if (total > 1)
            {
                calc = (total % (limit + 1));
                if (calc > 0 && calc <= 3)
                {
                    number = calc;
                    break;
                }


            }
            else if (total == 0)
            {
                number = number2;
                break;
            }
        }
        toothpick = toothpick - number;
        removalComputer = number;
        return (toothpick);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
