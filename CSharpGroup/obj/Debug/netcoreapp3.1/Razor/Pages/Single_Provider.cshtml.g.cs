#pragma checksum "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e720445c4384909535d1d2d54cd6cbc53880711"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpGroup.Pages.Pages_Single_Provider), @"mvc.1.0.razor-page", @"/Pages/Single_Provider.cshtml")]
namespace CSharpGroup.Pages
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
#line 1 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e720445c4384909535d1d2d54cd6cbc53880711", @"/Pages/Single_Provider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Single_Provider : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AuthOption", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("apply-now-button popup-with-zoom-anim margin-bottom-50 btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "hire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
  
    ViewData["Title"] = "Single Profile Page";


#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 166, "\"", 203, 1);
#nullable restore
#line 8 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
WriteAttributeValue("", 173, Url.Content("~/css/blue.css"), 173, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 233, "\"", 272, 1);
#nullable restore
#line 9 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
WriteAttributeValue("", 240, Url.Content("~/css/style2.css"), 240, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
            }
            );
            WriteLiteral(@"

<!-- Titlebar
================================================== -->
<div class=""single-page-header freelancer-header"" data-background-image=""images/single-freelancer.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""single-page-header-inxner"">
                    <div class=""left-side"">
                        <div class=""header-image freelancer-avatar""><img");
            BeginWriteAttribute("src", " src=\"", 726, "\"", 758, 2);
            WriteAttributeValue("", 732, ".", 732, 1, true);
#nullable restore
#line 21 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
WriteAttributeValue("", 733, Model.providerUser.Image, 733, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 759, "\"", 765, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"header-details\">\r\n                            <h3>");
#nullable restore
#line 23 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                           Write(Model.providerUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                         Write(Model.providerUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <ul>\r\n                                <li><div class=\"star-rating\" data-rating=\"");
#nullable restore
#line 25 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                                     Write(Model.providerUser.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div></li>\r\n                                <li><img class=\"flag\" src=\"images/flags/de.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1161, "\"", 1167, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                                                  Write(Model.providerUser.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                <li><div class=""verified-badge-with-title"">Verified</div></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<!-- Page Content
================================================== -->
<div class=""container"">
    <div class=""row"">

        <!-- Content -->
        <div class=""col-xl-8 col-lg-8 content-right-offset"">

            <!-- Page Content -->
            <div class=""single-page-section"">
                <h3 class=""margin-bottom-25"">About Me</h3>
                <p>");
#nullable restore
#line 49 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
              Write(Model.providerUser.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>

            <!-- Boxed List -->
            <div class=""boxed-list margin-bottom-60"">
                <div class=""boxed-list-headline"">
                    <h3><i class=""icon-material-outline-thumb-up""></i> Work History and Feedback</h3>
                </div>
                <ul class=""boxed-list-ul"">
                    <li>
                        <div class=""boxed-list-item"">
                            <!-- Content -->
                            <div class=""item-content"">
                                <h4>Web, Database and API Developer <span>Rated as Freelancer</span></h4>
                                <div class=""item-details margin-top-10"">
                                    <div class=""star-rating"" data-rating=""5.0""></div>
                                    <div class=""detail-item""><i class=""icon-material-outline-date-range""></i> August 2018</div>
                                </div>
                                <div class=""item-description"">
  ");
            WriteLiteral(@"                                  <p>Excellent programmer - fully carried out my project in a very professional manner. </p>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""boxed-list-item"">
                            <!-- Content -->
                            <div class=""item-content"">
                                <h4>WordPress Theme Installation <span>Rated as Freelancer</span></h4>
                                <div class=""item-details margin-top-10"">
                                    <div class=""star-rating"" data-rating=""5.0""></div>
                                    <div class=""detail-item""><i class=""icon-material-outline-date-range""></i> June 2018</div>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <di");
            WriteLiteral(@"v class=""boxed-list-item"">
                            <!-- Content -->
                            <div class=""item-content"">
                                <h4>Fix Python Selenium Code <span>Rated as Employer</span></h4>
                                <div class=""item-details margin-top-10"">
                                    <div class=""star-rating"" data-rating=""5.0""></div>
                                    <div class=""detail-item""><i class=""icon-material-outline-date-range""></i> May 2018</div>
                                </div>
                                <div class=""item-description"">
                                    <p>I was extremely impressed with the quality of work AND how quickly he got it done. He then offered to help with another side part of the project that we didn't even think about originally.</p>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li>
           ");
            WriteLiteral(@"             <div class=""boxed-list-item"">
                            <!-- Content -->
                            <div class=""item-content"">
                                <h4>PHP Core Website Fixes <span>Rated as Freelancer</span></h4>
                                <div class=""item-details margin-top-10"">
                                    <div class=""star-rating"" data-rating=""5.0""></div>
                                    <div class=""detail-item""><i class=""icon-material-outline-date-range""></i> May 2018</div>
                                </div>
                                <div class=""item-description"">
                                    <p>Awesome work, definitely will rehire. Poject was completed not only with the requirements, but on time, within our small budget.</p>
                                </div>
                            </div>
                        </div>
                    </li>
                </ul>

                <!-- Pagination -->
                <di");
            WriteLiteral(@"v class=""clearfix""></div>
                <div class=""pagination-container margin-top-40 margin-bottom-10"">
                    <nav class=""pagination"">
                        <ul>
                            <li><a href=""#"" class=""ripple-effect current-page"">1</a></li>
                            <li><a href=""#"" class=""ripple-effect"">2</a></li>
                            <li class=""pagination-arrow""><a href=""#"" class=""ripple-effect""><i class=""icon-material-outline-keyboard-arrow-right""></i></a></li>
                        </ul>
                    </nav>
                </div>
                <div class=""clearfix""></div>
                <!-- Pagination / End -->

            </div>
            <!-- Boxed List / End -->
            <!-- Boxed List / End -->

        </div>


        <!-- Sidebar -->
        <div class=""col-xl-4 col-lg-4"">
            <div class=""sidebar-container"">

                <!-- Profile Overview -->
                <div class=""profile-overview"">
          ");
            WriteLiteral("          <div class=\"overview-item\"><strong>$");
#nullable restore
#line 144 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                   Write(Model.providerUser.PerHourWage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><span>Hourly Rate</span></div>\r\n                    <div class=\"overview-item\"><strong>");
#nullable restore
#line 145 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                  Write(Model.providerUser.JobsDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><span>Jobs Done</span></div>\r\n                </div>\r\n\r\n                <!-- Button -->\r\n");
#nullable restore
#line 149 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                  
                    if (Model.loggedUserEmail == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e720445c4384909535d1d2d54cd6cbc5388071116071", async() => {
                WriteLiteral("\r\n                            Sign In to hire\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-providerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                            WriteLiteral(Model.providerUser.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-providerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e720445c4384909535d1d2d54cd6cbc5388071118458", async() => {
                WriteLiteral("\r\n                            Sign up to hire\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-providerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 155 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                       WriteLiteral(Model.providerUser.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-providerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                    }
                    else
                    {
                        if (Model._order == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""button"" class=""apply-now-button popup-with-zoom-anim margin-bottom-50 btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                                HIRE
                            </button>
");
#nullable restore
#line 166 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                        }
                        else
                        {
                            if (Model._order.Status == "accepted")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4 class=\"text-success text-center\">Task undertaking...</h4>\r\n");
#nullable restore
#line 172 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                            }
                            if (Model._order.Status == "pending")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4 class=\"text-primary text-center\">Your request is being processed...</h4>\r\n");
#nullable restore
#line 176 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                            }
                        }

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

            </div>
        </div>

    </div>
</div>



<!-- Button trigger modal -->
<!-- Modal -->
<!-- Button trigger modal -->
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are You sure you want to hire ");
#nullable restore
#line 207 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                         Write(Model.providerUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 207 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                                       Write(Model.providerUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n");
#nullable restore
#line 211 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                 if (Model.loggedUserEmail == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e720445c4384909535d1d2d54cd6cbc5388071124508", async() => {
                WriteLiteral("\r\n                        <button class=\"btn btn-primary\">Confirm</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-providerId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 213 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                    WriteLiteral(Model.providerUser.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["providerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-providerId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["providerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 216 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e720445c4384909535d1d2d54cd6cbc5388071127536", async() => {
                WriteLiteral("\r\n                        <button class=\"btn btn-primary\">Confirm</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-providerId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 219 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                    WriteLiteral(Model.providerUser.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["providerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-providerId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["providerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 219 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                                                                                    WriteLiteral(Model.loggedUser.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["loggedUserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-loggedUserId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["loggedUserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
#nullable restore
#line 222 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Single_Provider.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
        </div>
    </div>
</div>




<script src=""js/jquery-3.3.1.min.js""></script>
<script src=""js/jquery-migrate-3.0.0.min.js""></script>
<script src=""js/mmenu.min.js""></script>
<script src=""js/tippy.all.min.js""></script>
<script src=""js/simplebar.min.js""></script>
<script src=""js/bootstrap-slider.min.js""></script>
<script src=""js/bootstrap-select.min.js""></script>
<script src=""js/snackbar.js""></script>
<script src=""js/clipboard.min.js""></script>
<script src=""js/counterup.min.js""></script>
<script src=""js/magnific-popup.min.js""></script>
<script src=""js/slick.min.js""></script>
<script src=""js/custom.js""></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.Single_ProviderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.Single_ProviderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.Single_ProviderModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.Single_ProviderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
