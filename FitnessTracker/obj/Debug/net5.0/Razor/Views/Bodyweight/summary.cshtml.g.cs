#pragma checksum "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108f2c2a819f9769af0be2cc5466186c175d336d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bodyweight_summary), @"mvc.1.0.view", @"/Views/Bodyweight/summary.cshtml")]
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
#line 1 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\_ViewImports.cshtml"
using FitnessTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\_ViewImports.cshtml"
using FitnessTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108f2c2a819f9769af0be2cc5466186c175d336d", @"/Views/Bodyweight/summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f32eec8951174230163ccfb47475af204de8c6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bodyweight_summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitnessTracker.ViewModels.BodyweightSummaryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Bodyweight/summary.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bodyweight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRecords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTodayWeight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-3 mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTarget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "108f2c2a819f9769af0be2cc5466186c175d336d6426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
  
    ViewData["Title"] = "Bodyweight";

    string FormatWeight(double D)
    {
        //Added this because D = 0 results in "-+0.00kg". Most likely a floating point precision issue.
        if (D == -0)
            D = 0;

        var x = $"{Math.Round(D, 2).ToString("+0.00;-0.00")}kg";
        return x;
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h2 class=\"d-inline\">My Bodyweight</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "108f2c2a819f9769af0be2cc5466186c175d336d8153", async() => {
                WriteLiteral("+Add Bodyweights");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 29 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
 if (Model.MostRecentRecord == null || Model.MostRecentRecord.Date != DateTime.Today)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-3\">\n            <div class=\"alert alert-info mt-3 mb-2\">\n                <h5 class=\"ml-3\">Add Today\'s Weight</h5>\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "108f2c2a819f9769af0be2cc5466186c175d336d10091", async() => {
                WriteLiteral(@"
                    <div class=""input-group form-inline "">
                        <input type=""number"" min=""0"" max=""200"" name=""Weight"" step=""0.1"" class=""form-control mr-1"" required />
                        <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 45 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row my-3"">
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Most Recent Bodyweight</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 57 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                    Write(Model.MostRecentRecord == null ? "0" : Model.MostRecentRecord.Weight.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("kg\n                    </h4>\n                    <div class=\"card-text text-center\">\n");
#nullable restore
#line 60 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                         if (Model.MostRecentRecord != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                        Write(Model.MostRecentRecord.Date.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">This Week's Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 77 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentWeekProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Average (This Week)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 89 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentWeekAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Current Month's Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 104 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentMonthProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Average (This Month)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 116 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentMonthAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">All Time Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 131 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.AllTimeProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Weekly Average (All Time)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 143 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.AllTimeAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">

                <h5 class=""card-subtitle d-"">Target Bodyweight <i class=""far fa-edit float-right"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#TargetModal"">Edit</i></h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"" id=""TargetWeight"" data-target=""");
#nullable restore
#line 161 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                                                                                  Write(Model.Target == null ? 0 : Model.Target.TargetWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                        ");
#nullable restore
#line 162 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                    Write(Model.Target == null ? "0" : Model.Target.TargetWeight.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("kg\n                    </h4>\n                    <div class=\"card-text text-center\">");
#nullable restore
#line 164 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                                                   Write(Model.Target.TargetDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Distance to Target</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 177 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.DistanceToTarget));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Progress Needed</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 191 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.DailyProgressNeeded));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Weekly Progress Needed</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 205 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.WeeklyProgressNeeded));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row mt-3"">
    <div class=""col"">
        <h2 class=""text-center"">This Week</h2>
        <canvas id=""WeekGraph"" style=""max-width:100%;"">
        </canvas>
    </div>
    <div class=""col"">
        <h2 class=""text-center"">This Month</h2>
        <canvas id=""MonthGraph"" style=""max-width:100%;"">
        </canvas>
    </div>
</div>



<div class=""modal fade"" id=""TargetModal"" tabindex=""-1"" aria-labelledby=""TargetModal"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Target</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "108f2c2a819f9769af0be2cc5466186c175d336d22944", async() => {
                WriteLiteral("\n\n                <div class=\"modal-body\">\n\n\n                    <div class=\"form-group\">\n                        <label>Weight</label>\n                        <input class=\"form-control\" name=\"TargetWeight\" type=\"number\" min=\"1\" max=\"300\"");
                BeginWriteAttribute("value", " value=\"", 8641, "\"", 8675, 1);
#nullable restore
#line 244 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
WriteAttributeValue("", 8649, Model.Target.TargetWeight, 8649, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/>\n                    </div>\n\n                    <div class=\"form-group\">\n                        <label>Target Date</label>\n                        <input class=\"form-control\" name=\"TargetDate\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 8893, "\"", 8948, 1);
#nullable restore
#line 249 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Bodyweight\summary.cshtml"
WriteAttributeValue("", 8901, Model.Target.TargetDate.ToString("yyyy-MM-dd"), 8901, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                    <input type=""submit"" class=""btn btn-primary"" value=""Save"">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitnessTracker.ViewModels.BodyweightSummaryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
