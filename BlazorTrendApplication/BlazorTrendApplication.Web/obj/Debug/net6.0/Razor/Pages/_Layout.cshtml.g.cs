#pragma checksum "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec44514e2fdf97976744bba4f0884f5d4d280640"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlazorTrendApplication.Web.Pages.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
namespace BlazorTrendApplication.Web.Pages
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
#line 1 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\_Layout.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec44514e2fdf97976744bba4f0884f5d4d280640", @"/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/Pages/_Layout.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec44514e2fdf97976744bba4f0884f5d4d2806404681", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec44514e2fdf97976744bba4f0884f5d4d2806405061", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""css/bootstrap/bootstrap.min.css"" />
    <link href=""css/site.css"" rel=""stylesheet"" />
    <link href=""css/demo.css"" rel=""stylesheet"" />
    <link href=""BlazorTrendApplication.Web.styles.css"" rel=""stylesheet"" />
    <link href=""_content/Blazorise/blazorise.css"" rel=""stylesheet"" />
    <link href=""_content/Blazorise.Bootstrap/blazorise.bootstrap.css"" rel=""stylesheet"" />
    <link href=""_content/Blazorise.Snackbar/blazorise.snackbar.css"" rel=""stylesheet"" />
    <script src=""https://kit.fontawesome.com/b7926f3752.js"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec44514e2fdf97976744bba4f0884f5d4d2806406777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 19 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(HeadOutlet);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.ServerPrerendered;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec44514e2fdf97976744bba4f0884f5d4d2806409566", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line (22,6)-(22,18) 6 "C:\Kishan\demoprj\Blazor\BlazorTrendApplication\BlazorTrendApplication\BlazorTrendApplication.Web\Pages\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div id=\"blazor-error-ui\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec44514e2fdf97976744bba4f0884f5d4d28064010151", async() => {
                    WriteLiteral("\r\n            An error has occurred. This application may no longer respond until reloaded.\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec44514e2fdf97976744bba4f0884f5d4d28064011509", async() => {
                    WriteLiteral("\r\n            An unhandled exception has occurred. See browser dev tools for details.\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 1392, "\"", 1399, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""reload"">Reload</a>
        <a class=""dismiss"">🗙</a>
    </div>

    <script src=""_framework/blazor.server.js""></script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyD-EZ-RUForDMgPSuR2j3LrovBcwPWsMZo&libraries=places""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <script src=""_content/Blazorise/blazorise.js""></script>
    <script src=""_content/Blazorise.Bootstrap/blazorise.bootstrap.js""></script>

    <script>

                var map;
                var marker;
                var markers = [];
                var searchBox;
                var address = ""new york city"";
                var geocoder;

               function initialize() {

                   var latlng = new google.maps.LatLng(-34.39");
                WriteLiteral(@"7, 150.644);
                   var options = {
                       zoom: 7, center: latlng,
                       mapTypeId: google.maps.MapTypeId.ROADMAP,
                       mapTypeControl: false
                   };


                   map = new google.maps.Map(document.getElementById
                           (""map""), options);

                    geocoder = new google.maps.Geocoder();


                          marker = new google.maps.Marker({
                         map: map,
                       title: address,
                       position: latlng
                   });


                  // Append card when map renders
                  //google.maps.event.addListener(map, 'idle', function(e) {
                  //  if ( $( "".place-card"" ).length === 0 ) {
                  //  $("".gm-style"").append('<div style=""position: absolute; left: 0px; top: 0px;""> <div style=""margin: 10px; padding: 1px; -webkit-box-shadow: rgba(0, 0, 0, 0.298039) 0px 1px 4px -1px; bo");
                WriteLiteral(@"x-shadow: rgba(0, 0, 0, 0.298039) 0px 1px 4px -1px; border-radius: 2px; background-color: white;""> <div> <div class=""place-card place-card-large""> <div class=""place-desc-large""> <div class=""place-name""> Tenuta Cigliano </div><div class=""address""> Contrada Pisciarelli, 80078 Napoli, Italy </div></div><div class=""navigate""> <div class=""navigate""> <a class=""navigate-link"" href=""https://maps.google.com/maps?ll=40.837067,14.136834&amp;z=16&amp;t=m&amp;hl=en-US&amp;gl=PT&amp;mapclient=embed&amp;daddr=Tenuta%20Cigliano%20Contrada%20Pisciarelli%2080078%20Napoli%20Italy@40.837067,14.142821"" target=""_blank""> <div class=""icon navigate-icon""></div><div class=""navigate-text""> Directions </div></a> </div></div><div class=""review-box""> <div class="""" style=""display:none""></div><div class="""" style=""display:none""></div><div class="""" style=""display:none""></div><div class="""" style=""display:none""></div><div class="""" style=""display:none""></div><div class="""" style=""display:none""></div><a href=""https://plus.google.com/10164343101264");
                WriteLiteral(@"0484007/about?hl=en&amp;authuser=0&amp;gl=pt&amp;socpid=247&amp;socfid=maps_embed:placecard"" target=""_blank"">1 review</a> </div><div class=""saved-from-source-link"" style=""display:none""> </div><div class=""maps-links-box-exp""> <div class=""time-to-location-info-exp"" style=""display:none""> <span class=""drive-icon-exp experiment-icon""></span><a class=""time-to-location-text-exp"" style=""display:none"" target=""_blank""></a><a class=""time-to-location-text-exp"" style=""display:none"" target=""_blank""></a> </div><div class=""google-maps-link""> <a href=""https://maps.google.com/maps?ll=40.837067,14.136834&amp;z=16&amp;t=m&amp;hl=en-US&amp;gl=PT&amp;mapclient=embed&amp;cid=2152474408176797502"" target=""_blank"">View larger map</a> </div></div><div class=""time-to-location-privacy-exp"" style=""display:none""> <div class=""only-visible-to-you-exp""> Visible only to you. </div><a class=""learn-more-exp"" target=""_blank"">Learn more</a> </div></div></div></div></div>');
                  //  }
                  //  });

                  /");
                WriteLiteral(@"/Bind the textbox
                  var input =(document.getElementById('searchMap'));
                  searchBox = new google.maps.places.SearchBox((input));

                   google.maps.event.addListener(searchBox, 'places_changed', function () {
                       var places = searchBox.getPlaces();
                       if (places.length == 0) {
                           return;
                       }
                       markers = [];
                       var bounds = new google.maps.LatLngBounds();
                       for (var i = 0, place; place = places[i]; i++) {
                           var image = {
                               url: place.icon,
                               size: new google.maps.Size(71, 71),
                               origin: new google.maps.Point(0, 0),
                               anchor: new google.maps.Point(17, 34),
                               scaledSize: new google.maps.Size(25, 25)
                           };

         ");
                WriteLiteral(@"                  // Create a marker for each place.
                           marker = new google.maps.Marker({
                               map: map,
                               icon: image,
                               title: place.name,
                               position: place.geometry.location
                           });
                           console.log('marker: ', marker);
                           markers.push(marker);
                           bounds.extend(place.geometry.location);
                            }
                       map.fitBounds(bounds);
                   });

                // Create the initial InfoWindow.
                let infoWindow = new google.maps.InfoWindow({
                  content: ""Click the map to get Lat/Lng!"",
                  position: latlng,
                });

                infoWindow.open(map);
                map.addListener(""click"", (mapsMouseEvent) => {
                    debugger
                  inf");
                WriteLiteral(@"oWindow.close();
                  infoWindow = new google.maps.InfoWindow({
                    position: mapsMouseEvent.latLng,
                  });
                  infoWindow.setContent(
                    JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2)
                  );
                  infoWindow.open(map);
                });


        //  google.maps.event.addListener(map, 'click', function(event) {
        //      debugger
        //  geocoder.geocode({
        //    'latLng': event.latLng
        //  }, function(results, status) {
        //      debugger
        //    if (status == google.maps.GeocoderStatus.OK) {
        //      if (results[0]) {
        //      console.log(results[0]);
        //      //  alert(results[0].formatted_address);
        //      }
        //    }
        //  });
        //});
            }


    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
