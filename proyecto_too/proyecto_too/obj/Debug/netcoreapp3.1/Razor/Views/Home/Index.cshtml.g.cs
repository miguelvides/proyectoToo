#pragma checksum "D:\too\proyectoToo\proyecto_too\proyecto_too\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f230b93640600dfca352fbbc69c47e852d6cd93c"
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
#line 1 "D:\too\proyectoToo\proyecto_too\proyecto_too\Views\_ViewImports.cshtml"
using proyecto_too;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\too\proyectoToo\proyecto_too\proyecto_too\Views\_ViewImports.cshtml"
using proyecto_too.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f230b93640600dfca352fbbc69c47e852d6cd93c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e59a768f46f83aedaaa2b7c53119e33702d47fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\too\proyectoToo\proyecto_too\proyecto_too\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n        <div class=\"carousel-indicators\">\r\n            <button type=\"button\" data-bs-target=\"#myCarousel\" data-bs-slide-to=\"0\"");
            BeginWriteAttribute("class", " class=\"", 254, "\"", 262, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Slide 1\"></button>\r\n            <button type=\"button\" data-bs-target=\"#myCarousel\" data-bs-slide-to=\"1\" aria-label=\"Slide 2\"");
            BeginWriteAttribute("class", " class=\"", 400, "\"", 408, 0);
            EndWriteAttribute();
            WriteLiteral(@"></button>
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""2"" aria-label=""Slide 3"" class=""active"" aria-current=""true""></button>
        </div>

        <div class=""carousel-inner"">
            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><rect width=""100%"" height=""100%"" fill=""#777""></rect></svg>

                <div class=""container"">
                    <div class=""carousel-caption text-start"">
                        <h1>Example headline.</h1>
                        <p>Some representative placeholder content for the first slide of the carousel.</p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img""");
            WriteLiteral(@" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><rect width=""100%"" height=""100%"" fill=""#777""></rect></svg>

                <div class=""container"">
                    <div class=""carousel-caption"">
                        <h1>Another example headline.</h1>
                        <p>Some representative placeholder content for the second slide of the carousel.</p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>

            <div class=""carousel-item active"">               
                <div class=""container text-center"">
                    <img");
            BeginWriteAttribute("src", " src=", 2199, "", 2242, 1);
#nullable restore
#line 39 "D:\too\proyectoToo\proyecto_too\proyecto_too\Views\Home\Index.cshtml"
WriteAttributeValue("", 2204, Url.Content("~/imagenes/escuela.jpg"), 2204, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  width=""100%""/>
                </div>
             </div>

        </div>

        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>

        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>
</div>
");
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
