#pragma checksum "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b535ae8d3269ec0c3b75e4fe502d3e17039e2c"
// <auto-generated/>
#pragma warning disable 1591
namespace PwaProject2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using PwaProject2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using PwaProject2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using PwaProject2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\_Imports.razor"
using PwaProject2.Client.Services.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Product</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-5");
            __builder.AddMarkupContent(7, "<div class=\"p-3 mb-1 bg-primary text-white text-center\">Product Details</div>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                              loProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"name\">Product Name</label>\r\n                    ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "id", "name");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                                    loProduct.stName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loProduct.stName = __value, loProduct.stName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"price\">Price</label>\r\n                    ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "id", "price");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                               loProduct.dcPrice

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loProduct.dcPrice = __value, loProduct.dcPrice));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"quantity\">Quantity</label>\r\n                    ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "id", "quantity");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                                  loProduct.inQuantity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loProduct.inQuantity = __value, loProduct.inQuantity));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"Description\">Description</label>\r\n                    ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "id", "Description");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                                     loProduct.stDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loProduct.stDescription = __value, loProduct.stDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "class", "btn btn-info");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                           (()=>SubmitUpdate(loProduct))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(56, " Save ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-12");
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "class", "table table-bordered");
            __builder.AddMarkupContent(64, @"<thead class=""thead-dark""><tr><th>Product Id</th>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Description</th>
                        <th>Out of Stock</th>
                        <th>View/Update</th>
                        <th>Delete</th></tr></thead>
                ");
            __builder.OpenElement(65, "tbody");
#nullable restore
#line 54 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                     if (loProductList.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                         foreach (var product in loProductList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "tr");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 59 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.inId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 60 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.stName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 61 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.dcPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 62 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.inQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 63 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.stDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 64 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                     product.flgOutOfStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                              (()=>LoadUpdateProductForm(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                ");
            __builder.OpenElement(91, "td");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-danger");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                                                                             (()=>DeleteProduct(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                          }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "<tr><td colspan=\"6\"><strong>No products available</strong></td></tr>");
#nullable restore
#line 72 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\qutubuddin.haider\source\PWA\PwaProject2\PwaProject2\Client\Pages\Index.razor"
    public List<Product> loProductList = new List<Product>();
    public Product loProduct = new Product();
    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        await GetProductList();
        hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub")).Build();
        hubConnection.On("ReceiveMessage", async () => {await GetProductList();StateHasChanged();});
        await hubConnection.StartAsync();
    }
    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;
    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }
    public async Task GetProductList()
    {
        loProductList = await ProductService.LoadProducts();
    }
    public void LoadUpdateProductForm(Product foProduct)
    {
        loProduct = foProduct;
    }
    public async Task SubmitUpdate(Product foProduct)
    {
        loProduct = new Product();
        await ProductService.UpdateProduct(foProduct);
        if (IsConnected) await SendMessage();
        await GetProductList();
        //InvokeAsync(StateHasChanged);
    }
    Task SendMessage() => hubConnection.SendAsync("SendMessage");
    public async Task DeleteProduct(Product foproduct)
    {
        await ProductService.DeleteProduct((int)foproduct.inId);
        if (IsConnected) await SendMessage();
        await GetProductList();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductServices ProductService { get; set; }
    }
}
#pragma warning restore 1591