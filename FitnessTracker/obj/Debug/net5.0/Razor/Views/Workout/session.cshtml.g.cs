#pragma checksum "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb728a23362206a1b2b424b5e8b0bb06d668f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workout_session), @"mvc.1.0.view", @"/Views/Workout/session.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb728a23362206a1b2b424b5e8b0bb06d668f91", @"/Views/Workout/session.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f32eec8951174230163ccfb47475af204de8c6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Workout_session : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkoutSession>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Workout/session.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb728a23362206a1b2b424b5e8b0bb06d668f913859", async() => {
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
            WriteLiteral("\n<style>\n    .downwardsFade {\n        transform: translateY(100px);\n        opacity: 0%;\n        transition: opacity linear 0.1s, transform linear 0.1s;\n    }\n</style>\n\n\n<div class=\"card\">\n    <div class=\"card-header\">\n        <h2 class=\"my-0\">");
#nullable restore
#line 22 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </div>
    <div class=""card-body"">

        <div class=""w-50 mx-auto mb-3"">
            <h1 id=""WorkoutTime"" class=""text-center"" style=""font-size:5rem;"">00:00</h1>
            <button id=""StartWorkoutButton"" type=""button"" class=""btn btn-primary d-block mx-auto"" onclick=""startWorkout_Clicked();"">Start</button>
            <div class=""d-none mx-auto"" id=""PauseStopDiv"">
                <button id=""PauseWorkoutButton"" type=""button"" class=""btn btn-primary d-inline mx-auto"" onclick=""pauseWorkout_Clicked()"">Pause</button>
                <button id=""StopWorkoutButton"" type=""button"" class=""btn btn-danger d-inline mx-auto"" onclick=""stopWorkout_Clicked();"">Stop</button>
            </div>

        </div>

        <table class=""table"" style=""width:80%;margin:auto;"">
            <thead>
                <tr>
                    <th></th>
                    <th>Activity</th>
                    <th>Quantity</th>
                    <th>Sets</th>
                    <th>Rest</th>
                    <th style=""wi");
            WriteLiteral("dth:10%\"></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 48 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                 foreach (WorkoutActivity activity in Model.Activities)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td class=\"align-middle\"><input type=\"checkbox\" class=\"form-control\" style=\"font-size:0.75rem;\" /></td>\n                        <td class=\"align-middle\">");
#nullable restore
#line 52 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                                            Write(activity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"align-middle\">");
#nullable restore
#line 53 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                                            Write(activity.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"align-middle\">");
#nullable restore
#line 54 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                                            Write(activity.Sets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"align-middle\">");
#nullable restore
#line 55 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                                             Write(activity.RestPeriodSeconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" seconds</td>\n");
#nullable restore
#line 56 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                         if (activity.RestPeriodSeconds != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <button type=\"button\"\n                                        class=\"btn btn-primary w-100\"\n                                        data-RestPeriod=\"");
#nullable restore
#line 61 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                                                    Write(activity.RestPeriodSeconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                                        onclick=\"startRest_Clicked(this)\">\n                                    Start Rest\n                                </button>\n                            </td>\n");
#nullable restore
#line 66 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 68 "C:\Users\shnou\Desktop\FitnessTracker\FitnessTracker\Views\Workout\session.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkoutSession> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
