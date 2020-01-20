#pragma checksum "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9661abb8f7c4000293df5c3cfc5c55f2eea9d5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership__VideoPlayerPartial), @"mvc.1.0.view", @"/Views/Membership/_VideoPlayerPartial.cshtml")]
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
#line 1 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models.MembershipViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.DTOModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9661abb8f7c4000293df5c3cfc5c55f2eea9d5b", @"/Views/Membership/_VideoPlayerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916617f2de8b4fb895118b7d80d6cc1b74e67b70", @"/Views/_ViewImports.cshtml")]
    public class Views_Membership__VideoPlayerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card no-border-radius\">\r\n");
#nullable restore
#line 4 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
     if (Model.Video.Url != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"video-player\">\r\n            <iframe");
            BeginWriteAttribute("src", " src=\"", 159, "\"", 181, 1);
#nullable restore
#line 7 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
WriteAttributeValue("", 165, Model.Video.Url, 165, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        <h2>");
#nullable restore
#line 11 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
       Write(Model.Video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"text-muted\">\r\n            <i class=\"material-icons\">movie</i>\r\n            Lesson ");
#nullable restore
#line 14 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
              Write(Model.LessonInfo.LessonNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n            ");
#nullable restore
#line 15 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
       Write(Model.LessonInfo.NumberOfLessons);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;\r\n            <i class=\"material-icons vertical-align text-small\">alarm</i>\r\n            ");
#nullable restore
#line 17 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
       Write(Model.Video.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes\r\n        </p>\r\n        <div class =\"video-course\">\r\n            <img");
            BeginWriteAttribute("src", " src =\"", 772, "\"", 807, 1);
#nullable restore
#line 20 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
WriteAttributeValue("", 779, Model.Course.CourseImageUrl, 779, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span class =\"vertical-align text-large\">");
#nullable restore
#line 21 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
                                                Write(Model.Course.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <hr class =\"no-margin\">\r\n    <div class =\"card-body\">\r\n        ");
#nullable restore
#line 26 "C:\Users\Fernanda Ek\source\repos\VideoOnDemand\VOD.UI\Views\Membership\_VideoPlayerPartial.cshtml"
   Write(Model.Video.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591