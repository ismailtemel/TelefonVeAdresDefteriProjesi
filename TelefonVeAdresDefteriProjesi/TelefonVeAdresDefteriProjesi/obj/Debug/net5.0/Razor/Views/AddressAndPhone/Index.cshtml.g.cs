#pragma checksum "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0584f1359594a3b21be2e50c6308102db736de4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddressAndPhone_Index), @"mvc.1.0.view", @"/Views/AddressAndPhone/Index.cshtml")]
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
#line 1 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\_ViewImports.cshtml"
using TelefonVeAdresDefteriProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\_ViewImports.cshtml"
using TelefonVeAdresDefteriProjesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0584f1359594a3b21be2e50c6308102db736de4d", @"/Views/AddressAndPhone/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8632c78e3603133d994dd178ac45d1ef4b250fb3", @"/Views/_ViewImports.cshtml")]
    public class Views_AddressAndPhone_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AddressAndPhone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>AdresVeTelefonID</th>
        <th>KişiID</th>
        <th>Adres</th>
        <th>Telefon No</th>
        <th>İlçe</th>
        <th>İl</th>
        <th>Düzenle</th>
        <th>Sil</th>
    </tr>
    <tbody>
");
#nullable restore
#line 20 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
         foreach (var adph in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.AddressAndPhoneID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.PersonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
           Write(adph.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 803, 2);
            WriteAttributeValue("", 740, "/AddressAndPhone/TelefonVeAdresGuncelle/", 740, 40, true);
#nullable restore
#line 29 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
WriteAttributeValue("", 780, adph.AddressAndPhoneID, 780, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 928, 2);
            WriteAttributeValue("", 870, "/AddressAndPhone/TelefonVeAdresSil/", 870, 35, true);
#nullable restore
#line 30 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
WriteAttributeValue("", 905, adph.AddressAndPhoneID, 905, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "D:\PhoneAndAddressBookProject\TelefonVeAdresDefteriProjesi\TelefonVeAdresDefteriProjesi\Views\AddressAndPhone\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/AddressAndPhone/TelefonVeAdresEkle/\" class=\"btn btn-primary\">Yeni Kayıt Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AddressAndPhone>> Html { get; private set; }
    }
}
#pragma warning restore 1591