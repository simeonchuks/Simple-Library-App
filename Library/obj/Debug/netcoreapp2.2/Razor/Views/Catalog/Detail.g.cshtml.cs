#pragma checksum "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2128f570e560a7c8792a941067a9a660a0bfd8e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Detail), @"mvc.1.0.view", @"/Views/Catalog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Detail.cshtml", typeof(AspNetCore.Views_Catalog_Detail))]
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
#line 1 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 2 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2128f570e560a7c8792a941067a9a660a0bfd8e5", @"/Views/Catalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Catalog.AssetDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(109, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(719, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(737, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(964, 304, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">View Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <img class=""detailImage""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1268, "\"", 1289, 1);
#line 25 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 1274, Model.ImageUrl, 1274, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1290, 119, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <p id=\"itemTitle\">");
            EndContext();
            BeginContext(1410, 11, false);
#line 29 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemAuthor\">");
            EndContext();
            BeginContext(1463, 22, false);
#line 30 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                              Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemStatus\">");
            EndContext();
            BeginContext(1527, 12, false);
#line 31 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                              Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 39, true);
            WriteLiteral("</p>\r\n                <p id=\"itemType\">");
            EndContext();
            BeginContext(1579, 10, false);
#line 32 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                            Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 58, true);
            WriteLiteral("</p>\r\n                <p id=\"itemLocation\">Last Location: ");
            EndContext();
            BeginContext(1648, 21, false);
#line 33 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                               Write(Model.CurrentLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1669, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                 if (@Model.Status == "Lost")
                {

#line default
#line hidden
            BeginContext(1743, 102, true);
            WriteLiteral("                    <p>This item has been lost. It cannot be checked out.</p>\r\n                    <p>");
            EndContext();
            BeginContext(1845, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2128f570e560a7c8792a941067a9a660a0bfd8e511316", async() => {
                BeginContext(1970, 15, true);
                WriteLiteral("Mark Item Found");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                                                                                                        WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1989, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 39 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(2014, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Checked Out")
                {

#line default
#line hidden
            BeginContext(2088, 55, true);
            WriteLiteral("                    <p id=\"itemPatron\">Checked Out By: ");
            EndContext();
            BeginContext(2144, 16, false);
#line 43 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                                  Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(2160, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2189, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2128f570e560a7c8792a941067a9a660a0bfd8e515108", async() => {
                BeginContext(2313, 8, true);
                WriteLiteral("Check In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                                                                                                       WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2325, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2354, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2128f570e560a7c8792a941067a9a660a0bfd8e517923", async() => {
                BeginContext(2475, 10, true);
                WriteLiteral("Place Hold");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                                                                                                    WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2489, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(2514, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                 if (@Model.Status == "Available")
                {

#line default
#line hidden
            BeginContext(2587, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(2610, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2128f570e560a7c8792a941067a9a660a0bfd8e521272", async() => {
                BeginContext(2732, 9, true);
                WriteLiteral("Check Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                                                                                                     WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2745, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 51 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(2770, 225, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-4 detailInfo\">\r\n                <table>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">ISBN: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(2996, 10, false);
#line 58 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                         Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(3006, 172, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Call Number: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(3179, 20, false);
#line 62 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                         Write(Model.DeweyCalNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3199, 178, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Replacement Cost: </td>\r\n                        <td class=\"itemValue\">$");
            EndContext();
            BeginContext(3378, 10, false);
#line 66 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                                          Write(Model.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(3388, 469, true);
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-6"">
            <h4>Checkout History</h4>
            <table class=""table table-bordered table-hover table-condensed"">
                <thead>
                    <tr>
                        <th>Date Loaned</th>
                        <th>Date Returned</th>
                        <th>Card Id</th>
");
            EndContext();
            BeginContext(3896, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 86 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                     if (Model.CheckeoutHistory != null)
                    {
                        

#line default
#line hidden
#line 88 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                         foreach (var checkout in Model.CheckeoutHistory)
                        {

#line default
#line hidden
            BeginContext(4157, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4266, 19, false);
#line 92 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                               Write(checkout.CheckedOut);

#line default
#line hidden
            EndContext();
            BeginContext(4285, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4401, 18, false);
#line 95 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                               Write(checkout.CheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(4419, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4535, 23, false);
#line 98 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                               Write(checkout.LibraryCard.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 101 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                        }

#line default
#line hidden
#line 101 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(4684, 448, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-lg-6"">
            <h4>Current Holds</h4>
            <table class=""table table-bordered table-hover table-condensed"">
                <thead>
                    <tr>
                        <th>Hold Placed</th>
                        <th>Patron</th>
                    </tr>
                </thead>
                <tbody>
                    
");
            EndContext();
#line 117 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                         foreach (var hold in @Model.CurrentHolds)
                        {

#line default
#line hidden
            BeginContext(5227, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5336, 15, false);
#line 121 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                               Write(hold.HoldPlaced);

#line default
#line hidden
            EndContext();
            BeginContext(5351, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5467, 15, false);
#line 124 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                               Write(hold.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(5482, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 127 "C:\Users\A Simeon Chuks\Documents\LIBMOT\Library\Views\Catalog\Detail.cshtml"
                        }

#line default
#line hidden
            BeginContext(5585, 86, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Catalog.AssetDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591