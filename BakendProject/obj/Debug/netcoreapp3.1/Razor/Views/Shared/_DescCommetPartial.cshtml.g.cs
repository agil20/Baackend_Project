#pragma checksum "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f04a79eccc0e2888338c968ab11d5241990e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DescCommetPartial), @"mvc.1.0.view", @"/Views/Shared/_DescCommetPartial.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f04a79eccc0e2888338c968ab11d5241990e10", @"/Views/Shared/_DescCommetPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660a035cbfdd8bc190284b7642210544650f1481", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__DescCommetPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailVM>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tab-content\" id=\"myTabContent\">\r\n                <div class=\"tab-pane fade show active\" id=\"description\" role=\"tabpanel\" aria-labelledby=\"description-tab\">\r\n                    <div class=\"description\">\r\n                       <p>");
#nullable restore
#line 5 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                     Write(Model.Product.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div> <!-- Description -->
                </div>
               <div class=""tab-pane fade"" id=""review"" role=""tabpanel"" aria-labelledby=""review-tab"">
                    <div class=""product-rating-content"">
                        <div class=""average-rating"">
                      
                            <p>Based on 9 Comments</p>
                        </div>
                     
");
#nullable restore
#line 15 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                      foreach (var item in Model.comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           <div class=""rating-items"">
                         
                     
                            <div class=""single-rating-item"">
                                <div class=""rating-author d-flex flex-wrap"">
                                    <h4 class=""author-name"">");
#nullable restore
#line 22 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                                                       Write(item.appUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                    <ul class=""rating-star"">
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><span>(5)</span></li>
                                    </ul>
                                </div>
                                <p>");
#nullable restore
#line 32 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                              Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 35 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                        <div class=\"rating-form\">\r\n                            <h4 class=\"form-title\">Add your Comments</h4>\r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f04a79eccc0e2888338c968ab11d5241990e106775", async() => {
                WriteLiteral(@"
                             
                                <div class=""row"">
                              
                                    <div class=""col-md-12"">
                                        <div class=""single-form"">
                                            <label>Your Review:</label>
                                            <textarea class=""textArea"" placeholder=""Write a review""></textarea>
                                        </div>
                                    </div>
                                   
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                             <div class=""col-md-12"">
                                        
                                           <a class=""commentBtn btn btn-success"">Add comment</a>
                                      
                                    </div>
                        </div>
                    </div> <!-- Rating Content -->
                </div>
            </div> ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
