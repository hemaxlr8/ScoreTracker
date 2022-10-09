#pragma checksum "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61167cd174e4dcb06066b9d56275f78d8ef009a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Scoreboard), @"mvc.1.0.view", @"/Views/Home/Scoreboard.cshtml")]
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
#line 1 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/_ViewImports.cshtml"
using PokerFriends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/_ViewImports.cshtml"
using PokerFriends.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61167cd174e4dcb06066b9d56275f78d8ef009a", @"/Views/Home/Scoreboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82509c23bed9c07ebd01011710c5a430b501d782", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Scoreboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokerFriends.Models.ScoreboardModel>
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
#nullable restore
#line 2 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
  
    ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Scoreboard";
    int playerId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-md-10"">
        <div class=""card text-center border-dark mb-5"">
            <div class=""card-header"">
                <div class=""row"">
                    <div class=""col"">
                        <span class=""float-left"">$");
#nullable restore
#line 14 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                                             Write(Model.BuyInAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Buy-In's</span>
                    </div>
                    <div class=""col"">
                        Player Names (In-order of sitting)
                    </div>
                    <div class=""col"">
                        <button type=""button"" data-toggle=""modal"" data-target=""#addPlayerModal"" class=""btn btn-secondary"">Add Player</button>
                        <button type=""button"" data-toggle=""modal"" data-target=""#resetScoreboardModal"" class=""btn btn-secondary float-right"">Reset</button>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <table class=""table"" id=""tblScoreboard"">
                    <thead>
                        <tr>
                            <th scope=""col"">Player</th>
                            <th scope=""col"">Buy-In's</th>
                            <th scope=""col"">Total $</th>
                            <th scope=""col"">Remaining $</th>
                            <th scope=""col"">Gain/Lo");
            WriteLiteral("ss</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 37 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                         foreach (var player in Model.Players)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td");
            BeginWriteAttribute("id", " id=\"", 1762, "\"", 1787, 2);
            WriteAttributeValue("", 1767, "playerName-", 1767, 11, true);
#nullable restore
#line 40 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 1778, playerId, 1778, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                                                         Write(player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"col-sm-6 text-center\" style=\"display: inline-flex\">\r\n                                        <input type=\"number\" class=\"form-control text-center\"");
            BeginWriteAttribute("id", " id=\"", 2035, "\"", 2056, 2);
            WriteAttributeValue("", 2040, "buyIns-", 2040, 7, true);
#nullable restore
#line 43 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2047, playerId, 2047, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\"", 2057, "\"", 2093, 3);
            WriteAttributeValue("", 2068, "calculateTotal(", 2068, 15, true);
#nullable restore
#line 43 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2083, playerId, 2083, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2092, ")", 2092, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </td>\r\n                                <td>\r\n                                    <p");
            BeginWriteAttribute("id", " id=\"", 2256, "\"", 2282, 2);
            WriteAttributeValue("", 2261, "totalAmount-", 2261, 12, true);
#nullable restore
#line 47 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2273, playerId, 2273, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></p>
                                </td>
                                <td>
                                    <div class=""col-sm-6 text-center"" style=""display: inline-flex"">
                                        <input type=""number"" class=""form-control text-center""");
            BeginWriteAttribute("id", " id=\"", 2561, "\"", 2591, 2);
            WriteAttributeValue("", 2566, "remainingAmount-", 2566, 16, true);
#nullable restore
#line 51 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2582, playerId, 2582, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\"", 2592, "\"", 2633, 3);
            WriteAttributeValue("", 2603, "calculateGainOrLoss(", 2603, 20, true);
#nullable restore
#line 51 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2623, playerId, 2623, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2632, ")", 2632, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span hidden class=\"text-danger\"");
            BeginWriteAttribute("id", " id=\"", 2709, "\"", 2747, 2);
            WriteAttributeValue("", 2714, "remainingAmountValidate-", 2714, 24, true);
#nullable restore
#line 52 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2738, playerId, 2738, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Enter remaining $</span>\r\n                                    </div>\r\n                                </td>\r\n                                <td>\r\n                                    <p");
            BeginWriteAttribute("id", " id=\"", 2934, "\"", 2959, 2);
            WriteAttributeValue("", 2939, "gainOrLoss-", 2939, 11, true);
#nullable restore
#line 56 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
WriteAttributeValue("", 2950, playerId, 2950, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                            playerId++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <span hidden class=""text-danger"" id=""totalsMismatch"">Total remaining amount does not match with total borrowed</span>
            </div>
            <div class=""card-footer text-muted"">
                <button type=""button"" onclick=""simplifyDebts()"" class=""btn btn-primary"">Calculate Debts</button>
            </div>
        </div>
    </div>
</div>

<div class=""row justify-content-center"">
    <div class=""col-md-10"">
        <div class=""card text-center border-dark"">
            <div class=""card-header"">
                Simplified Transactions
            </div>
            <div class=""card-body"">
                <table hidden id=""tblSimplifiedDebts"" class=""table"">
                    <tbody></tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<!--#region Modals-->
<div class=""modal fade"" id=""addPlayerModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addPlayerModalLabel"" aria-hi");
            WriteLiteral(@"dden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addPlayerModalLabel"">Add new player</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e61167cd174e4dcb06066b9d56275f78d8ef009a12418", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group row\">\r\n                        <div class=\"col-sm-6\">\r\n                            <input type=\"text\" class=\"form-control\" name=\"newPlayer\" id=\"newPlayer\"");
                BeginWriteAttribute("value", " value=\"", 4819, "\"", 4827, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Name"" />
                            <span hidden class=""text-danger"" id=""newPlayerValidate"">Enter player name</span>
                            <span hidden class=""text-danger"" id=""newPlayerValidateUniqueName"">Player name already exists</span>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-sm-6"">
                            <label for=""playerPositionSelect"">Player is sitting next to</label>
                            <select class=""form-control"" id=""playersDropdownSelect"">
                            </select>
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
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""addPlayer()"">Add</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""resetScoreboardModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""resetScoreboardModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""resetScoreboardModalLabel"">Scoreboard will be reset with current players</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to continue?</p>
            </d");
            WriteLiteral(@"iv>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""reset()"">Reset</button>
            </div>
        </div>
    </div>
</div>
<!--#endregion-->

<script type=""text/javascript"">
    $(document).ready(function () {
        $('#addPlayerModal').on('show.bs.modal', function (e) {
            var $dropdown = $(""#playersDropdownSelect"");
            $dropdown.find('option').remove().end()
            var table = document.getElementById(""tblScoreboard"");
            var playerCount = table.tBodies[0].rows.length;
            for (var i = 0; i < playerCount; i++) {
                var playerName = $('#playerName-' + i).text();
                $dropdown.append($(""<option />"").val(playerName).text(playerName));
            }
        })
    });
    
    function addPlayer() {
        var selectedPlayer = $('#playersDropdownSelect').fi");
            WriteLiteral(@"nd("":selected"").text();
        var table = document.getElementById(""tblScoreboard"");
        var currentPlayerCount = table.tBodies[0].rows.length;
        var newPlayer = $('#newPlayer').val();
        if (newPlayer == """") {
            $('#newPlayerValidate').removeAttr(""hidden"");
            return false;
        }
        
        // check for duplicates
        for (var i = 0; i < currentPlayerCount; i++) {
            if ($('#playerName-' + i).text() == newPlayer) {
                $('#newPlayerValidateUniqueName').removeAttr(""hidden"");
                error = true;
                return false;
            }
            else {
                $('#newPlayerValidateUniqueName').attr(""hidden"", true);
            }
        }

        // read each table row. 
        // if playerName == selectedPlayer, insert new playerName at this position with other values as null
        // else continue
        // for remaining rows increment id by 1

        $('#newPlayerValidate').attr(""hidd");
            WriteLiteral(@"en"", true);
        var newPlayerId = currentPlayerCount;
        var newRow = ""<tr>""
            + `<td id = ""playerName-${newPlayerId}"">${newPlayer}</td>`
            + `<td>
                <div class=""col-sm-6 text-center"" style=""display: inline-flex"">
                    <input type=""number"" class=""form-control text-center"" id=""buyIns-${newPlayerId}"" onchange=""calculateTotal(${newPlayerId})"">
                </div>
            </td>`
            + `<td>
                <p id=""totalAmount-${newPlayerId}""></p>
            </td>`
            + `<td>
                <div class=""col-sm-6 text-center"" style=""display: inline-flex"">
                    <input type=""number"" class=""form-control text-center"" id=""remainingAmount-${newPlayerId}"" onchange=""calculateGainOrLoss(${newPlayerId})"">
                    <span hidden class=""text-danger"" id=""remainingAmountValidate-${newPlayerId}"">Enter remaining $</span>
                </div>
            </td>`
            + `<td>
                <p id=""ga");
            WriteLiteral(@"inOrLoss-${newPlayerId}""></p>
            </td>`
            + ""</tr>"";
        $('#tblScoreboard tbody').append(newRow);
        $('#addPlayerModal').modal('hide');
    }

    function reset() {
        var table = document.getElementById(""tblScoreboard"");
        var playerCount = table.tBodies[0].rows.length;
        for (var i = 0; i < playerCount; i++) {
            $('#buyIns-' + i).val(null);
            $('#totalAmount-' + i).text("""");
            $('#remainingAmount-' + i).val(null);
            $('#gainOrLoss-' + i).text("""");
        }
        $('#tblSimplifiedDebts tbody').empty();
        $('#resetScoreboardModal').modal('hide');
    }

    function calculateTotal(playerId) {
        var totalAmount = ");
#nullable restore
#line 225 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                     Write(Model.BuyInAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * $(\'#buyIns-\' + playerId).val();\r\n        $(\'#totalAmount-\' + playerId).text(totalAmount);\r\n    }\r\n\r\n    function calculateGainOrLoss(playerId) {\r\n        var remainingAmount = $(\'#remainingAmount-\' + playerId).val();\r\n        var totalAmount = ");
#nullable restore
#line 231 "/Users/hemachandraghanta/Projects/ScoreTracker/PokerFriends/Views/Home/Scoreboard.cshtml"
                     Write(Model.BuyInAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" * $('#buyIns-' + playerId).val();
        var gainorLoss = remainingAmount - totalAmount;
        $('#gainOrLoss-' + playerId).text(gainorLoss);
    }

    function simplifyDebts() {
        // verify totals match
        var table = document.getElementById(""tblScoreboard"");
        var playerCount = table.tBodies[0].rows.length;
        var totalBorrowed = 0;
        var totalRemaining = 0;
        for (var i = 0; i < playerCount; i++) {
            totalBorrowed += parseFloat($('#totalAmount-' + i).text());
            totalRemaining += parseFloat($('#remainingAmount-' + i).val());
        }
        if (totalBorrowed != totalRemaining) {
            $('#totalsMismatch').removeAttr(""hidden"");
            return false;
        }
        else {
            $('#totalsMismatch').attr(""hidden"", true);

        var players = [playerCount];
        var gains = [playerCount];
        for (var i = 0; i < playerCount; i++) {
            players[i] = $('#playerName-' + i).text();
            ");
            WriteLiteral(@"gains[i] = $('#gainOrLoss-' + i).text();
        }
        var postData = { players: players, gains: gains };
        $('#tblSimplifiedDebts').removeAttr(""hidden"");
        $(""#tblSimplifiedDebts tbody tr"").remove();
            $.ajax({
                type: ""POST"",
                url: ""/Home/SimplifyDebts"",
                data: postData,
                success: function (data) {
                    $.each(data, function (i, item) {
                        var rows = ""<tr>""
                            + ""<td>"" + item + ""</td>""
                            + ""</tr>"";
                        $('#tblSimplifiedDebts tbody').append(rows);
                    });
                },
                failure: function (data) {
                    var rows = ""<tr>""
                        + ""<td class='text-danger'> Simplified Debts calculation error</td>""
                        + ""</tr>"";
                    $('#tblSimplifiedDebts tbody').append(rows);
                },
                data");
            WriteLiteral("Type: \"json\",\r\n                traditional: true\r\n            });\r\n        }\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokerFriends.Models.ScoreboardModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591