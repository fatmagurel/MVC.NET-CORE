#pragma checksum "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766ad49c059196eccc9f45b1878bf4d00808c8fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\_ViewImports.cshtml"
using Core_RazorViewEngine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\_ViewImports.cshtml"
using Core_RazorViewEngine.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766ad49c059196eccc9f45b1878bf4d00808c8fc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91dab2f9fe38080684cc13c9f8c6bd0d54157bc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<h2>Razor View Engine Kullanımı</h2>\r\n");
#nullable restore
#line 11 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
  
    string ad = "Bilge";
    string soyad = "Adam";
    int yas = 24;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<p><b>Razor View Engine İle Değişken Çağırma</b></p>\r\n");
#nullable restore
#line 19 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
Write(ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
Write(soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
        Write(yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<p><b>Razor View Engine ile Karar Yapıları</b></p>\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
   int sayi = 56;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
 if (sayi < yas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Sayınız: <b>");
#nullable restore
#line 28 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                 Write(sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>(Sayı değeri, Yaş (<b>");
#nullable restore
#line 28 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                                                Write(yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>) değişkenin değerinden küçüktür.</span>\r\n");
#nullable restore
#line 29 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
}

else if (sayi > yas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Sayınız: <b>");
#nullable restore
#line 33 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                 Write(sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>(Sayı değeri, Yaş (<b>");
#nullable restore
#line 33 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                                                Write(yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>) değişkenin değerinden büyüktür.</span>\r\n");
#nullable restore
#line 34 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Sayınız: <b>");
#nullable restore
#line 38 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                 Write(sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>(Sayı değeri, Yaş (<b>");
#nullable restore
#line 38 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                                                Write(yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>) değişkenin değerine eşittir.</span>\r\n");
#nullable restore
#line 39 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<p><b>Razor View Engine ile Döngüler ve Koleksiyonlar</b></p>\r\n");
#nullable restore
#line 45 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
  
    string[] isimler = { "Bilge", "Ayşe", "Hayriye", "Ertan", "Ali", "Veli" };
    string[] soyisimler = { "Adam", "Yılmaz", "Huriye", "Mertan", "Akıllı", "Mantıklı" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
 for (int i = 0; i < isimler.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><b>");
#nullable restore
#line 52 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
     Write(isimler[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>");
#nullable restore
#line 52 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
                    Write(soyisimler[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 56 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
 foreach (string item in isimler)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 58 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 59 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<p><b>Razor View Engine ile Ternary If</b></p>\r\n");
#nullable restore
#line 66 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
Write(11 > 10 ? "True ise yazılacak ifade" : "False ise yazılacak ifade");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 68 "C:\Users\user\source\repos\Core_RazorViewEngine\Core_RazorViewEngine\Views\Home\Index.cshtml"
Write(yas > sayi ? "Yaş sayıdan büyüktür." : "Yaş sayıdan küçüktür.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
