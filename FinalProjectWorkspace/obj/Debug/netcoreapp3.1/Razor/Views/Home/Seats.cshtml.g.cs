#pragma checksum "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/Home/Seats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa23f7ba7f14ce92c8e95bc937da67416e44b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Home.Views_Home_Seats), @"mvc.1.0.view", @"/Views/Home/Seats.cshtml")]
namespace FinalProjectWorkspace.Views.Home
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
#line 2 "/Users/jennifertruong/Documents/GitHub/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa23f7ba7f14ce92c8e95bc937da67416e44b9f", @"/Views/Home/Seats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Seats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.seat-charts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery.seat-charts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa23f7ba7f14ce92c8e95bc937da67416e44b9f4331", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"http://code.jquery.com/qunit/qunit-1.14.0.css\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efa23f7ba7f14ce92c8e95bc937da67416e44b9f4675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa23f7ba7f14ce92c8e95bc937da67416e44b9f6529", async() => {
                WriteLiteral(@"
    <div class=""text-center"">


        <div class=""wrapper"">
            <div class=""container"">

                <div class=""booking-details"">
                    <h2>Select Seats</h2>

                    <h3> Selected Seats (<span id=""counter"">0</span>):</h3>
                    <ul id=""selected-seats""></ul>

                    Total: <b>$<span id=""total"">0</span></b>

                    <button class=""checkout-button"">Checkout »</button>

                    <div id=""legend"" class=""seatCharts-legend"">
                        <ul class=""seatCharts-legendList"">
                        </ul>
                    </div>

                </div>


                <div id=""seat-map"" class=""seatCharts-container text-center"" tabindex=""0"" aria-activedescendant=""9_3"">
                    <div class=""front-indicator"">Front</div>

                </div>


            </div>
        </div>

        <script src=""https://code.jquery.com/jquery-1.11.0.min.js""></script>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa23f7ba7f14ce92c8e95bc937da67416e44b9f7798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div id=""seat-map"" class=""seatCharts-container text-center"">


            <script>var firstSeatLabel = 1;

                $(document).ready(function () {
                    var $cart = $('#selected-seats'),
                        $counter = $('#counter'),
                        $total = $('#total'),
                        sc = $('#seat-map').seatCharts({
                            map: [
                                '__ee_ee__',
                                'ffff_ffff',
                                'eeee_eeee',
                            ],
                            seats: {
                                f: {
                                    price: 12,
                                    classes: 'first-class', //your custom CSS class
                                    category: 'First Class'
                                },
                                e: {
                                    price: 12,
                                    classes: 'economy-class', //you");
                WriteLiteral(@"r custom CSS class
                                    category: 'Economy Class'
                                }

                            },
                            naming: {
                                top: false,
                                getLabel: function (character, row, column) {
                                    return firstSeatLabel++;
                                },
                            },
                            legend: {
                                node: $('#legend'),
                                items: [
                                    ['f', 'available', 'First Class'],
                                    ['e', 'available', 'Economy Class'],
                                    ['f', 'unavailable', 'Already Booked']
                                ]
                            },
                            click: function () {
                                if (this.status() == 'available') {
                                    //let's create a new <");
                WriteLiteral(@"li> which we'll add to the cart items
                                    $('<li>' + this.data().category + ' Seat # ' + this.settings.label + ': <b>$' + this.data().price + '</b> <a href=""#"" class=""cancel-cart-item text-light"">[cancel]</a></li>')
                                        .attr('id', 'cart-item-' + this.settings.id)
                                        .data('seatId', this.settings.id)
                                        .appendTo($cart);

                                    /*
                                     * Lets update the counter and total
                                     *
                                     * .find function will not find the current seat, because it will change its stauts only after return
                                     * 'selected'. This is why we have to add 1 to the length and the current seat price to the total.
                                     */
                                    $counter.text(sc.find('selected').length + 1);
           ");
                WriteLiteral(@"                         $total.text(recalculateTotal(sc) + this.data().price);

                                    return 'selected';
                                } else if (this.status() == 'selected') {
                                    //update the counter
                                    $counter.text(sc.find('selected').length - 1);
                                    //and total
                                    $total.text(recalculateTotal(sc) - this.data().price);

                                    //remove the item from our cart
                                    $('#cart-item-' + this.settings.id).remove();

                                    //seat has been vacated
                                    return 'available';
                                } else if (this.status() == 'unavailable') {
                                    //seat has been already booked
                                    return 'unavailable';
                                } else {
                        ");
                WriteLiteral(@"            return this.style();
                                }
                            }
                        });

                    //this will handle ""[cancel]"" link clicks
                    $('#selected-seats').on('click', '.cancel-cart-item', function () {
                        //let's just trigger Click event on the appropriate seat, so we don't have to repeat the logic here
                        sc.get($(this).parents('li:first').data('seatId')).click();
                    });

                    //let's pretend some seats have already been booked
                    sc.get(['1_2', '4_1']).status('unavailable');

                });

                function recalculateTotal(sc) {
                    var total = 0;

                    //basically find every selected seat and sum its price
                    sc.find('selected').each(function () {
                        total += this.data().price;
                    });

                    return total;
                }</script>");
                WriteLiteral("\n        </div>\n    </div>\n");
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
            WriteLiteral("\n</html>");
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
