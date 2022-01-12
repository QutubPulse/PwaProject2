// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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