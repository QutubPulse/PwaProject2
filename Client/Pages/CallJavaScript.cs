using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Client.Pages
{
    public class CallJavaScript : ICallJavaScript
    {
        public readonly IJSRuntime iJSRuntime;
        public CallJavaScript(IJSRuntime iJSRuntime)
        {
            this.iJSRuntime = iJSRuntime;
        }

        public async Task Calljs(int value)
        {
           var result =  await iJSRuntime.InvokeAsync<int>("newFunction", value); 

        }
    }
}
