#pragma checksum "D:\PushGit\eShopCommerce\eShopCommerce\Views\eShop\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75af28ed12cd5e65f00ae045dfc56089790fd20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_eShop_Wishlist), @"mvc.1.0.view", @"/Views/eShop/Wishlist.cshtml")]
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
#line 1 "D:\PushGit\eShopCommerce\eShopCommerce\Views\_ViewImports.cshtml"
using eShopCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PushGit\eShopCommerce\eShopCommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PushGit\eShopCommerce\eShopCommerce\Views\_ViewImports.cshtml"
using eShopCommerce.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PushGit\eShopCommerce\eShopCommerce\Views\_ViewImports.cshtml"
using eShopCommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75af28ed12cd5e65f00ae045dfc56089790fd20", @"/Views/eShop/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa25262cfad503dff733df1bc983c8015ab5bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_eShop_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("new-wishlists-box primari-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("savewishlist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "eshop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "myaccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""main-content-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <!-- BSTORE-BREADCRUMB START -->
                <div class=""bstore-breadcrumb"">
                    <a href=""index.html"">HOMe <span><i class=""fa fa-caret-right""></i> </span> </a>
                    <a href=""my-account.html""> my account <span><i class=""fa fa-caret-right""></i></span></a>
                    <span> My wishlists</span>
                </div>
                <!-- BSTORE-BREADCRUMB END -->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                <!-- SINGLE SIDEBAR TAG START -->
                <div class=""product-left-sidebar"">
                    <h2 class=""left-title pro-g-page-title"">Tags </h2>
                    <div class=""category-tag"">
                        <a href=""#"">fashion</a>
                        <a href=""");
            WriteLiteral(@"#"">handbags</a>
                        <a href=""#"">men</a>
                        <a href=""#"">Kids</a>
                        <a href=""#"">women</a>
                        <a href=""#"">New</a>
                        <a href=""#"">Accessories</a>
                        <a href=""#"">clothing</a>
                        <a href=""#"">New</a>
                    </div>
                </div>
                <!-- SINGLE SIDEBAR TAG END -->
            </div>
            <div class=""col-lg-9 col-md-9 col-sm-9 col-xs-12"">
                <h2 class=""page-title"">My wishlists</h2>
                <!-- WISHLISTS-AREA START -->
                <div class=""wishlists-area"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd208178", async() => {
                WriteLiteral(@"
                        <h3 class=""box-subheading"">New wishlist</h3>
                        <div class=""primary-box-content"">
                            <div class=""form-group wishlists-form-group primary-form-group"">
                                <label for=""wishlist"">Name</label>
                                <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2158, "\"", 2166, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""wishlist"" id=""wishlist"" class=""form-control input-feild white"">
                            </div>
                            <div class=""submit-button"">
                                <a href=""#"" id=""savewishlish"" class=""btn main-btn"">Save <i class=""fa fa-chevron-right""></i></a>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- WISHLISTS-AREA END -->
                <!-- WISHLISTS-CHART START -->
                <div class=""wishlists-chart table-responsive"">
                    <table class=""table table-bordered"">
                        <tbody>
                            <tr>
                                <th class=""wish-name"">Name</th>
                                <th class=""wish-qty"">Qty</th>
                                <th class=""wish-view"">Viewed</th>
                                <th class=""wish-create"">Created</th>
                                <th class=""wish-link"">Direct Link</th>
                                <th class=""wish-default"">Default</th>
                                <th class=""wish-delete"">Delete</th>
                            </tr>
                            <tr>
                                <td>
                                    <a href=""#"">My wishlist </a>
                                </td>
                           ");
            WriteLiteral(@"     <td>
                                    <span>3</span>
                                </td>
                                <td>
                                    <span>0</span>
                                </td>
                                <td>
                                    <span>2015-08-06</span>
                                </td>
                                <td>
                                    <a href=""#"">View </a>
                                </td>
                                <td>
                                    <span><i class=""fa fa-check-square""></i></span>
                                </td>
                                <td>
                                    <a class=""dele-wish-list"" href=""#""><i class=""fa fa-close""></i></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <!-- WISHLISTS-CHART END -->
       ");
            WriteLiteral(@"         <!-- WISHLISTS-ITEM START -->
                <div class=""wishlists-item"">
                    <div class=""wishlists-item-title"">
                        <a href=""#"">Hide product show bought products' info <i class=""fa fa-close""></i></a>
                    </div>
                    <div class=""Permalink"">
                        <p>Permalink:</p>
                        <input type=""text"" readonly=""readonly"" value=""htpp://bootexpert.com/product/single-item"" class=""form-control view-permalink"">
                        <a href=""#"" class=""send-wish-list"">Send this wishlist</a>
                    </div>
                    <div class=""wishlists-all-item"">
                        <div class=""row"">
                            <div class=""col-md-3 col-sm-4 col-xs-12"">
                                <!-- WISHLISTS-SINGLE-ITEM START -->
                                <div class=""wishlists-single-item"">
                                    <div class=""wishlist-image"">
                      ");
            WriteLiteral("                  <a href=\"#\"><img src=\"img/wishlist/printed-chiffon-dress.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5707, "\"", 5713, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""wishlist-title"">
                                        <p>Printed Casul Dress <a href=""#""><i class=""fa fa-close""></i></a></p>
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Quantity: </label>
                                        <input type=""text"" value=""1"" name=""quantity"" class=""form-control input-feild"">
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Priority: </label>
                                        <div class=""wish-prioriti"">
                                            <select name=""wishprioriti"" id=""wishPrioriti1"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2015218", async() => {
                WriteLiteral("High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2016424", async() => {
                WriteLiteral("Medium");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2017632", async() => {
                WriteLiteral("Low");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <a class=""wish-save"" href=""#"">Save</a>
                                </div>
                                <!-- WISHLISTS-SINGLE-ITEM END -->
                            </div>
                            <div class=""col-md-3 col-sm-4 col-xs-12"">
                                <!-- WISHLISTS-SINGLE-ITEM START -->
                                <div class=""wishlists-single-item"">
                                    <div class=""wishlist-image"">
                                        <a href=""#""><img src=""img/wishlist/printed-dress.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7628, "\"", 7634, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""wishlist-title"">
                                        <p>Sleeves T-shirt <a href=""#""><i class=""fa fa-close""></i></a></p>
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Quantity: </label>
                                        <input type=""text"" value=""1"" name=""quantity"" class=""form-control input-feild"">
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Priority: </label>
                                        <div class=""wish-prioriti"">
                                            <select name=""wishprioriti"" id=""wishPrioriti2"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2020682", async() => {
                WriteLiteral("High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2021888", async() => {
                WriteLiteral("Medium");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2023096", async() => {
                WriteLiteral("Low");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <a class=""wish-save"" href=""#"">Save</a>
                                </div>
                                <!-- WISHLISTS-SINGLE-ITEM END -->
                            </div>
                            <div class=""col-md-3 col-sm-4 col-xs-12"">
                                <!-- WISHLISTS-SINGLE-ITEM START -->
                                <div class=""wishlists-single-item"">
                                    <div class=""wishlist-image"">
                                        <a href=""#""><img src=""img/wishlist/printed-summer-dress.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9552, "\"", 9558, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""wishlist-title"">
                                        <p>Clothing Summer Dresses <a href=""#""><i class=""fa fa-close""></i></a></p>
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Quantity: </label>
                                        <input type=""text"" value=""1"" name=""quantity"" class=""form-control input-feild"">
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Priority: </label>
                                        <div class=""wish-prioriti"">
                                            <select name=""wishprioriti"" id=""wishPrioriti3"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2026161", async() => {
                WriteLiteral("High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2027367", async() => {
                WriteLiteral("Medium");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2028575", async() => {
                WriteLiteral("Low");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <a class=""wish-save"" href=""#"">Save</a>
                                </div>
                                <!-- WISHLISTS-SINGLE-ITEM END -->
                            </div>
                            <div class=""col-md-3 col-sm-4 col-xs-12 hidden-sm"">
                                <!-- WISHLISTS-SINGLE-ITEM START -->
                                <div class=""wishlists-single-item"">
                                    <div class=""wishlist-image"">
                                        <a href=""#""><img src=""img/wishlist/faded-short-sleeves-tshirt.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11500, "\"", 11506, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""wishlist-title"">
                                        <p>Blouse <a href=""#""><i class=""fa fa-close""></i></a></p>
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Quantity: </label>
                                        <input type=""text"" value=""1"" name=""quantity"" class=""form-control input-feild"">
                                    </div>
                                    <div class=""form-group primary-form-group wishlists-form-group"">
                                        <label>Priority: </label>
                                        <div class=""wish-prioriti"">
                                            <select name=""wishprioriti"" id=""wishPrioriti4"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2031641", async() => {
                WriteLiteral("High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2032847", async() => {
                WriteLiteral("Medium");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2034055", async() => {
                WriteLiteral("Low");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <a class=""wish-save"" href=""#"">Save</a>
                                </div>
                                <!-- WISHLISTS-SINGLE-ITEM END -->
                            </div>
                        </div>
                        <!-- WISH-LIST BACT HOME START-->
                        <div class=""wish-back-link"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2035757", async() => {
                WriteLiteral("<i class=\"fa fa-chevron-left\"></i> Back to Your Account");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75af28ed12cd5e65f00ae045dfc56089790fd2037198", async() => {
                WriteLiteral("<i class=\"fa fa-chevron-left\"></i> Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <!-- WISH-LIST BACT HOME END -->\r\n                    </div>\r\n                </div>\r\n                <!-- WISHLISTS-ITEM END -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
