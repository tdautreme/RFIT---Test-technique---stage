#pragma checksum "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a798d40b4298bd952f49cae005e1d192ded6e1"
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
#line 1 "C:\Users\timda\source\repos\RFIT\RFIT\Views\_ViewImports.cshtml"
using RFIT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timda\source\repos\RFIT\RFIT\Views\_ViewImports.cshtml"
using RFIT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a798d40b4298bd952f49cae005e1d192ded6e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd22b29eca6018702e13f5715a98c860bc79d6c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Material>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/flag_en.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("setLanguage(\'en\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/flag_fr.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("setLanguage(\'fr\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a798d40b4298bd952f49cae005e1d192ded6e16588", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    <script type=\"text/javascript\">\r\n        lang = \"");
#nullable restore
#line 13 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
           Write(ViewBag.lang);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a798d40b4298bd952f49cae005e1d192ded6e17940", async() => {
                WriteLiteral("\r\n    <div class=\"backgroundColor\">\r\n        <div id=\"filterContainer\" class=\"contentCenter\">\r\n            <div class=\"mainStyle filterStyle\">\r\n                <input type=\"text\" class=\"basicInput filterInput\" onkeyup=\"useFilter(this.value)\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 512, "\"", 567, 1);
#nullable restore
#line 20 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 526, ViewBag.translate.filterPh[ViewBag.lang], 526, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"flagStyle\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0a798d40b4298bd952f49cae005e1d192ded6e18925", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0a798d40b4298bd952f49cae005e1d192ded6e110205", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <br />
        <div id=""addContainer"" class=""contentCenter"">
            <div class=""mainStyle materialStyle"">
                <div class=""materialSubContainer"">
                    <img id=""material_image_add"" class=""materialImage"" src=""/images/default_image.png"" onclick=""document.getElementById('material_imageInput_add').click();"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a798d40b4298bd952f49cae005e1d192ded6e111910", async() => {
                    WriteLiteral("<input type=\"file\" id=\"material_imageInput_add\" size=\"1\" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <div class=\"materialContent\">\r\n                        <div><input type=\"text\" id=\"material_name_add\" class=\"basicInput\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1521, "\"", 1582, 1);
#nullable restore
#line 35 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 1535, ViewBag.translate.materialNamePh[ViewBag.lang], 1535, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                        <div><input type=\"number\" id=\"material_serialNumber_add\" class=\"basicInput\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1693, "\"", 1762, 1);
#nullable restore
#line 36 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 1707, ViewBag.translate.materialSerialNumberPh[ViewBag.lang], 1707, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n\r\n                        <div class=\"basicInput\">\r\n                            <input type=\"date\" id=\"material_date_add\" class=\"timeInput\"");
                BeginWriteAttribute("value", " value=\"", 1913, "\"", 1957, 1);
#nullable restore
#line 39 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 1921, DateTime.Now.ToString("yyyy-MM-dd"), 1921, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"time\" id=\"material_time_add\" class=\"timeInput\"");
                BeginWriteAttribute("value", " value=\"", 2050, "\"", 2089, 1);
#nullable restore
#line 40 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 2058, DateTime.Now.ToString("HH:mm"), 2058, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""materialButton"">
                        <span class=""icon nice-green fas fa-plus-circle"" onclick=""tryAddMaterial();""></span>
                    </div>
                </div>
            </div>
        </div>
        </br>
        <div id=""materialListContainer"">
");
#nullable restore
#line 51 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
              
                foreach (var material in ViewBag.Materials)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"contentCenter\">\r\n                        <div");
                BeginWriteAttribute("id", " id=\"", 2633, "\"", 2650, 1);
#nullable restore
#line 55 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 2638, material.Id, 2638, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"material mainStyle materialStyle\">\r\n                            <div class=\"materialSubContainer\">\r\n                                <img");
                BeginWriteAttribute("id", " id=\"", 2795, "\"", 2827, 2);
                WriteAttributeValue("", 2800, "material_image_", 2800, 15, true);
#nullable restore
#line 57 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 2815, material.Id, 2815, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"materialImage\"");
                BeginWriteAttribute("src", " src=\"", 2850, "\"", 2875, 1);
#nullable restore
#line 57 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 2856, material.ImagePath, 2856, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 2876, "\"", 2954, 3);
                WriteAttributeValue("", 2886, "document.getElementById(\'material_imageInput_", 2886, 45, true);
#nullable restore
#line 57 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 2931, material.Id, 2931, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2943, "\').click();", 2943, 11, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a798d40b4298bd952f49cae005e1d192ded6e118386", async() => {
                    WriteLiteral("<input type=\"file\"");
                    BeginWriteAttribute("id", " id=\"", 3081, "\"", 3118, 2);
                    WriteAttributeValue("", 3086, "material_imageInput_", 3086, 20, true);
#nullable restore
#line 58 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3106, material.Id, 3106, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" size=\"1\"");
                    BeginWriteAttribute("onchange", " onchange=\"", 3128, "\"", 3171, 3);
                    WriteAttributeValue("", 3139, "materialWasEdited(", 3139, 18, true);
#nullable restore
#line 58 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3157, material.Id, 3157, 12, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3169, ");", 3169, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <div class=\"materialContent\">\r\n                                    <div><input type=\"text\"");
                BeginWriteAttribute("id", " id=\"", 3308, "\"", 3339, 2);
                WriteAttributeValue("", 3313, "material_name_", 3313, 14, true);
#nullable restore
#line 61 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3327, material.Id, 3327, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"basicInput\"");
                BeginWriteAttribute("value", " value=\"", 3359, "\"", 3381, 1);
#nullable restore
#line 61 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3367, material.Name, 3367, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3382, "\"", 3443, 1);
#nullable restore
#line 61 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3396, ViewBag.translate.materialNamePh[ViewBag.lang], 3396, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onkeyup", " onkeyup=\"", 3444, "\"", 3486, 3);
                WriteAttributeValue("", 3454, "materialWasEdited(", 3454, 18, true);
#nullable restore
#line 61 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3472, material.Id, 3472, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3484, ");", 3484, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 3487, "\"", 3530, 3);
                WriteAttributeValue("", 3498, "materialWasEdited(", 3498, 18, true);
#nullable restore
#line 61 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3516, material.Id, 3516, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3528, ");", 3528, 2, true);
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                                    <div><input type=\"number\"");
                BeginWriteAttribute("id", " id=\"", 3603, "\"", 3642, 2);
                WriteAttributeValue("", 3608, "material_serialNumber_", 3608, 22, true);
#nullable restore
#line 62 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3630, material.Id, 3630, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"basicInput\"");
                BeginWriteAttribute("value", " value=\"", 3662, "\"", 3692, 1);
#nullable restore
#line 62 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3670, material.SerialNumber, 3670, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3693, "\"", 3762, 1);
#nullable restore
#line 62 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3707, ViewBag.translate.materialSerialNumberPh[ViewBag.lang], 3707, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onkeyup", " onkeyup=\"", 3763, "\"", 3805, 3);
                WriteAttributeValue("", 3773, "materialWasEdited(", 3773, 18, true);
#nullable restore
#line 62 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3791, material.Id, 3791, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3803, ");", 3803, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 3806, "\"", 3849, 3);
                WriteAttributeValue("", 3817, "materialWasEdited(", 3817, 18, true);
#nullable restore
#line 62 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 3835, material.Id, 3835, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3847, ");", 3847, 2, true);
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n\r\n                                    <div class=\"basicInput\">\r\n                                        <input type=\"date\"");
                BeginWriteAttribute("id", " id=\"", 3983, "\"", 4014, 2);
                WriteAttributeValue("", 3988, "material_date_", 3988, 14, true);
#nullable restore
#line 65 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4002, material.Id, 4002, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"timeInput\"");
                BeginWriteAttribute("value", " value=\"", 4033, "\"", 4114, 1);
#nullable restore
#line 65 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4041, ViewBag.TimestampToDate(@material.InspectionDate).ToString("yyyy-MM-dd"), 4041, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onkeyup", " onkeyup=\"", 4115, "\"", 4157, 3);
                WriteAttributeValue("", 4125, "materialWasEdited(", 4125, 18, true);
#nullable restore
#line 65 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4143, material.Id, 4143, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4155, ");", 4155, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 4158, "\"", 4201, 3);
                WriteAttributeValue("", 4169, "materialWasEdited(", 4169, 18, true);
#nullable restore
#line 65 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4187, material.Id, 4187, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4199, ");", 4199, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"time\"");
                BeginWriteAttribute("id", " id=\"", 4265, "\"", 4296, 2);
                WriteAttributeValue("", 4270, "material_time_", 4270, 14, true);
#nullable restore
#line 66 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4284, material.Id, 4284, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"timeInput\"");
                BeginWriteAttribute("value", " value=\"", 4315, "\"", 4391, 1);
#nullable restore
#line 66 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4323, ViewBag.TimestampToDate(@material.InspectionDate).ToString("HH:mm"), 4323, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onkeyup", " onkeyup=\"", 4392, "\"", 4434, 3);
                WriteAttributeValue("", 4402, "materialWasEdited(", 4402, 18, true);
#nullable restore
#line 66 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4420, material.Id, 4420, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4432, ");", 4432, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 4435, "\"", 4478, 3);
                WriteAttributeValue("", 4446, "materialWasEdited(", 4446, 18, true);
#nullable restore
#line 66 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4464, material.Id, 4464, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4476, ");", 4476, 2, true);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""materialButton"">
                                    <span class=""icon nice-green fas fa-check-circle"" style=""display: none;""");
                BeginWriteAttribute("id", " id=\"", 4738, "\"", 4772, 2);
                WriteAttributeValue("", 4743, "material_saveBtn_", 4743, 17, true);
#nullable restore
#line 70 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4760, material.Id, 4760, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 4773, "\"", 4813, 3);
                WriteAttributeValue("", 4783, "tryEditMaterial(", 4783, 16, true);
#nullable restore
#line 70 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4799, material.Id, 4799, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4811, ");", 4811, 2, true);
                EndWriteAttribute();
                WriteLiteral("></span>\r\n                                    <span class=\"icon nice-red fas fa-minus-circle\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4907, "\"", 4949, 3);
                WriteAttributeValue("", 4917, "tryDeleteMaterial(", 4917, 18, true);
#nullable restore
#line 71 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
WriteAttributeValue("", 4935, material.Id, 4935, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4947, ");", 4947, 2, true);
                EndWriteAttribute();
                WriteLiteral("></span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\timda\source\repos\RFIT\RFIT\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>

        <div class=""modal"" id=""myModal"" tabindex=""-1"" role=""dialog"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""modal-title"">Modal title</h5>
                        <button type=""button"" id=""modal-button-close_1"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"" id=""modal-body"">
                        <p>Modal body text goes here.</p>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""modal-button-ok"" class=""btn btn-primary"">Ok</button>
                        <button type=""button"" id=""modal-button-close_2"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        ");
                WriteLiteral("            </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Material> Html { get; private set; }
    }
}
#pragma warning restore 1591
